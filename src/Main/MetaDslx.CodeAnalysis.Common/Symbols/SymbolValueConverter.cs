using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.Modeling;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public class SymbolValueConverter
    {
        private readonly Compilation _compilation;

        public SymbolValueConverter(Compilation compilation)
        {
            _compilation = compilation;
        }

        public Compilation Compilation => _compilation;

        public virtual bool TryConvertTo(object? value, MetaType expectedType, out object? convertedValue, Binder valueBinder, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (expectedType.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaType || expectedType.IsAssignableTo(typeof(TypeSymbol)))
            {
                var tmpValue = value;
                TypeSymbol? valueTypeSymbol;
                if (tmpValue is MetaSymbol ms)
                {
                    if (ms.OriginalValue is string mss) tmpValue = mss;
                    else if (ms.OriginalValue is Type mst) tmpValue = mst;
                    else if (ms.OriginalSymbol is TypeSymbol msts) tmpValue = msts;
                }
                if (tmpValue is string s) valueTypeSymbol = MetaType.FromName(s).AsTypeSymbol(this.Compilation);
                else if (tmpValue is Type t) valueTypeSymbol = MetaType.FromType(t).AsTypeSymbol(this.Compilation);
                else if (tmpValue is TypeSymbol ts)
                {
                    if (ts.IsError)
                    {
                        convertedValue = null;
                        return false;
                    }
                    valueTypeSymbol = MetaType.FromTypeSymbol(ts).AsTypeSymbol(this.Compilation);
                }
                else if (tmpValue is MetaType mt) valueTypeSymbol = mt.AsTypeSymbol(this.Compilation);
                else valueTypeSymbol = null;
                if (valueTypeSymbol is null)
                {
                    if (value is string stringValue)
                    {
                        var specialType = MetaType.FromName(stringValue);
                        if (specialType.MetaKeyword is not null)
                        {
                            convertedValue = specialType;
                            return true;
                        }
                    }
                    if (expectedType.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaType)
                    {
                        if (value is MetaType mt2)
                        {
                            convertedValue = mt2;
                            return true;
                        }
                        else
                        {
                            convertedValue = MetaSymbol.FromValue(value);
                            return true;
                        }
                    }
                    if (value is Symbol valueSymbol && valueSymbol.IsError)
                    {
                        convertedValue = null;
                        return false;
                    }
                    convertedValue = null;
                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, valueBinder.Location, $"Could not resolve TypeSymbol for '{value}'."));
                    return false;
                }
                else if (valueTypeSymbol.IsError)
                {
                    convertedValue = null;
                    return false;
                }
                else
                {
                    if (expectedType.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaType) convertedValue = MetaType.FromTypeSymbol(valueTypeSymbol);
                    else convertedValue = valueTypeSymbol;
                    return true;
                }
            }
            else if (expectedType.SpecialType == SpecialType.System_Type)
            {
                var tmpValue = value;
                Type? valueType;
                if (tmpValue is MetaSymbol ms)
                {
                    if (ms.OriginalValue is string mss) tmpValue = mss;
                    else if (ms.OriginalValue is Type mst) tmpValue = mst;
                    else if (ms.OriginalSymbol is TypeSymbol msts) tmpValue = msts;
                }
                if (tmpValue is string s) valueType = MetaType.FromName(s).AsType(tryResolveType: true);
                else if (tmpValue is Type t) valueType = t;
                else if (tmpValue is TypeSymbol ts)
                {
                    if (ts.IsError)
                    {
                        convertedValue = null;
                        return false;
                    }
                    valueType = MetaType.FromTypeSymbol(ts).AsType(tryResolveType: true);
                }
                else if (tmpValue is MetaType mt) valueType = mt.AsType(tryResolveType: true);
                else valueType = null;
                if (valueType is null)
                {
                    if (value is Symbol valueSymbol && valueSymbol.IsError)
                    {
                        convertedValue = null;
                        return false;
                    }
                    convertedValue = null;
                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, valueBinder.Location, $"Could not resolve Type for '{value}'."));
                    return false;
                }
                else
                {
                    convertedValue = valueType;
                    return true;
                }
            }
            else if (expectedType.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaSymbol || expectedType.IsAssignableTo(typeof(Symbol)))
            {
                var tmpValue = value;
                Symbol? valueSymbol;
                if (tmpValue is string s) tmpValue = MetaSymbol.FromValue(s).AsSymbol(this.Compilation);
                else if (tmpValue is MetaType mt) tmpValue = mt.Original;
                if (tmpValue is IModelObject mo) valueSymbol = MetaSymbol.FromModelObject(mo).AsSymbol(this.Compilation);
                else if (tmpValue is Symbol sym)
                {
                    if (sym.IsError)
                    {
                        convertedValue = null;
                        return false;
                    }
                    valueSymbol = MetaSymbol.FromSymbol(sym).AsSymbol(this.Compilation);
                }
                else if (tmpValue is MetaSymbol ms) valueSymbol = ms.AsSymbol(this.Compilation);
                else valueSymbol = null;
                if (valueSymbol is null)
                {
                    if (value is Symbol valueSymbol2 && valueSymbol2.IsError)
                    {
                        convertedValue = null;
                        return false;
                    }
                    if (expectedType.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaSymbol)
                    {
                        if (value is MetaSymbol ms2)
                        {
                            convertedValue = ms2;
                            return true;
                        }
                        else
                        {
                            convertedValue = MetaSymbol.FromValue(value);
                            return true;
                        }
                    }
                    else
                    {
                        convertedValue = null;
                        diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, valueBinder.Location, $"Could not resolve Symbol for '{value}'."));
                        return false;
                    }
                }
                else if (valueSymbol.IsError)
                {
                    convertedValue = null;
                    return false;
                }
                else
                {
                    if (expectedType.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaSymbol) convertedValue = MetaSymbol.FromSymbol(valueSymbol);
                    else convertedValue = valueSymbol;
                    return true;
                }
            }
            else if (expectedType.IsAssignableTo(typeof(IModelObject)))
            {
                var tmpValue = value;
                IModelObject? valueMObj;
                if (tmpValue is MetaType mt) tmpValue = mt.Original;
                if (tmpValue is string s) valueMObj = MetaSymbol.FromValue(s).AsModelObject(this.Compilation);
                else if (tmpValue is IModelObject mo) valueMObj = MetaSymbol.FromModelObject(mo).AsModelObject(this.Compilation);
                else if (tmpValue is Symbol sym)
                {
                    if (sym.IsError)
                    {
                        convertedValue = null;
                        return false;
                    }
                    valueMObj = MetaSymbol.FromSymbol(sym).AsModelObject(this.Compilation);
                }
                else if (tmpValue is MetaSymbol ms) valueMObj = ms.AsModelObject(this.Compilation);
                else valueMObj = null;
                if (valueMObj is null)
                {
                    if (value is Symbol valueSymbol && valueSymbol.IsError)
                    {
                        convertedValue = null;
                        return false;
                    }
                    convertedValue = null;
                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, valueBinder.Location, $"Could not resolve ModelObject for '{value}'."));
                    return false;
                }
                else
                {
                    convertedValue = valueMObj;
                    return true;
                }
            }
            if (value is not null && expectedType.IsAssignableFrom(value.GetType()))
            {
                convertedValue = value;
                return true;
            }
            else 
            {
                if (value is Symbol valueSymbol && valueSymbol.IsError)
                {
                    convertedValue = null;
                    return false;
                }
                if (value is string stringValue && TryConvertFromString(stringValue, expectedType, out convertedValue, valueBinder, diagnostics, cancellationToken))
                {
                    return true;
                }
                convertedValue = null;
                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, valueBinder.Location, $"Could not convert value '{value}' to {expectedType.FullName}."));
                return false;
            }
        }

        public virtual object? ConvertTo(object? value, MetaType expectedType, Binder valueBinder, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (TryConvertTo(value, expectedType, out var convertedValue, valueBinder, diagnostics, cancellationToken)) return convertedValue;
            else return null;
        }

        protected virtual bool TryConvertFromString(string rawValue, MetaType expectedType, out object? convertedValue, Binder valueBinder, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (rawValue == "null")
            {
                convertedValue = null;
                return true;
            }
            if (rawValue.Length >= 3 && rawValue.StartsWith("@\'") && rawValue.EndsWith("\'"))
            {
                convertedValue = rawValue.Substring(2, rawValue.Length - 3).Replace("\'\'", "\'");
                return true;
            }
            else if (rawValue.Length >= 2 && rawValue.StartsWith("\'") && rawValue.EndsWith("\'"))
            {
                convertedValue = StringUtilities.DecodeString(rawValue);
                return true;
            }
            else if (rawValue.Length >= 3 && rawValue.StartsWith("@\"") && rawValue.EndsWith("\""))
            {
                convertedValue = rawValue.Substring(2, rawValue.Length - 3).Replace("\"\"", "\"");
                return true;
            }
            else if (rawValue.Length >= 2 && rawValue.StartsWith("\"") && rawValue.EndsWith("\""))
            {
                convertedValue = StringUtilities.DecodeString(rawValue);
                return true;
            }
            bool boolValue;
            if (bool.TryParse(rawValue, out boolValue))
            {
                convertedValue = boolValue;
                return true;
            }
            int intValue;
            if (int.TryParse(rawValue, out intValue))
            {
                convertedValue = intValue;
                return true;
            }
            long longValue;
            if (long.TryParse(rawValue, out longValue))
            {
                convertedValue = longValue;
                return true;
            }
            float floatValue;
            if (float.TryParse(rawValue, out floatValue))
            {
                convertedValue = floatValue;
                return true;
            }
            double doubleValue;
            if (double.TryParse(rawValue, out doubleValue))
            {
                convertedValue = doubleValue;
                return true;
            }
            var type = expectedType.AsType(tryResolveType: true);
            if (type is not null)
            {
                try
                {
                    convertedValue = TypeDescriptor.GetConverter(expectedType).ConvertFromInvariantString(rawValue);
                    return true;
                }
                catch (NotSupportedException)
                {
                    convertedValue = null;
                    return false;
                }
            }
            convertedValue = null;
            return false;
        }
    }
}
