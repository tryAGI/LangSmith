
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryRunCompletionCostDetails
    {
        /// <summary>
        /// `raw` maps each category name to its estimated USD cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        public global::System.Collections.Generic.Dictionary<string, double>? Raw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRunCompletionCostDetails" /> class.
        /// </summary>
        /// <param name="raw">
        /// `raw` maps each category name to its estimated USD cost.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryRunCompletionCostDetails(
            global::System.Collections.Generic.Dictionary<string, double>? raw)
        {
            this.Raw = raw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRunCompletionCostDetails" /> class.
        /// </summary>
        public QueryRunCompletionCostDetails()
        {
        }

    }
}