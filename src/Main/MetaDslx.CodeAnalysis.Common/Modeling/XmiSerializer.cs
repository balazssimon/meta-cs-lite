using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Text;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace MetaDslx.Modeling
{
    public class XmiReadOptions
    {
        public XmiReadOptions()
        {
            this.ReferencedModels = new HashSet<Model>();
            this.RequireXmiRoot = true;
            this.IgnoreVersionInNamespaces = true;
            this.XmiNamespaces = new HashSet<string>();
            this.XmiNamespaces.Add("http://www.omg.org/spec/XMI");
            this.IgnoreEmptyNamespace = true;
            this.IgnoredNamespaces = new HashSet<string>();
            this.NamespaceToMetaModelMap = new Dictionary<string, MetaModel>();
            this.UriToFileMap = new Dictionary<string, string>();
            this.UriToModelMap = new Dictionary<string, Model>();
        }

        public XmiReadOptions(MetaModel metaModel)
            : this()
        {
            this.NamespaceToMetaModelMap.Add(metaModel.MUri, metaModel);
        }

        public HashSet<Model> ReferencedModels { get; }
        public bool RequireXmiRoot { get; set; }
        public bool IgnoreVersionInNamespaces { get; set; }
        public HashSet<string> XmiNamespaces { get; }
        public bool IgnoreEmptyNamespace { get; set; }
        public HashSet<string> IgnoredNamespaces { get; }
        public Dictionary<string, MetaModel> NamespaceToMetaModelMap { get; }
        public Dictionary<string, string> UriToFileMap { get; }
        public Dictionary<string, Model> UriToModelMap { get; }
    }

    public class XmiWriteOptions
    {
        public XmiWriteOptions()
        {
            this.RequireXmiRoot = true;
            this.XmiNamespace = "http://www.omg.org/spec/XMI";
            this.MetaModelToNamespaceMap = new Dictionary<MetaModel, string>();
            this.ModelToUriMap = new Dictionary<Model, string>();
            this.ModelToFileMap = new Dictionary<Model, string>();
        }

        public bool RequireXmiRoot { get; set; }
        public string XmiNamespace { get; set; }
        public bool PreferReferenceByName { get; set; }
        public Dictionary<MetaModel, string> MetaModelToNamespaceMap { get; }
        public Dictionary<Model, string> ModelToUriMap { get; }
        public Dictionary<Model, string> ModelToFileMap { get; }
    }

    public class XmiSerializer
    {
        public Model ReadModel(string xmiCode, MetaModel metaModel)
        {
            var result = this.ReadModel(xmiCode, metaModel, out var diagnostics);
            ThrowIfErrorExists(diagnostics);
            return result;
        }

        public Model ReadModel(string xmiCode, MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            if (xmiCode == null) throw new ArgumentNullException(nameof(xmiCode));
            if (metaModel == null) throw new ArgumentNullException(nameof(metaModel));
            var options = new XmiReadOptions(metaModel);
            options.NamespaceToMetaModelMap.Add(metaModel.MUri, metaModel);
            return this.ReadModel(xmiCode, options, out diagnostics);
        }

        public Model ReadModel(string xmiCode, XmiReadOptions options)
        {
            var result = this.ReadModel(xmiCode, options, out var diagnostics);
            ThrowIfErrorExists(diagnostics);
            return result;
        }

        public Model ReadModel(string xmiCode, XmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            if (xmiCode == null) throw new ArgumentNullException(nameof(xmiCode));
            if (options == null) throw new ArgumentNullException(nameof(options));
            XmiReader reader = new XmiReader(options);
            reader.LoadXmiCode(new Uri("http://metadslx/in-memory-code"), xmiCode);
            diagnostics = reader.Diagnostics.ToReadOnly();
            return reader.Model;
        }

        public Model ReadModelFromFile(string xmiFilePath, MetaModel metaModel)
        {
            var result = this.ReadModelFromFile(xmiFilePath, metaModel, out var diagnostics);
            ThrowIfErrorExists(diagnostics);
            return result;
        }

        public Model ReadModelFromFile(string xmiFilePath, MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            if (xmiFilePath == null) throw new ArgumentNullException(nameof(xmiFilePath));
            if (metaModel == null) throw new ArgumentNullException(nameof(metaModel));
            var options = new XmiReadOptions(metaModel);
            options.NamespaceToMetaModelMap.Add(metaModel.MUri, metaModel);
            return this.ReadModelFromFile(xmiFilePath, options, out diagnostics);
        }

        public Model ReadModelFromFile(string xmiFilePath, XmiReadOptions options)
        {
            var result = this.ReadModelFromFile(xmiFilePath, options, out var diagnostics);
            ThrowIfErrorExists(diagnostics);
            return result;
        }

        public Model ReadModelFromFile(string xmiFilePath, XmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            if (xmiFilePath == null) throw new ArgumentNullException(nameof(xmiFilePath));
            if (options == null) throw new ArgumentNullException(nameof(options));
            XmiReader reader = new XmiReader(options);
            reader.LoadXmiFile(new Uri(Path.GetFullPath(xmiFilePath)), null);
            diagnostics = reader.Diagnostics.ToReadOnly();
            return reader.Model;
        }

        public ModelGroup ReadModelGroup(string xmiCode, MetaModel metaModel)
        {
            return this.ReadModel(xmiCode, metaModel).ModelGroup;
        }

        public ModelGroup ReadModelGroup(string xmiCode, MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModel(xmiCode, metaModel, out diagnostics).ModelGroup;
        }

        public ModelGroup ReadModelGroup(string xmiCode, XmiReadOptions options)
        {
            return this.ReadModel(xmiCode, options).ModelGroup;
        }

        public ModelGroup ReadModelGroup(string xmiCode, XmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModel(xmiCode, options, out diagnostics).ModelGroup;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, MetaModel metaModel)
        {
            return this.ReadModelFromFile(xmiFilePath, metaModel).ModelGroup;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModelFromFile(xmiFilePath, metaModel, out diagnostics).ModelGroup;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, XmiReadOptions options)
        {
            return this.ReadModelFromFile(xmiFilePath, options).ModelGroup;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, XmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModelFromFile(xmiFilePath, options, out diagnostics).ModelGroup;
        }

        public string WriteModel(Model model, XmiWriteOptions options = null)
        {
            var result = WriteModel(model, options, out var diagnostics);
            ThrowIfErrorExists(diagnostics);
            return result;
        }

        public string WriteModel(Model model, XmiWriteOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            if (model.ModelGroup != null && model.ModelGroup.Models.Count() != 1) throw new ArgumentException("The number of models in the model group must be exactly one. Use the WriteModelGroup() method to serialize a model group of multiple models.", nameof(model));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = Encoding.UTF8;
            settings.OmitXmlDeclaration = false;
            using (MemoryStream stream = new MemoryStream())
            {
                using (XmlWriter writer = XmlWriter.Create(stream, settings))
                {
                    var writers = new Dictionary<Model, XmlWriter>();
                    writers.Add(model, writer);
                    Dictionary<Model, string> modelToUriMap;
                    if (options != null && options.ModelToUriMap.Count > 0)
                    {
                        modelToUriMap = options.ModelToUriMap.ToDictionary(e => e.Key, e => e.Value);
                    }
                    else
                    {
                        modelToUriMap = new Dictionary<Model, string>();
                        modelToUriMap.Add(model, "model0");
                    }
                    var xmiWriter = new XmiWriter(writers, new Dictionary<Model, string>(), modelToUriMap, options ?? new XmiWriteOptions(), model.ModelGroup);
                    xmiWriter.WriteModel(model);
                    diagnostics = xmiWriter.Diagnostics.ToReadOnly();
                }
                return Encoding.UTF8.GetString(stream.ToArray());
            }
        }

        public void WriteModelToFile(string xmiFilePath, Model model, XmiWriteOptions options = null)
        {
            WriteModelToFile(xmiFilePath, model, options, out var diagnostics);
            ThrowIfErrorExists(diagnostics);
        }

        public void WriteModelToFile(string xmiFilePath, Model model, XmiWriteOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            if (xmiFilePath == null) throw new ArgumentNullException(nameof(xmiFilePath));
            if (model == null) throw new ArgumentNullException(nameof(model));
            if (model.ModelGroup != null && model.ModelGroup.Models.Count() != 1) throw new ArgumentException("The number of models in the model group must be exactly one. Use the WriteModelGroupToFile() method to serialize a model group of multiple models.", nameof(model));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = Encoding.UTF8;
            settings.OmitXmlDeclaration = false;
            using (StreamWriter stream = new StreamWriter(xmiFilePath))
            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {
                var writers = new Dictionary<Model, XmlWriter>();
                writers.Add(model, writer);
                Dictionary<Model, string> modelToUriMap;
                if (options != null && options.ModelToUriMap.Count > 0)
                {
                    modelToUriMap = options.ModelToUriMap.ToDictionary(e => e.Key, e => e.Value);
                }
                else
                {
                    modelToUriMap = new Dictionary<Model, string>();
                }
                var modelToAbsoluteFileMap = new Dictionary<Model, string>();
                modelToAbsoluteFileMap.Add(model, Path.GetFullPath(xmiFilePath));
                var xmiWriter = new XmiWriter(writers, modelToAbsoluteFileMap, modelToUriMap, options ?? new XmiWriteOptions(), model.ModelGroup);
                xmiWriter.WriteModel(model);
                diagnostics = xmiWriter.Diagnostics.ToReadOnly();
            }
        }

        public IReadOnlyDictionary<string, string> WriteModelGroup(ModelGroup modelGroup, XmiWriteOptions options = null)
        {
            var result = WriteModelGroup(modelGroup, options, out var diagnostics);
            ThrowIfErrorExists(diagnostics);
            return result;
        }

        public IReadOnlyDictionary<string, string> WriteModelGroup(ModelGroup modelGroup, XmiWriteOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            if (modelGroup == null) throw new ArgumentNullException(nameof(modelGroup));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = Encoding.UTF8;
            settings.OmitXmlDeclaration = false;
            var streams = new Dictionary<Model, MemoryStream>();
            var writers = new Dictionary<Model, XmlWriter>();
            try
            {
                var result = new Dictionary<string, string>();
                var modelToUriMap = new Dictionary<Model, string>();
                if (options != null && options.ModelToUriMap.Count != 0)
                {
                    foreach (var entry in options.ModelToUriMap)
                    {
                        if (!result.ContainsKey(entry.Value))
                        {
                            result.Add(entry.Value, null);
                            modelToUriMap.Add(entry.Key, entry.Value);
                        }
                        else
                        {
                            throw new ArgumentException("Duplicate URI '{0}' in the ModelToUriMap dictionary.", nameof(options));
                        }
                    }
                }
                else
                {
                    int i = 0;
                    foreach (var modelRef in modelGroup.References)
                    {
                        modelToUriMap.Add(modelRef, "ref" + i);
                        ++i;
                    }
                    i = 0;
                    foreach (var model in modelGroup.Models)
                    {
                        modelToUriMap.Add(model, "model" + i);
                        ++i;
                    }
                }
                foreach (var entry in modelToUriMap)
                {
                    var stream = new MemoryStream();
                    streams.Add(entry.Key, stream);
                    var writer = XmlWriter.Create(stream, settings);
                    writers.Add(entry.Key, writer);
                }
                var xmiWriter = new XmiWriter(writers, new Dictionary<Model, string>(), modelToUriMap, options ?? new XmiWriteOptions(), modelGroup);
                xmiWriter.WriteModelGroup();
                diagnostics = xmiWriter.Diagnostics.ToReadOnly();
                foreach (var entry in writers)
                {
                    var writer = entry.Value;
                    writer.Flush();
                }
                foreach (var entry in streams)
                {
                    var key = modelToUriMap[entry.Key];
                    var stream = entry.Value;
                    var xmiCode = Encoding.UTF8.GetString(stream.ToArray());
                    result[key] = xmiCode;
                }
                return result;
            }
            finally
            {
                foreach (var entry in writers)
                {
                    var writer = entry.Value;
                    writer.Dispose();
                }
            }
        }

        public void WriteModelGroupToFile(ModelGroup modelGroup, XmiWriteOptions options)
        {
            WriteModelGroupToFile(modelGroup, options, out var diagnostics);
            ThrowIfErrorExists(diagnostics);
        }

        public void WriteModelGroupToFile(ModelGroup modelGroup, XmiWriteOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            if (modelGroup == null) throw new ArgumentNullException(nameof(modelGroup));
            if (options == null) throw new ArgumentNullException(nameof(options));
            var modelToAbsoluteFileMap = new Dictionary<Model, string>();
            foreach (var entry in options.ModelToFileMap)
            {
                var absoluteFilePath = Path.GetFullPath(entry.Value);
                if (!modelToAbsoluteFileMap.ContainsValue(absoluteFilePath))
                {
                    modelToAbsoluteFileMap.Add(entry.Key, absoluteFilePath);
                }
                else
                {
                    throw new ArgumentException("Duplicate file '{0}' in the ModelToFileMap dictionary.", nameof(options));
                }
            }
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = Encoding.UTF8;
            settings.OmitXmlDeclaration = false;
            var streams = new Dictionary<Model, StreamWriter>();
            var writers = new Dictionary<Model, XmlWriter>();
            try
            {
                var modelToUriMap = new Dictionary<Model, string>();
                foreach (var entry in options.ModelToUriMap)
                {
                    modelToUriMap.Add(entry.Key, entry.Value);
                }
                var result = new Dictionary<string, string>();
                foreach (var entry in modelToAbsoluteFileMap)
                {
                    if (!result.ContainsKey(entry.Value))
                    {
                        result.Add(entry.Value, null);
                    }
                    else
                    {
                        throw new ArgumentException("Duplicate file '{0}' in the ModelToFileMap dictionary.", nameof(options));
                    }
                }
                foreach (var entry in modelToAbsoluteFileMap)
                {
                    var stream = new StreamWriter(entry.Value);
                    streams.Add(entry.Key, stream);
                    var writer = XmlWriter.Create(stream, settings);
                    writers.Add(entry.Key, writer);
                }
                var xmiWriter = new XmiWriter(writers, modelToAbsoluteFileMap, modelToUriMap, options, modelGroup);
                xmiWriter.WriteModelGroup();
                diagnostics = xmiWriter.Diagnostics.ToReadOnly();
            }
            finally
            {
                foreach (var entry in writers)
                {
                    var writer = entry.Value;
                    writer.Dispose();
                }
            }
        }

        private void ThrowIfErrorExists(ImmutableArray<Diagnostic> diagnostics)
        {
            var errors = diagnostics.Where(diag => diag.Severity == DiagnosticSeverity.Error).ToArray();
            if (errors.Length > 0)
            {
                throw new ModelException(errors[0].ToString());
            }
        }
    }

    internal class XmiWriter
    {
        private const string Xmi = "xmi";
        private IReadOnlyDictionary<Model, XmlWriter> _xmlWriters;
        private Dictionary<Model, string> _modelToAbsoluteFileMap;
        private Dictionary<Model, string> _modelToRelativeFileMap;
        private Dictionary<Model, string> _modelToUriMap;
        private XmlWriter _currentXmlWriter;
        private string _currentFile;
        private Dictionary<MetaModel, (string, string)> _namespaces;
        private Dictionary<Model, Dictionary<string, IModelObject>> _nameMap;
        //private Dictionary<Model, List<MetaConstant>> _constantMap;
        private ModelGroup _modelGroup;
        private Model _currentModel;
        private XmiWriteOptions _options;
        private DiagnosticBag _diagnostics;
        private IEnumerable<IModelObject> _allObjects;

        public XmiWriter(IReadOnlyDictionary<Model, XmlWriter> xmlWriters, Dictionary<Model, string> modelToAbsoluteFileMap, Dictionary<Model, string> modelToUriMap, XmiWriteOptions options, ModelGroup modelGroup)
        {
            _xmlWriters = xmlWriters;
            _modelToAbsoluteFileMap = modelToAbsoluteFileMap;
            _modelToUriMap = modelToUriMap;
            _modelToRelativeFileMap = new Dictionary<Model, string>();
            _options = options;
            _namespaces = new Dictionary<MetaModel, (string, string)>();
            _nameMap = new Dictionary<Model, Dictionary<string, IModelObject>>();
            //_constantMap = new Dictionary<Model, List<MetaConstant>>();
            _diagnostics = new DiagnosticBag();
            _modelGroup = modelGroup;
        }

        internal XmiWriteOptions Options => _options;
        internal DiagnosticBag Diagnostics => _diagnostics;
        internal ModelGroup ModelGroup => _modelGroup;

        private (string, string) RegisterNamespace(MetaModel metaModel)
        {
            if (_namespaces.TryGetValue(metaModel, out var ns)) return ns;
            string prefix = string.IsNullOrWhiteSpace(metaModel.MPrefix) ? metaModel.MName.ToCamelCase() : metaModel.MPrefix;
            int index = 1;
            string currentPrefix = prefix;
            while (_namespaces.Values.Any(v => v.Item1 == currentPrefix) || currentPrefix == Xmi)
            {
                ++index;
                currentPrefix = prefix + index;
            }
            var result = (currentPrefix, metaModel.MUri ?? metaModel.MFullName);
            _namespaces.Add(metaModel, result);
            return result;
        }

        public void WriteModelGroup()
        {
            if (_modelGroup != null)
            {
                foreach (var model in _modelGroup.Models)
                {
                    this.WriteModel(model);
                }
            }
        }

        public void WriteModel(Model model)
        {
            _currentModel = model;
            if (_xmlWriters.TryGetValue(model, out _currentXmlWriter))
            {
                _modelToAbsoluteFileMap.TryGetValue(model, out _currentFile);
                _modelToRelativeFileMap.Clear();
                _allObjects = _currentModel.Objects;
                List<IModelObject> rootObjects = _currentModel.RootObjects.ToList();
                IModelObject xmiRoot = null;
                if (_options.RequireXmiRoot)
                {
                    _currentXmlWriter.WriteStartElement(Xmi, "XMI", _options.XmiNamespace);
                    this.WriteXmlNamespaces();
                    foreach (var obj in rootObjects)
                    {
                        this.WriteObject(obj, null);
                    }
                    _currentXmlWriter.WriteEndElement();
                }
                else
                {
                    if (rootObjects.Count > 1)
                    {
                        this.Diagnostics.Add(Diagnostic.Create(ModelErrorCode.ERR_XmiError, Location.None, "Multiple root model objects found. If the XMI root is not used the number model objects with no parent must be exactly one."));
                    }
                    xmiRoot = rootObjects.FirstOrDefault();
                    this.WriteObject(xmiRoot, null);
                }
                _currentXmlWriter.Flush();
            }
        }

        private void WriteXmlNamespaces()
        {
            IEnumerable<MetaModel> metadatas = _allObjects.Select(obj => obj.MInfo.MetaModel).Distinct();
            foreach (var metaModel in metadatas)
            {
                var ns = this.RegisterNamespace(metaModel);
                _currentXmlWriter.WriteAttributeString("xmlns", ns.Item1, null, ns.Item2);
            }
        }

        private void WriteObject(IModelObject obj, string parentProperty)
        {
            var metaModel = obj.MInfo.MetaModel;
            var ns = this.RegisterNamespace(metaModel);
            if (parentProperty != null)
            {
                _currentXmlWriter.WriteStartElement(parentProperty.ToCamelCase());
            }
            else
            {
                _currentXmlWriter.WriteStartElement(ns.Item1, obj.MInfo.MetaType.Name, ns.Item2);
            }
            if (!_options.RequireXmiRoot && obj.MParent == null)
            {
                this.WriteXmlNamespaces();
            }
            _currentXmlWriter.WriteAttributeString(Xmi, "type", _options.XmiNamespace, ns.Item1 + ":" + obj.MInfo.MetaType.Name);
            _currentXmlWriter.WriteAttributeString(Xmi, "id", _options.XmiNamespace, obj.MId);
            HashSet<IModelObject> written = new HashSet<IModelObject>();
            foreach (var prop in obj.MProperties)
            {
                if (prop.IsDerived || prop.IsDerivedUnion) continue;
                bool oppositeIsContainment = obj.MInfo.GetOppositeProperties(prop).Any(p => p.IsContainment);
                if (oppositeIsContainment) continue;
                var slot = obj.MGetSlot(prop);
                bool singleValue = prop.IsCollection && slot.Values.Take(2).Count() == 1;
                if ((prop.IsSingle || singleValue) && (!prop.IsContainment || !prop.IsModelObject))
                {
                    if (prop.IsModelObject)
                    {
                        var value = (singleValue ? slot.AsCollection()[0] : slot.AsSingle()?.Value) as IModelObject;
                        if (value != null)
                        {
                            if (value.MModel == _currentModel)
                            {
                                _currentXmlWriter.WriteAttributeString(prop.Name.ToCamelCase(), value.MId);
                            }
                            else if (value.MModel is not null)
                            {
                                _currentXmlWriter.WriteAttributeString(prop.Name.ToCamelCase(), ExternalIdRef(value));
                            }
                        }
                    }
                    else
                    {
                        if (!slot.IsDefault)
                        {
                            var value = singleValue ? slot.AsCollection()[0] : slot.AsSingle()?.Value;
                            if (value != null)
                            {
                                var valueStr = value.ToString();
                                if (value.GetType() == typeof(bool)) valueStr = valueStr.ToLower();
                                else if (value.GetType().IsEnum) valueStr = valueStr.ToCamelCase();
                                _currentXmlWriter.WriteAttributeString(prop.Name.ToCamelCase(), valueStr);
                            }
                        }
                    }
                }
            }
            foreach (var prop in obj.MProperties)
            {
                if (prop.IsDerived || prop.IsDerivedUnion) continue;
                bool oppositeIsContainment = obj.MInfo.GetOppositeProperties(prop).Any(p => p.IsContainment);
                if (oppositeIsContainment) continue;
                var slot = obj.MGetSlot(prop);
                bool singleValue = prop.IsCollection && slot.Values.Take(2).Count() == 1;
                if ((prop.IsCollection && !singleValue) && (!prop.IsContainment || !prop.IsModelObject))
                {
                    if (prop.IsModelObject)
                    {
                        var values = slot.AsCollection();
                        if (values != null)
                        {
                            foreach (IModelObject value in values)
                            {
                                if (value != null)
                                {
                                    _currentXmlWriter.WriteStartElement(prop.Name.ToCamelCase());
                                    if (value.MModel == _currentModel)
                                    {
                                        _currentXmlWriter.WriteAttributeString(Xmi, "idref", _options.XmiNamespace, value.MId);
                                    }
                                    else
                                    {
                                        _currentXmlWriter.WriteAttributeString(Xmi, "idref", _options.XmiNamespace, ExternalIdRef(value));
                                    }
                                    _currentXmlWriter.WriteEndElement();
                                }
                            }
                        }
                    }
                    else
                    {
                        var values = slot.AsCollection();
                        if (values != null)
                        {
                            foreach (var value in values)
                            {
                                _currentXmlWriter.WriteElementString(prop.Name.ToCamelCase(), value?.ToString());
                            }
                        }
                    }
                }
            }
            foreach (var prop in obj.MProperties)
            {
                if (prop.IsDerived || prop.IsDerivedUnion) continue;
                if (prop.IsContainment && prop.IsModelObject)
                {
                    var slot = obj.MGetSlot(prop);
                    foreach (IModelObject child in slot.Values)
                    {
                        if (child == null) continue;
                        if (written.Add(child))
                        {
                            this.WriteObject(child, prop.Name);
                        }
                        else
                        {
                            _currentXmlWriter.WriteStartElement(prop.Name.ToCamelCase());
                            if (child.MModel == _currentModel)
                            {
                                _currentXmlWriter.WriteAttributeString(Xmi, "idref", _options.XmiNamespace, child.MId);
                            }
                            else
                            {
                                _currentXmlWriter.WriteAttributeString(Xmi, "idref", _options.XmiNamespace, ExternalIdRef(child));
                            }
                            _currentXmlWriter.WriteEndElement();
                        }
                    }
                }
            }
            _currentXmlWriter.WriteEndElement();
        }

        private string ExternalIdRef(IModelObject obj)
        {
            obj = ModelObjectToConstant(obj);
            var id = obj.MId;
            if (this.Options.PreferReferenceByName)
            {
                var name = GetName(obj);
                if (name != null) id = "//" + name;
            }
            if (_modelToAbsoluteFileMap.TryGetValue(obj.MModel, out var _))
            {
                var relativeFilePath = GetRelativePath(obj.MModel);
                return string.Format("{0}#{1}", relativeFilePath, id);
            }
            else if (_modelToUriMap.TryGetValue(obj.MModel, out var uri))
            {
                if (obj.MModel == _currentModel) uri = string.Empty;
                return string.Format("{0}#{1}", uri, id);
            }
            else
            {
                this.Diagnostics.Add(Diagnostic.Create(ModelErrorCode.ERR_XmiError, Location.None, string.Format("There is no external file or URI defined for model '{0}'. Use the XmiWriteOptions.ModelToFileMap or XmiWriteOptions.ModelToUriMap property to specify the external file or URI, respectively.", obj.MModel.ToString())));
                return "***ERROR***";
            }
        }

        private IModelObject ModelObjectToConstant(IModelObject obj)
        {
            /*if (!_constantMap.TryGetValue(obj.Model, out var constants))
            {
                constants = obj.Model.Objects.OfType<MetaConstant>().ToList();
                _constantMap.Add(obj.Model, constants);
            }
            var cst = constants.Where(c => c.Value == obj).FirstOrDefault();
            return cst ?? obj;*/
            return obj;
        }

        private string GetRelativePath(Model model)
        {
            if (model == _currentModel) return string.Empty;
            if (!_modelToRelativeFileMap.TryGetValue(model, out var result))
            {
                if (_modelToAbsoluteFileMap.TryGetValue(model, out var filePath))
                {
                    result = GetRelativePath(_currentFile, filePath);
                    _modelToRelativeFileMap.Add(model, result);
                }
            }
            return result;
        }

        private static string GetRelativePath(string currentFilePath, string referencedFilePath)
        {
            Uri currentUri = new Uri(currentFilePath);
            Uri referencedUri = new Uri(referencedFilePath);
            return Uri.UnescapeDataString(currentUri.MakeRelativeUri(referencedUri).ToString());
        }

        private string GetName(IModelObject obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MName)) return null;
            var model = obj.MModel;
            if (!_nameMap.TryGetValue(model, out var nameToObject))
            {
                nameToObject = new Dictionary<string, IModelObject>();
                _nameMap.Add(model, nameToObject);
            }
            if (nameToObject.TryGetValue(obj.MName, out var existingObj))
            {
                if (existingObj != null)
                {
                    Debug.Assert(existingObj == obj);
                    return obj.MName;
                }
                else
                {
                    return null;
                }
            }
            else
            { 
                if (!string.IsNullOrWhiteSpace(obj.MName))
                {
                    var nameList = obj.MModel.Objects.Where(o => o.MName == obj.MName).ToList();
                    if (nameList.Count == 1)
                    {
                        nameToObject.Add(obj.MName, obj);
                        return obj.MName;
                    }
                    else
                    {
                        nameToObject.Add(obj.MName, null);
                    }
                }
            }
            return null;
        }
    }

    internal class XmiReader
    {
        private XmiReadOptions _options;
        private ModelGroup _modelGroup;
        private Model _mainModel;
        private DiagnosticBag _diagnostics;
        private Dictionary<string, XmiFileReader> _readers;

        public XmiReader(XmiReadOptions options)
        {
            _options = options;
            _modelGroup = new ModelGroup();
            _modelGroup.AddReference(options.ReferencedModels);
            _diagnostics = new DiagnosticBag();
            _readers = new Dictionary<string, XmiFileReader>();
        }

        internal XmiReadOptions Options => _options;
        internal DiagnosticBag Diagnostics => _diagnostics;

        internal ModelGroup ModelGroup => _modelGroup;

        public Model Model => _mainModel;

        public XmiFileReader LoadXmiCode(Uri fileUri, string xmiCode)
        {
            string absoluteUri = fileUri != null ? fileUri.AbsoluteUri : string.Empty;
            if (!_readers.TryGetValue(absoluteUri, out var reader))
            {
                reader = new XmiFileReader(_readers.Count == 0, fileUri, xmiCode, this);
                _readers.Add(absoluteUri, reader);
                reader.CreateObjects();
                if (reader.IsMainReader) _mainModel = reader.Model;
            }
            bool finished = !reader.IsMainReader;
            while (!finished)
            {
                finished = true;
                var unfinishedReaders = _readers.Values.Where(r => !r.IsFinished).ToList();
                foreach (var rdr in unfinishedReaders)
                {
                    if (!rdr.IsFinished)
                    {
                        rdr.ReadObjects();
                        finished = false;
                    }
                }
            }
            return reader;
        }

        public XmiFileReader LoadXmiFile(Uri currentUri, string relativeUri)
        {
            Uri fileUri;
            if (relativeUri != null)
            {
                if (!_options.UriToFileMap.TryGetValue(relativeUri, out var mappedUri))
                {
                    mappedUri = relativeUri;
                }
                fileUri = new Uri(currentUri, mappedUri);
            }
            else
            {
                fileUri = currentUri;
            }
            // TODO: download HTTP file
            if (fileUri.IsFile)
            {
                var filePath = fileUri.AbsolutePath;
                string xmiCode = File.ReadAllText(filePath);
                return this.LoadXmiCode(fileUri, xmiCode);
            }
            else
            {
                return null;
            }
        }

        private XmiFileReader LoadXmiModel(Uri fileUri, Model model)
        {
            string absoluteUri = fileUri != null ? fileUri.AbsoluteUri : string.Empty;
            if (!_readers.TryGetValue(absoluteUri, out var reader))
            {
                reader = new XmiFileReader(fileUri, model, this);
                _readers.Add(absoluteUri, reader);
                _modelGroup.AddReference(model);
            }
            return reader;
        }

        public List<IModelObject> ResolveObjects(Uri currentUri, string relativeUri, string id, XObject location)
        {
            XmiFileReader reader;
            if (!_options.UriToFileMap.TryGetValue(relativeUri, out var mappedUri))
            {
                mappedUri = relativeUri;
            }
            var fileUri = new Uri(currentUri, mappedUri);
            var absoluteUri = fileUri.AbsoluteUri;
            if (_options.UriToModelMap.TryGetValue(relativeUri, out var mappedModel))
            {
                reader = this.LoadXmiModel(fileUri, mappedModel);
                if (reader == null) return new List<IModelObject>();
            }
            else
            {
                if (!_readers.TryGetValue(absoluteUri, out reader))
                {
                    reader = this.LoadXmiFile(currentUri, relativeUri);
                    if (reader == null)
                    {
                        return new List<IModelObject>();
                    }
                }
            }
            return reader.ResolveObjectsByReference(location, id, null);
        }
    }

    internal class XmiFileReader
    {
        private static readonly XNamespace _xsiNamespace = "http://www.w3.org/2001/XMLSchema-instance";
        private static readonly string ByteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
        private bool _isMainReader;
        private bool _isFinished;
        private Uri _fileUri;
        private string _xmiCode;
        private XmiReader _xmiReader;
        private Model _model;
        private XElement _root;
        private Dictionary<string, ModelFactory> _namespaceToFactoryMap;
        private Dictionary<string, IModelObject> _objectsById;
        private Dictionary<(int, int), IModelObject> _objectsByPosition;
        private Dictionary<IModelObject, XElement> _elementsByObject;

        public XmiFileReader(bool isMainReader, Uri fileUri, string xmiCode, XmiReader xmiReader)
        {
            _isMainReader = isMainReader;
            _fileUri = fileUri;
           xmiCode = xmiCode.Trim(new char[] { '\uFEFF', '\u200B' });
            _xmiCode = xmiCode;
            _xmiReader = xmiReader;
            _model = _xmiReader.ModelGroup.CreateModel();
            _model.Name = _fileUri.AbsoluteUri;
            _namespaceToFactoryMap = new Dictionary<string, ModelFactory>();
            _objectsById = new Dictionary<string, IModelObject>();
            _objectsByPosition = new Dictionary<(int, int), IModelObject>();
            _elementsByObject = new Dictionary<IModelObject, XElement>();
        }

        public XmiFileReader(Uri fileUri, Model model, XmiReader xmiReader)
        {
            _fileUri = fileUri;
            _model = model;
            _xmiReader = xmiReader;
            _isFinished = true;
        }

        internal XmiReadOptions Options => _xmiReader.Options;
        public bool IsMainReader => _isMainReader;
        public bool IsFinished => _isFinished;
        public Model Model => _model;

        internal Location GetLocation(XObject xobj)
        {
            if (xobj == null) return Location.None;
            IXmlLineInfo info = xobj;
            var lineSpan = new LinePositionSpan(new LinePosition(info.LineNumber - 1, info.LinePosition - 1), new LinePosition(info.LineNumber - 1, info.LinePosition - 1));
            return new ExternalFileLocation(_fileUri?.AbsolutePath ?? string.Empty, new TextSpan(), lineSpan);
        }

        internal void AddWarning(XObject location, string message)
        {
            _xmiReader.Diagnostics.Add(Diagnostic.Create(ModelErrorCode.WRN_XmiWarning, GetLocation(location), message));
        }

        internal void AddError(XObject location, string message)
        {
            _xmiReader.Diagnostics.Add(Diagnostic.Create(ModelErrorCode.ERR_XmiError, GetLocation(location), message));
        }

        internal void AddError(XObject location, ModelException mex)
        {
            _xmiReader.Diagnostics.Add(Diagnostic.Create(ModelErrorCode.ERR_XmiError, GetLocation(location), mex.Message));
        }

        private ModelFactory GetFactory(XObject location, string nsName, bool reportError = true)
        {
            if (IgnoreMetaModelNamespace(nsName)) return null;
            if (_namespaceToFactoryMap.TryGetValue(nsName, out var factory) && factory != null) return factory;
            var metaModel = ResolveMetadataByNamespace(nsName);
            if (metaModel != null)
            {
                factory = metaModel.CreateFactory(_model);
                _namespaceToFactoryMap.Add(nsName, factory);
                return factory;
            }
            else
            {
                if (reportError) this.AddError(location, string.Format("No metamodel is specified for the namespace '{0}'. Use the XmiReadOptions.NamespaceToMetamodelMap property to register the metamodel for the given namespace.", nsName));
                return null;
            }
        }

        private bool IgnoreMetaModelNamespace(string nsName)
        {
            if (this.Options.IgnoreEmptyNamespace && string.IsNullOrWhiteSpace(nsName)) return true;
            if (this.Options.IgnoreVersionInNamespaces)
            {
                return this.Options.XmiNamespaces.Any(xns => nsName.StartsWith(xns)) || this.Options.IgnoredNamespaces.Contains(nsName);
            }
            else
            {
                return this.Options.XmiNamespaces.Contains(nsName) || this.Options.IgnoredNamespaces.Contains(nsName);
            }
        }

        private MetaModel ResolveMetadataByNamespace(string nsName)
        {
            if (this.Options.IgnoreVersionInNamespaces)
            {
                foreach (var entry in this.Options.NamespaceToMetaModelMap)
                {
                    if (nsName.StartsWith(entry.Key)) return entry.Value;
                }
                return default;
            }
            else
            {
                this.Options.NamespaceToMetaModelMap.TryGetValue(nsName, out var metaModel);
                return metaModel;
            }
        }

        private bool IsXmiNamespace(string nsName)
        {
            if (this.Options.IgnoreVersionInNamespaces)
            {
                return this.Options.XmiNamespaces.Any(xns => nsName.StartsWith(xns));
            }
            else
            {
                return this.Options.XmiNamespaces.Contains(nsName);
            }
        }

        public void CreateObjects()
        {
            var document = XDocument.Parse(_xmiCode, LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
            _root = document.Root;
            if (this.Options.RequireXmiRoot)
            {
                if (_root.Name.LocalName != "XMI" && !IsXmiNamespace(_root.Name.NamespaceName))
                {
                    this.AddError(_root, "The root must be an xmi:XMI tag.");
                }
            }
            this.CreateObject(_root, null, null);
        }

        public void ReadObjects()
        {
            this.ReadObject(_root, null);
            _isFinished = true;
        }

        private void CreateObject(XElement element, IModelObject parent, ModelFactory currentFactory)
        {
            XAttribute xmiTypeAttribute = GetXmiTypeAttribute(element);
            XAttribute xsiTypeAttribute = GetXsiTypeAttribute(element);
            XAttribute idAttribute = GetXmiIdAttribute(element);
            string typePrefix = null;
            string typeName = null;
            ModelFactory factory = null;
            if (xmiTypeAttribute != null || xsiTypeAttribute != null)
            {
                var typeAttribute = xmiTypeAttribute ?? xsiTypeAttribute;
                string[] typeValue = typeAttribute.Value.Split(':');
                typePrefix = typeValue.Length >= 2 ? typeValue[0] : null;
                typeName = typeValue.Length >= 2 ? typeValue[1] : typeValue[0];
                var typeNs = typePrefix != null ? element.GetNamespaceOfPrefix(typePrefix) : element.GetDefaultNamespace();
                factory = GetFactory(typeAttribute, typeNs.NamespaceName);
            }
            if (typeName == null)
            {
                XAttribute idrefAttribute = GetXmiIdrefAttribute(element);
                XAttribute hrefAttribute = GetHrefAttribute(element);
                if (idrefAttribute == null && hrefAttribute == null)
                {
                    if (parent == null)
                    {
                        typeName = element.Name.LocalName.ToPascalCase();
                        factory = GetFactory(element, element.Name.Namespace.NamespaceName);
                    }
                    else
                    {
                        string parentProperty = element.Name.LocalName.ToPascalCase();
                        ModelProperty property = parent.MInfo.GetProperty(parentProperty);
                        if (property != null)
                        {
                            if (property.IsModelObject)
                            {
                                typeName = property.Type.Name;
                                var typeNs = element.Parent != null ? element.Parent.Name.Namespace : element.Name.Namespace;
                                factory = GetFactory(element, typeNs.NamespaceName) ?? currentFactory;
                                if (factory == null)
                                {
                                    this.AddError(element, "Unable to find a model factory for this element.");
                                }
                            }
                        }
                    }
                }
            }
            IModelObject obj = null;
            if (factory != null && typeName != null)
            {
                try
                {
                    obj = factory.Create(typeName);
                }
                catch (ModelException mex)
                {
                    this.AddError(element, mex);
                }
                if (obj != null)
                {
                    string parentPropertyName = element.Name.LocalName.ToPascalCase();
                    var parentSlot = parent?.MGetSlot(parentPropertyName);
                    if (parentSlot != null)
                    {
                        if (parentSlot.IsReadOnly)
                        {
                            this.AddWarning(element, $"Property '{parentPropertyName}' of model object '{obj}' is read only.");
                        }
                        else
                        {
                            try
                            {
                                parentSlot.Add(obj);
                            }
                            catch (ModelException mex)
                            {
                                this.AddError(element, mex);
                            }
                        }
                    }
                    this.RegisterObjectByPosition(element, obj);
                    foreach (var nameProp in obj.MInfo.AllDeclaredProperties.Where(p => p.IsName))
                    {
                        var nameSlot = obj.MGetSlot(nameProp);
                        if (nameSlot is null || nameSlot.IsReadOnly) continue;
                        var nameAttr = element.Attribute(nameProp.Name.ToCamelCase());
                        if (nameAttr != null)
                        {
                            string name = nameAttr.Value;
                            try
                            {
                                nameSlot.Add(name);
                            }
                            catch (ModelException mex)
                            {
                                this.AddError(element, mex);
                            }
                        }
                    }
                    if (idAttribute != null)
                    {
                        string id = idAttribute.Value;
                        this.RegisterObjectById(idAttribute, id, obj);
                    }
                }
            }
            foreach (var child in element.Elements())
            {
                this.CreateObject(child, obj, factory ?? currentFactory);
            }
        }

        private XAttribute GetXmiAttribute(XElement element, string attributeName)
        {
            foreach (var attr in element.Attributes())
            {
                if (attr.Name.LocalName == attributeName && this.IsXmiNamespace(attr.Name.NamespaceName)) return attr;
            }
            return null;
        }

        private XAttribute GetXmiTypeAttribute(XElement element)
        {
            return GetXmiAttribute(element, "type");
        }

        private XAttribute GetXsiTypeAttribute(XElement element)
        {
            return element.Attribute(_xsiNamespace + "type");
        }

        private XAttribute GetXmiIdAttribute(XElement element)
        {
            return GetXmiAttribute(element, "id");
        }

        private XAttribute GetXmiIdrefAttribute(XElement element)
        {
            return GetXmiAttribute(element, "idref");
        }

        private XAttribute GetHrefAttribute(XElement element)
        {
            return element.Attribute("href");
        }

        private bool RegisterObjectByPosition(XElement location, IModelObject mobj)
        {
            IXmlLineInfo info = location;
            var pos = (info.LineNumber, info.LinePosition);
            if (_objectsByPosition.TryGetValue(pos, out var existing))
            {
                this.AddError(location, string.Format("A model object is already registered for position {0}.", pos));
                return false;
            }
            else
            {
                _objectsByPosition.Add(pos, mobj);
            }
            if (_elementsByObject.TryGetValue(mobj, out var existingElem) && existingElem != location)
            {
                this.AddError(location, string.Format("The element is already registered for another model object.", pos));
                return false;
            }
            else
            {
                _elementsByObject.Add(mobj, location);
                return true;
            }
        }

        private bool RegisterObjectById(XObject location, string id, IModelObject mobj)
        {
            if (_objectsById.TryGetValue(id, out var existing))
            {
                this.AddError(location, string.Format("Model object with identifier '{0}' already exists.", id));
                return false;
            }
            else
            {
                _objectsById.Add(id, mobj);
                mobj.MId = id;
                return true;
            }
        }

        private void ReadObject(XElement element, IModelObject parent)
        {
            IModelObject currentObj = ResolveObjectByPosition(element, false);
            string parentPropertyName = element.Name.LocalName.ToPascalCase();
            ModelProperty parentProperty = parent?.MInfo.GetProperty(parentPropertyName);
            var parentSlot = parent?.MGetSlot(parentProperty);
            if (parentProperty != null)
            {
                if (currentObj == null)
                {
                    XAttribute idrefAttribute = GetXmiIdrefAttribute(element);
                    XAttribute hrefAttribute = GetHrefAttribute(element);
                    if (idrefAttribute != null || hrefAttribute != null)
                    {
                        var refAttribute = idrefAttribute ?? hrefAttribute;
                        var reference = refAttribute.Value;
                        foreach (var resolvedObj in ResolveObjectsByReference(refAttribute, reference, element))
                        {
                            try
                            {
                                parentSlot.Add(ResolveMetaConstantValue(parentProperty, resolvedObj));
                            }
                            catch (ModelException mex)
                            {
                                this.AddError(element, mex);
                            }
                        }
                        return;
                    }
                    else
                    {
                        this.AssignProperty(parent, element);
                        return;
                    }
                }
            }
            if (currentObj != null)
            {
                foreach (var attr in element.Attributes())
                {
                    this.AssignProperty(currentObj, element, attr);
                }
            }
            foreach (var child in element.Elements())
            {
                this.ReadObject(child, currentObj);
            }
        }

        private void AssignProperty(IModelObject obj, XElement element)
        {
            if (element.Name.NamespaceName == string.Empty)
            {
                string propertyName = element.Name.LocalName.ToPascalCase();
                string propertyValue = element.Value;
                this.AssignProperty(obj, element, element, propertyName, propertyValue);
            }
        }

        private void AssignProperty(IModelObject obj, XElement element, XAttribute attribute)
        {
            if (attribute.Name.NamespaceName == string.Empty)
            {
                string propertyName = attribute.Name.LocalName.ToPascalCase();
                string propertyValue = attribute.Value;
                this.AssignProperty(obj, attribute, element, propertyName, propertyValue);
            }
        }

        private void AssignProperty(IModelObject obj, XObject location, XElement context, string propertyName, string propertyValue)
        {
            if (propertyName == "Href") return;
            ModelProperty property = obj.MInfo.GetProperty(propertyName);
            var slot = obj.MGetSlot(property);
            if (slot == null)
            {
                this.AddError(location, $"Model object '{obj}' has no '{propertyName}' property.");
            }
            else if (slot.IsReadOnly)
            {
                this.AddWarning(location, $"Property '{propertyName}' of model object '{obj}' is read only.");
            }
            else
            {
                if (property.IsName) return;
                try
                {
                    IEnumerable<object> values = null;
                    object value = null;
                    if (property.IsModelObject)
                    {
                        values = this.ResolveObjectsByReference(location, propertyValue, context);
                    }
                    else if (property.Type.AsType().IsEnum)
                    {
                        try
                        {
                            value = Enum.Parse(property.Type.AsType(), propertyValue, true);
                        }
                        catch (Exception)
                        {
                            this.AddError(location, $"Value '{propertyValue}' is invalid for the enum type '{property.Type.FullName}'.");
                            return;
                        }
                    }
                    else if (property.Type == typeof(string))
                    {
                        value = propertyValue;
                    }
                    else if (property.Type == typeof(bool))
                    {
                        value = propertyValue.ToLower() == "true" || propertyValue == "1";
                    }
                    else if (property.Type == typeof(int))
                    {
                        int.TryParse(propertyValue, out int intValue);
                        if (propertyValue == "*") intValue = -1;
                        value = intValue;
                    }
                    else if (property.Type == typeof(long))
                    {
                        long.TryParse(propertyValue, out long longValue);
                        if (propertyValue == "*") longValue = -1;
                        value = longValue;
                    }
                    else if (property.Type == typeof(float))
                    {
                        float.TryParse(propertyValue, out float floatValue);
                        value = floatValue;
                    }
                    else if (property.Type == typeof(double))
                    {
                        double.TryParse(propertyValue, out double doubleValue);
                        value = doubleValue;
                    }
                    else
                    {
                        this.AddError(location, $"Unhandled value type: {property.Type.FullName}.");
                        return;
                    }
                    if (values != null)
                    {
                        foreach (var v in values)
                        {
                            slot.Add(ResolveMetaConstantValue(property, v));
                        }
                    }
                    else
                    {
                        slot.Add(ResolveMetaConstantValue(property, value));
                    }
                }
                catch (ModelException mex)
                {
                    this.AddError(location, mex);
                }
            }
        }

        private object ResolveMetaConstantValue(ModelProperty property, object value)
        {
            /*if (property.Type != typeof(MetaConstant))
            {
                if (value is MetaConstant metaConstant) return metaConstant.Value;
                else if (value is MetaConstantBuilder metaConstantBuilder) return metaConstantBuilder.Value;
            }*/
            return value;
        }

        public IModelObject ResolveObjectById(XObject location, string id, bool reportError = true)
        {
            if (_objectsById.TryGetValue(id, out var result))
            {
                return result;
            }
            if (reportError) this.AddError(location, $"Model object referenced by identifier '{id}' cannot be resolved.");
            return null;
        }

        public IModelObject ResolveObjectByPosition(XObject location, bool reportError = true)
        {
            IXmlLineInfo info = location;
            var pos = (info.LineNumber, info.LinePosition);
            if (_objectsByPosition.TryGetValue(pos, out var result))
            {
                return result;
            }
            if (reportError) this.AddError(location, $"Model object referenced by position '{pos}' cannot be resolved.");
            return null;
        }

        public XElement ResolveElementByObject(IModelObject mobj, XObject location, bool reportError = true)
        {
            if (_elementsByObject.TryGetValue(mobj, out var result))
            {
                return result;
            }
            if (reportError) this.AddError(location, $"Element cannot be resolved based on the model object.");
            return null;
        }

        public List<IModelObject> ResolveObjectsByReference(XObject location, string reference, XElement context)
        {
            if (context == null) context = _root;
            string[] idArray = reference.Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            List<IModelObject> result = new List<IModelObject>();
            if (idArray.Length == 0) return result;
            foreach (var id in idArray)
            {
                this.ResolveObjectsByXPointer(location, id, context, result);
            }
            if (result.Count == 0)
            {
                this.AddError(location, $"Unable to resolve reference '{reference}'.");
            }
            return result;
        }

        private bool ResolveObjectsByXPointer(XObject location, string reference, XElement context, List<IModelObject> result)
        {
            string localReference = reference;
            string[] hrefValue = reference.Split('#');
            if (hrefValue.Length >= 2)
            {
                string hrefFilePath = hrefValue[0];
                string objId = hrefValue[1];
                if (string.IsNullOrWhiteSpace(hrefFilePath))
                {
                    localReference = objId;
                }
                else
                {
                    var externalObjects = _xmiReader.ResolveObjects(_fileUri, hrefFilePath, objId, location);
                    result.AddRange(externalObjects);
                    return externalObjects.Count > 0;
                }
            }
            return this.ResolveObjectsByLocalXPointer(location, localReference, context, result);
        }

        private bool ResolveObjectsByLocalXPointer(XObject location, string reference, XElement context, List<IModelObject> result)
        {
            if (!reference.Contains("/"))
            {
                var mobj = this.ResolveObjectById(location, reference, false);
                if (mobj != null)
                {
                    result.Add(mobj);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            var currentReference = reference;
            bool currentElementsAreModelObjects = false;
            List<object> currentElements = null;
            while (!string.IsNullOrWhiteSpace(currentReference))
            {
                (currentReference, currentElements, currentElementsAreModelObjects) = this.ResolveXPointPart(location, currentReference, currentElements, currentElementsAreModelObjects);
            }
            if (currentElements != null && currentElements.Count > 0)
            {
                if (currentElementsAreModelObjects) result.AddRange(currentElements.OfType<IModelObject>());
                else result.AddRange(currentElements.OfType<XElement>().Select(e => ResolveObjectByPosition(e)));
                return true;
            }
            else
            {
                return false;
            }
        }

        private (string, List<object>, bool) ResolveXPointPart(XObject location, string currentReference, List<object> currentElements, bool currentElementsAreModelObjects)
        {
            string nextReference = null;
            bool recursive = currentReference.StartsWith("//");
            bool resolveByElementName = currentReference.StartsWith("//@") || currentReference.StartsWith("/@");
            bool resolveByObjectName = !resolveByElementName && currentReference.StartsWith("/");
            string elementName = null;

            if (resolveByElementName) (elementName, nextReference) = this.GetNextXPointPart(currentReference.Substring(recursive ? 3 : 2));
            else if (resolveByObjectName) (elementName, nextReference) = this.GetNextXPointPart(currentReference.Substring(recursive ? 2 : 1));
            else nextReference = null;

            int index = -1;
            int openIndex = elementName.IndexOf('[');
            int closeIndex = elementName.LastIndexOf(']');
            int dotIndex = elementName.LastIndexOf('.');
            if (openIndex >= 0 && closeIndex == elementName.Length)
            {
                var indexStr = elementName.Substring(openIndex + 1, closeIndex - openIndex - 1);
                if (int.TryParse(indexStr, out index)) index -= 1;
                else index = -1;
                elementName = elementName.Substring(0, openIndex);
            }
            else if (dotIndex >= 0)
            {
                var indexStr = elementName.Substring(dotIndex + 1);
                if (!int.TryParse(indexStr, out index)) index = -1;
                elementName = elementName.Substring(0, dotIndex);
            }

            if (resolveByElementName)
            {
                var nextElements = new List<object>();
                IEnumerable<XElement> parentElements = null;
                if (currentElements == null)
                {
                    if (recursive)
                    {
                        parentElements = _root.DescendantsAndSelf(elementName);
                    }
                    else
                    {
                        parentElements = _root.Name == elementName ? ImmutableArray.Create(_root) : ImmutableArray<XElement>.Empty;
                    }
                    int i = 0;
                    foreach (var refElem in parentElements)
                    {
                        var elem = ResolveObjectByPosition(refElem, false);
                        if (elem != null && (index < 0 || i == index))
                        {
                            nextElements.Add(refElem);
                        }
                        ++i;
                    }
                }
                else
                {
                    if (currentElementsAreModelObjects) parentElements = currentElements.OfType<IModelObject>().Select(mobj => ResolveElementByObject(mobj, location));
                    else parentElements = currentElements.OfType<XElement>();
                    foreach (var parentElement in parentElements)
                    {
                        int i = 0;
                        var items = recursive ? parentElement.Descendants(elementName) : parentElement.Elements(elementName);
                        foreach (var refElem in items)
                        {
                            var elem = ResolveObjectByPosition(refElem, false);
                            if (elem != null && (index < 0 || i == index))
                            {
                                nextElements.Add(refElem);
                            }
                            ++i;
                        }
                    }
                }
                return (nextReference, nextElements, false);
            }

            if (resolveByObjectName)
            {
                var nextElements = new List<object>();
                if (currentElements == null)
                {
                    if (recursive) nextElements.AddRange(_model.Objects.Where(mobj => mobj.MName == elementName));
                    else nextElements.AddRange(_model.Objects.Where(mobj => mobj.MParent == null && mobj.MName == elementName));
                }
                else
                {
                    IEnumerable<IModelObject> parentObjects = null;
                    if (currentElementsAreModelObjects) parentObjects = currentElements.OfType<IModelObject>();
                    else parentObjects = currentElements.OfType<XElement>().Select(e => ResolveObjectByPosition(e));
                    foreach (var parentObject in parentObjects)
                    {
                        int i = 0;
                        var descendants = recursive ? GetModelObjectsRecursive(parentObject, elementName) : parentObject.MChildren.Where(mobj => mobj.MName == elementName);
                        foreach (var child in descendants)
                        {
                            if (child.MName == elementName)
                            {
                                nextElements.Add(child);
                                ++i;
                            }
                        }
                    }
                }
                return (nextReference, nextElements, true);
            }
            this.AddError(location, $"Unable to process reference '{currentReference}', because it is of an unknown format.");
            return (null, null, false);
        }

        private (string, string) GetNextXPointPart(string currentReference)
        {
            int slashIndex = currentReference.IndexOf('/');
            var elementName = currentReference;
            if (slashIndex >= 0)
            {
                elementName = currentReference.Substring(0, slashIndex);
                currentReference = currentReference.Substring(slashIndex);
            }
            else
            {
                currentReference = null;
            }
            return (elementName, currentReference);
        }

        private IEnumerable<IModelObject> GetModelObjectsRecursive(IModelObject parent, string name)
        {
            foreach (var child in parent.MChildren)
            {
                if (child.MName == name) yield return child;
                foreach (var descendant in GetModelObjectsRecursive(child, name))
                {
                    yield return descendant;
                }
            }
        }

    }
}
