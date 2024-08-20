
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Schema for a batch of runs to be ingested.
    /// </summary>
    public sealed partial class BatchIngestRunsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post")]
        public global::System.Collections.Generic.IList<global::LangSmith.BatchIngestRunsRequestPostItem>? Post { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch")]
        public global::System.Collections.Generic.IList<global::LangSmith.BatchIngestRunsRequestPatchItem>? Patch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}