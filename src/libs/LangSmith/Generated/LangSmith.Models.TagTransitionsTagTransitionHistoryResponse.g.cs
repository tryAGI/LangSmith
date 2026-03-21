
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TagTransitionsTagTransitionHistoryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transitions")]
        public global::System.Collections.Generic.IList<global::LangSmith.TagTransitionsTagTransition>? Transitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagTransitionsTagTransitionHistoryResponse" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="transitions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TagTransitionsTagTransitionHistoryResponse(
            int? total,
            global::System.Collections.Generic.IList<global::LangSmith.TagTransitionsTagTransition>? transitions)
        {
            this.Total = total;
            this.Transitions = transitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagTransitionsTagTransitionHistoryResponse" /> class.
        /// </summary>
        public TagTransitionsTagTransitionHistoryResponse()
        {
        }
    }
}