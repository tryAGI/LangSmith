
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryRunPromptTokenDetails
    {
        /// <summary>
        /// `raw` maps each category name to its prompt-token count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        public global::System.Collections.Generic.Dictionary<string, long>? Raw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRunPromptTokenDetails" /> class.
        /// </summary>
        /// <param name="raw">
        /// `raw` maps each category name to its prompt-token count.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryRunPromptTokenDetails(
            global::System.Collections.Generic.Dictionary<string, long>? raw)
        {
            this.Raw = raw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRunPromptTokenDetails" /> class.
        /// </summary>
        public QueryRunPromptTokenDetails()
        {
        }

    }
}