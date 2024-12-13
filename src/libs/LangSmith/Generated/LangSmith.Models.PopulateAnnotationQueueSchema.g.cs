
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PopulateAnnotationQueueSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid QueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> SessionIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PopulateAnnotationQueueSchema" /> class.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="sessionIds"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PopulateAnnotationQueueSchema(
            global::System.Guid queueId,
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds)
        {
            this.QueueId = queueId;
            this.SessionIds = sessionIds ?? throw new global::System.ArgumentNullException(nameof(sessionIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PopulateAnnotationQueueSchema" /> class.
        /// </summary>
        public PopulateAnnotationQueueSchema()
        {
        }
    }
}