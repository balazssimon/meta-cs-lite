using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.Uml.Model
{
    internal static class UmlImportExtensions
    {
        public static IEnumerable<Classifier> MBaseClassifiers(this Classifier cls)
        {
            var result = new UniqueList<Classifier>();
            if (cls.MModel is null) return result;
            result.AddRange(cls.MModel.Objects.OfType<Realization>().Where(d => d.Client.Contains(cls)).SelectMany(d => d.Supplier).OfType<Classifier>());
            result.AddRange(cls.MModel.Objects.OfType<Generalization>().Where(d => d.Specific == cls).Select(d => d.General).OfType<Classifier>());
            return result;
        }

        public static IEnumerable<Classifier> MAllBaseClassifiers(this Classifier cls)
        {
            var result = new List<Classifier>();
            result.AddRange(cls.MBaseClassifiers());
            for (int i = 0; i < result.Count; i++)
            {
                var baseCls = result[i];
                foreach (var ancestorCls in baseCls.MBaseClassifiers())
                {
                    if (!result.Contains(ancestorCls)) result.Add(ancestorCls);
                }
            }
            return result;
        }

        public static IEnumerable<Operation> MAllOperations(this Classifier cls)
        {
            var result = new List<Operation>();
            if (cls is Class @class) result.AddRange(@class.OwnedOperation);
            else if (cls is Interface intf) result.AddRange(intf.OwnedOperation);
            var allBaseClassifiers = cls.MAllBaseClassifiers().ToList();
            foreach (var baseClassifier in allBaseClassifiers)
            {
                if (baseClassifier is Interface baseIntf)
                {
                    foreach (var op in baseIntf.OwnedOperation)
                    {
                        if (!result.Contains(op)) result.Add(op);
                    }
                }
                if (baseClassifier is Class baseCls)
                {
                    foreach (var op in baseCls.OwnedOperation)
                    {
                        if (!result.Contains(op)) result.Add(op);
                    }
                }
            }
            return result;
        }

        public static Operation MResolveOperationBySignature(this Classifier cls, string signature)
        {
            if (cls == null || signature == null) return null;
            string operationName = signature;
            var argNames = new List<string>();
            int openParenIndex = signature.IndexOf('(');
            if (openParenIndex > 0)
            {
                operationName = signature.Substring(0, openParenIndex);
                var argList = signature.Substring(openParenIndex + 1);
                int closeParenIndex = argList.IndexOf(')');
                if (closeParenIndex > 0)
                {
                    argList = argList.Substring(0, closeParenIndex);
                    int state = 0;
                    var builder = PooledStringBuilder.GetInstance();
                    var argName = builder.Builder;
                    foreach (var ch in argList)
                    {
                        if (state == 0)
                        {
                            if (ch == ',')
                            {
                                argNames.Add(argName.ToString());
                                argName.Clear();
                            }
                            else if (ch == '"')
                            {
                                argName.Append(ch);
                                state = 1;
                            }
                            else
                            {
                                argName.Append(ch);
                            }
                        }
                        else
                        {
                            argName.Append(ch);
                            if (ch == '"')
                            {
                                state = 0;
                            }
                        }
                    }
                    if (argName.Length > 0 || argNames.Count > 0)
                    {
                        argNames.Add(argName.ToString());
                    }
                    builder.Free();
                }
            }
            List<Operation> operations = cls.MAllOperations().Where(op => operationName.Equals(op.Name, StringComparison.InvariantCultureIgnoreCase)).ToList();
            if (operations != null && operations.Count > 0)
            {
                if (operations.Count > 1)
                {
                    operations = operations.Where(op => op.OwnedParameter.Where(p => p.Direction != ParameterDirectionKind.Return).Count() == argNames.Count).ToList();
                }
                if (operations.Count > 0)
                {
                    return operations[0];
                }
            }
            return null;
        }
    }
}
