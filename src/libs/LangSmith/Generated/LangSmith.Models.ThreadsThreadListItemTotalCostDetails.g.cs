
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// `total_cost_details` sums per-category estimated USD cost across traces in the thread. Keys mirror `total_token_details`.<br/>
    /// Example: `{"cache_read": 0.012, "reasoning": 0.008}`.
    /// </summary>
    public sealed partial class ThreadsThreadListItemTotalCostDetails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}