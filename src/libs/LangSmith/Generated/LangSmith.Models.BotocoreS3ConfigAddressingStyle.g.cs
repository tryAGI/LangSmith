
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// S3 addressing style. Use "virtual" for services that require virtual-hosted style (e.g. Volcengine TOS), "path" for path-style, or "auto" (default) to let boto3 decide.
    /// </summary>
    public sealed partial class BotocoreS3ConfigAddressingStyle
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}