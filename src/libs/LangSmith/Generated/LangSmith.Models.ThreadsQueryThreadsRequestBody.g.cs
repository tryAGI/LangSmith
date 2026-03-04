
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsQueryThreadsRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_start_time")]
        public string? MaxStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_start_time")]
        public string? MinStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadsRequestBody" /> class.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="filter"></param>
        /// <param name="limit"></param>
        /// <param name="maxStartTime"></param>
        /// <param name="minStartTime"></param>
        /// <param name="sessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsQueryThreadsRequestBody(
            string? cursor,
            string? filter,
            int? limit,
            string? maxStartTime,
            string? minStartTime,
            string? sessionId)
        {
            this.Cursor = cursor;
            this.Filter = filter;
            this.Limit = limit;
            this.MaxStartTime = maxStartTime;
            this.MinStartTime = minStartTime;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadsRequestBody" /> class.
        /// </summary>
        public ThreadsQueryThreadsRequestBody()
        {
        }
    }
}