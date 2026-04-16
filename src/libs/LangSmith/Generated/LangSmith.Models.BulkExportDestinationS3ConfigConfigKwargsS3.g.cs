
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Passed to botocore Config s3 parameter. Use {"addressing_style": "virtual"} for S3-compatible services that require virtual-hosted style addressing (e.g. Volcengine TOS), or {"addressing_style": "path"} for path-style.
    /// </summary>
    public sealed partial class BulkExportDestinationS3ConfigConfigKwargsS3
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}