
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueryAISearchClarification
    {
        /// <summary>
        /// Two or three interpretations of the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::LangSmith.QueryAISearchClarificationOption>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAISearchClarification" /> class.
        /// </summary>
        /// <param name="options">
        /// Two or three interpretations of the search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryAISearchClarification(
            global::System.Collections.Generic.IList<global::LangSmith.QueryAISearchClarificationOption>? options)
        {
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAISearchClarification" /> class.
        /// </summary>
        public QueryAISearchClarification()
        {
        }

    }
}