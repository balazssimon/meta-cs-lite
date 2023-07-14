using MetaDslx.CodeGeneration;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    [Flags]
    public enum CompleteMethodParameters
    {
        None = 0,
        LocationOpt = 1,
        Diagnostics = 2,
        CancellationToken = 4,
        All = Diagnostics | CancellationToken,
        AllWithLocation = LocationOpt | All
    }

    public class SymbolGenerationInfo
    {
        public SymbolGenerationInfo(string name, string namespaceName, SymbolGenerationInfo parentSymbol)
        {
            this.Name = name;
            this.NamespaceName = namespaceName;
            this.ParentSymbol = parentSymbol;
            this.IsSymbolClass = name == "Symbol" && parentSymbol == null;
        }

        public bool IsSymbolClass { get; private set; }
        public bool IsAbstract { get; set; }
        public SymbolParts SymbolParts { get; set; }
        public ParameterOption ModelObjectOption { get; set; }
        public string Name { get; private set; }
        public string NamespaceName { get; private set; }
        public SymbolGenerationInfo ParentSymbol { get; private set; }
        public List<CompletionPartGenerationInfo> CompletionParts { get; set; }
        public ExistingTypeInfo ExistingTypeInfo { get; set; }
        public ExistingTypeInfo ExistingErrorTypeInfo { get; set; }
        public ExistingTypeInfo ExistingCompletionTypeInfo { get; set; }
        public ExistingTypeInfo ExistingMetadataTypeInfo { get; set; }
        public ExistingTypeInfo ExistingSourceTypeInfo { get; set; }

        public IEnumerable<SymbolPropertyGenerationInfo> Properties => this.CompletionParts.OfType<SymbolPropertyGenerationInfo>();
        public IEnumerable<SymbolMethodGenerationInfo> Methods => this.CompletionParts.OfType<SymbolMethodGenerationInfo>();

        public IEnumerable<string> GetCompletionPartNames()
        {
            foreach (var part in this.CompletionParts)
            {
                if (part.IsLocked)
                {
                    yield return part.StartCompletionPartName;
                    yield return part.FinishCompletionPartName;
                }
                else
                {
                    yield return part.CompletionPartName;
                }
            }
        }

        public string GetCompletionPartValue(string name)
        {
            foreach (var part in this.CompletionParts)
            {
                if (part.IsLocked)
                {
                    if (name == part.StartCompletionPartName || name == part.FinishCompletionPartName) return GetCompletionPartValue(part.ContainingTypeFullName, name);
                }
                else
                {
                    if (name == part.CompletionPartName) return GetCompletionPartValue(part.ContainingTypeFullName, name);
                }
            }
            return name;
        }

        private string GetCompletionPartValue(string? containingTypeFullName, string name)
        {
            if (containingTypeFullName is not null && containingTypeFullName != NamespaceName + "." + Name) return containingTypeFullName + ".CompletionParts." + name;
            else return $"new CompletionPart(nameof({name}))";
        }

        public IEnumerable<string> GetOrderedCompletionParts(bool withLocation)
        {
            yield return "CompletionGraph.StartInitializing";
            yield return "CompletionGraph.FinishInitializing";
            yield return "CompletionGraph.StartCreatingChildren";
            yield return "CompletionGraph.FinishCreatingChildren";
            foreach (var part in this.CompletionParts)
            {
                if (part.IsLocked)
                {
                    yield return part.StartCompletionPartName;
                    yield return part.FinishCompletionPartName;
                }
                else
                {
                    yield return part.CompletionPartName;
                }
            }
            yield return "CompletionGraph.StartComputingNonSymbolProperties";
            yield return "CompletionGraph.FinishComputingNonSymbolProperties";
            if (!withLocation)
            {
                yield return "CompletionGraph.ChildrenCompleted";
                yield return "CompletionGraph.StartValidatingSymbol";
                yield return "CompletionGraph.FinishValidatingSymbol";
            }
        }
    }

    public class CompletionPartGenerationInfo
    {
        public CompletionPartGenerationInfo(string containingTypeFullName, string name, string completeMethodName, CompleteMethodParameters completeMethodParameters, bool generateCompleteMethod, bool locked)
        {
            this.ContainingTypeFullName = containingTypeFullName;
            this.CompletionPartName = name;
            this.CompleteMethodName = completeMethodName;
            this.CompleteMethodParameters = completeMethodParameters;
            this.GenerateCompleteMethod = generateCompleteMethod;
            this.IsLocked = locked;
        }

        public string ContainingTypeFullName { get; private set; }
        public string CompletionPartName { get; private set; }
        public string StartCompletionPartName => this.IsLocked ? "Start" + CompletionPartName : CompletionPartName;
        public string FinishCompletionPartName => this.IsLocked ? "Finish" + CompletionPartName : CompletionPartName;
        public string CompleteMethodName { get; private set; }
        public virtual string CompleteMethodReturnType => "void";
        public CompleteMethodParameters CompleteMethodParameters { get; private set; }
        public bool IsLocked { get; private set; }
        public bool GenerateCompleteMethod { get; private set; }

        public string CompleteMethodParamList
        {
            get
            {
                var cb = CodeBuilder.GetInstance();
                if (this.CompleteMethodParameters.HasFlag(CompleteMethodParameters.LocationOpt))
                {
                    if (cb.Length > 0) cb.Write(", ");
                    cb.Write("SourceLocation locationOpt");
                }
                if (this.CompleteMethodParameters.HasFlag(CompleteMethodParameters.Diagnostics))
                {
                    if (cb.Length > 0) cb.Write(", ");
                    cb.Write("DiagnosticBag diagnostics");
                }
                if (this.CompleteMethodParameters.HasFlag(CompleteMethodParameters.CancellationToken))
                {
                    if (cb.Length > 0) cb.Write(", ");
                    cb.Write("CancellationToken cancellationToken");
                }
                return cb.ToStringAndFree();
            }
        }

        public string CompleteMethodArgList
        {
            get
            {
                var cb = CodeBuilder.GetInstance();
                if (this.CompleteMethodParameters.HasFlag(CompleteMethodParameters.LocationOpt))
                {
                    if (cb.Length > 0) cb.Write(", ");
                    cb.Write("locationOpt");
                }
                if (this.CompleteMethodParameters.HasFlag(CompleteMethodParameters.Diagnostics))
                {
                    if (cb.Length > 0) cb.Write(", ");
                    cb.Write("diagnostics");
                }
                if (this.CompleteMethodParameters.HasFlag(CompleteMethodParameters.CancellationToken))
                {
                    if (cb.Length > 0) cb.Write(", ");
                    cb.Write("cancellationToken");
                }
                return cb.ToStringAndFree();
            }
        }
    }

    public class SymbolMethodGenerationInfo : CompletionPartGenerationInfo
    {
        public SymbolMethodGenerationInfo(string containingTypeFullName, string name, CompleteMethodParameters completeMethodParameters, bool locked)
            : base(containingTypeFullName, name, name, completeMethodParameters, false, locked)
        {
        }
    }

    public class SymbolPropertyGenerationInfo : CompletionPartGenerationInfo
    {
        public SymbolPropertyGenerationInfo(string containingTypeFullName, string name, string type, string itemType, bool isAbstract, bool isSymbol, CompleteMethodParameters completeMethodParameters, bool generateCompleteMethod)
            : base(containingTypeFullName, "ComputingProperty_" + name, "CompleteSymbolProperty_" + name, completeMethodParameters, generateCompleteMethod, true)
        {
            this.Name = name;
            this.FieldName = "_" + name.ToCamelCase();
            this.Type = type;
            this.ItemType = itemType;
            this.IsAbstract = isAbstract;
            this.IsSymbol = isSymbol;
            this.IsCollection = itemType != null;
        }

        public string Name { get; private set; }
        public string FieldName { get; private set; }
        public string Type { get; private set; }
        public string ItemType { get; private set; }
        public bool IsAbstract { get; private set; }
        public bool IsSymbol { get; private set; }
        public bool IsCollection { get; private set; }

        public override string CompleteMethodReturnType => this.Type;
    }

    public class ExistingTypeInfo
    {
        public ExistingTypeInfo(bool isSealed, string baseType, HashSet<string> members)
        {
            this.IsSealed = isSealed;
            this.BaseType = baseType;
            this.Members = members;
        }

        public bool IsSealed { get; set; }
        public string BaseType { get; set; }
        public HashSet<string> Members { get; set; }
    }
}
