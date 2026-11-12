
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// KMS key ARNs keyed by service: s3, ebs, eks, rds, or elasticache. Each overrides key_arn for its service. Without key_arn, services not listed keep AWS-managed encryption.
    /// </summary>
    public sealed partial class DataPlanesCreateDataPlaneCMKSettingsServiceKeyArns
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}