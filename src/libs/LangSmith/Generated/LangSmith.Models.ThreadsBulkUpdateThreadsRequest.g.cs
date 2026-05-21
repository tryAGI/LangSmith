
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsBulkUpdateThreadsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::LangSmith.ThreadsUpdateThreadRequest? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_ids")]
        public global::System.Collections.Generic.IList<string>? ThreadIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsBulkUpdateThreadsRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="threadIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsBulkUpdateThreadsRequest(
            global::LangSmith.ThreadsUpdateThreadRequest? data,
            global::System.Collections.Generic.IList<string>? threadIds)
        {
            this.Data = data;
            this.ThreadIds = threadIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsBulkUpdateThreadsRequest" /> class.
        /// </summary>
        public ThreadsBulkUpdateThreadsRequest()
        {
        }

    }
}