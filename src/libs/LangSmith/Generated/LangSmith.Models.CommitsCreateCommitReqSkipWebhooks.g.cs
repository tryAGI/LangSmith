
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// SkipWebhooks allows skipping webhook notifications. Can be true (boolean) to skip all, or an array of webhook UUIDs to skip specific ones.
    /// </summary>
    public sealed partial class CommitsCreateCommitReqSkipWebhooks
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}