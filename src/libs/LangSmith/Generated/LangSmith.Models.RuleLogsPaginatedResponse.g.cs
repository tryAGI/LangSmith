
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Paginated response for rule logs with cursor-based pagination.
    /// </summary>
    public sealed partial class RuleLogsPaginatedResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema> Logs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleLogsPaginatedResponse" /> class.
        /// </summary>
        /// <param name="logs"></param>
        /// <param name="cursor"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuleLogsPaginatedResponse(
            global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema> logs,
            bool hasMore,
            string? cursor)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.HasMore = hasMore;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleLogsPaginatedResponse" /> class.
        /// </summary>
        public RuleLogsPaginatedResponse()
        {
        }
    }
}