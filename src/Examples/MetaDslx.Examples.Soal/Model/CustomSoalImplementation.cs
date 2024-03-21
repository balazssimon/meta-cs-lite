using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;

namespace MetaDslx.Examples.Soal.Model
{
    internal class CustomSoalImplementation : CustomSoalImplementationBase
    {
        public override void Soal(ISoal _this)
        {
            _this.ErrorType.Kind = BuiltInTypeKind.Error;
            _this.AnyType.Kind = BuiltInTypeKind.Any;
            _this.VoidType.Kind = BuiltInTypeKind.Void;
            _this.ObjectType.Kind = BuiltInTypeKind.Object;
            _this.BinaryType.Kind = BuiltInTypeKind.Binary;
            _this.BoolType.Kind = BuiltInTypeKind.Bool;
            _this.StringType.Kind = BuiltInTypeKind.String;
            _this.IntType.Kind = BuiltInTypeKind.Int;
            _this.LongType.Kind = BuiltInTypeKind.Long;
            _this.FloatType.Kind = BuiltInTypeKind.Float;
            _this.DoubleType.Kind = BuiltInTypeKind.Double;
            _this.DateType.Kind = BuiltInTypeKind.Date;
            _this.TimeType.Kind = BuiltInTypeKind.Time;
            _this.DateTimeType.Kind = BuiltInTypeKind.DateTime;
            _this.DurationType.Kind = BuiltInTypeKind.Duration;
        }

        public override string BuiltInType_Name(BuiltInType _this)
        {
            switch (_this.Kind)
            {
                case BuiltInTypeKind.Error:
                    return "<<error>>";
                case BuiltInTypeKind.Any:
                    return "<<any>>";
                case BuiltInTypeKind.Void:
                case BuiltInTypeKind.Object:
                case BuiltInTypeKind.Binary:
                case BuiltInTypeKind.Bool:
                case BuiltInTypeKind.String:
                case BuiltInTypeKind.Int:
                case BuiltInTypeKind.Long:
                case BuiltInTypeKind.Float:
                case BuiltInTypeKind.Double:
                case BuiltInTypeKind.Date:
                case BuiltInTypeKind.Time:
                case BuiltInTypeKind.DateTime:
                case BuiltInTypeKind.Duration:
                    return _this.Kind.ToString().ToLower();
                default:
                    return null;
            }
        }

        public override string DocumentationTag_Html(DocumentationTag _this)
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            foreach (var line in _this.Lines)
            {
                sb.Append(line);
            }
            return CommonMark.CommonMarkConverter.Convert(builder.ToStringAndFree());
        }

        public override Documentation NamedElement_Documentation(NamedElement _this)
        {
            return DocumentationReader.GetDocumentation(_this);
        }

        public override string NamedElement_HoverDocumentation(NamedElement _this)
        {
            var doc = _this.Documentation;
            var summary = doc.Tags.Where(t => t.Kind == DocumentationTagKind.Summary).FirstOrDefault();
            return summary?.Html;
        }

        public override string NamedElement_UniqueName(NamedElement _this)
        {
            var prefix = "";
            if (_this is Service) prefix = "__service_";
            if (_this is Interface) prefix = "__interface_";
            if (_this is Operation) prefix = "__operation_";
            if (_this is Parameter) prefix = "__parameter_";
            if (_this is StructType) prefix = "__struct_";
            if (_this is Property) prefix = "__property_";
            if (_this is EnumType) prefix = "__enum_";
            if (_this is EnumLiteral) prefix = "__enumliteral_";
            return prefix + GetUniqueNamePart(_this);
        }

        private static string GetUniqueNamePart(NamedElement elem)
        {
            if (elem is null) return null;
            if (elem is Operation)
            {
                var intf = elem.GetInnermostContainingObject<Interface>();
                return GetUniqueNamePart(intf) + "_" + elem.Name;
            }
            if (elem is Parameter)
            {
                var op = elem.GetInnermostContainingObject<Operation>();
                return GetUniqueNamePart(op) + "_" + elem.Name;
            }
            if (elem is Property)
            {
                var type = elem.GetInnermostContainingObject<StructType>();
                return GetUniqueNamePart(type) + "_" + elem.Name;
            }
            if (elem is EnumLiteral)
            {
                var type = elem.GetInnermostContainingObject<EnumType>();
                return GetUniqueNamePart(type) + "_" + elem.Name;
            }
            return elem.Name;
        }

        public override bool Operation_HasManyRequestParameters(Operation _this)
        {
            return _this.RequestParameters.Parameters.Count > 1;
        }

        public override bool Operation_HasManyResponseParameters(Operation _this)
        {
            return _this.ResponseParameters.Parameters.Count > 1;
        }

        public override bool Operation_HasRequestParameters(Operation _this)
        {
            return _this.RequestParameters.Parameters.Count > 0;
        }

        public override bool Operation_HasResponseParameters(Operation _this)
        {
            return _this.ResponseParameters.Parameters.Count > 0;
        }

        public override bool Operation_HasSingleResponseParameter(Operation _this)
        {
            return _this.ResponseParameters.Parameters.Count == 1;
        }

        public override TypeReference Operation_SingleReturnType(Operation _this)
        {
            if (_this.ResponseParameters.Parameters.Count == 1) return _this.ResponseParameters.Parameters[0].Type;
            else return null;
        }

        public override string Resource_Name(Resource _this)
        {
            return _this.Entity.Name;
        }
    }
}
