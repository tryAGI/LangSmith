
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// `total_token_details` sums per-category token counts across traces in the thread. Keys are model-specific category names (for example `cache_read`, `cache_write`, `reasoning`, `audio`).<br/>
    /// Example: `{"cache_read": 400, "reasoning": 120}`.
    /// </summary>
    public sealed partial class ThreadsThreadListItemTotalTokenDetails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}