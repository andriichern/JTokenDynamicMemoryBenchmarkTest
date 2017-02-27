using System;
using System.Collections.Generic;

namespace JTokenDynamicBenchmark
{
    public class JsonObject
    {
        public List<string> ActionOverrides { get; set; }
        public bool Activateable { get; set; }
        public bool CompactLayoutable { get; set; }
        public bool Createable { get; set; }
        public bool Custom { get; set; }
        public bool CustomSetting { get; set; }
        public bool Deletable { get; set; }
        public bool DeprecatedAndHidden { get; set; }
        public bool FeedEnabled { get; set; }
        public string KeyPrefix { get; set; }
        public string Label { get; set; }
        public string LabelPlural { get; set; }
        public bool Layoutable { get; set; }
        public Nullable<bool> Listviewable { get; set; }
        public Nullable<bool> LookupLayoutable { get; set; }
        public bool Mergeable { get; set; }
        public string Name { get; set; }
        public List<string> NamedLayoutInfos { get; set; }
        public string NetworkScopeFieldName { get; set; }
        public bool Queryable { get; set; }
        public bool Replicateable { get; set; }
        public bool Retrieveable { get; set; }
        public bool SearchLayoutable { get; set; }
        public bool Searchable { get; set; }
        public bool Triggerable { get; set; }
        public bool Undeletable { get; set; }
        public bool Updateable { get; set; }

        public Dictionary<string, string> Urls { get; set; }

        public List<JsonObjectField> Fields { get; set; }

        public List<JsonObjectRecordTypeInfo> RecordTypeInfos { get; set; }

        public List<JsonObjectSupportedScope> SupportedScopes { get; set; }
    }

    public class JsonObjectRecordTypeInfo
    {
        public bool Available { get; set; }
        public bool DefaultRecordTypeMapping { get; set; }
        public bool Master { get; set; }
        public string Name { get; set; }
        public string RecordTypeId { get; set; }
        public Dictionary<string, string> Urls { get; set; }
    }

    public class JsonObjectSupportedScope
    {
        public string Label { get; set; }

        public string Name { get; set; }
    }

    public class JsonObjectField
    {
        public bool Aggregatable { get; set; }
        public bool AutoNumber { get; set; }
        public int ByteLength { get; set; }
        public bool Calculated { get; set; }
        public string CalculatedFormula { get; set; }
        public bool CascadeDelete { get; set; }
        public bool CaseSensitive { get; set; }
        public string ControllerName { get; set; }
        public bool Createable { get; set; }
        public bool Custom { get; set; }
        public string DefaultValue { get; set; }
        public string DefaultValueFormula { get; set; }
        public bool DefaultedOnCreate { get; set; }
        public bool DependentPicklist { get; set; }
        public bool DeprecatedAndHidden { get; set; }
        public int Digits { get; set; }
        public bool DisplayLocationInDecimal { get; set; }
        public bool Encrypted { get; set; }
        public bool ExternalId { get; set; }
        public string EextraTypeInfo { get; set; }
        public bool Filterable { get; set; }
        public JsonObjectFieldFilteredLookup FilteredLookupInfo { get; set; }
        public bool Groupable { get; set; }
        public bool HighScaleNumber { get; set; }
        public bool HtmlFormatted { get; set; }
        public bool IdLookup { get; set; }
        public string InlineHelpText { get; set; }
        public string Label { get; set; }
        public int Length { get; set; }
        public string Mask { get; set; }
        public string MaskType { get; set; }
        public string Name { get; set; }
        public bool NameField { get; set; }
        public bool NamePointing { get; set; }
        public bool Nillable { get; set; }
        public bool Permissionable { get; set; }
        public int Precision { get; set; }
        public bool QueryByDistance { get; set; }
        public string ReferenceTargetField { get; set; }
        public string RelationshipName { get; set; }
        public string RelationshipOrder { get; set; }
        public bool RestrictedDelete { get; set; }
        public bool RestrictedPicklist { get; set; }
        public int Scale { get; set; }
        public string SoapType { get; set; }
        public bool Sortable { get; set; }
        public string Type { get; set; }
        public bool Unique { get; set; }
        public bool Updateable { get; set; }
        public bool WriteRequiresMasterRead { get; set; }
        public List<string> ReferenceTo { get; set; }
        public List<JsonObjectFieldPicklistValue> PicklistValues { get; set; }
    }

    public class JsonObjectFieldFilteredLookup
    {
        public List<string> ControllingFields { get; set; }
        public bool Dependent { get; set; }
        public bool OptionalFilter { get; set; }
    }

    public class JsonObjectFieldPicklistValue
    {
        public bool Active { get; set; }
        public bool DefaultValue { get; set; }
        public string Label { get; set; }
        public string ValidFor { get; set; }
        public string Value { get; set; }
    }
}