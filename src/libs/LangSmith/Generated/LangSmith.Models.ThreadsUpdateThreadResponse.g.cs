
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsUpdateThreadResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public global::System.Guid? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::LangSmith.ThreadsUpdateThreadMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsUpdateThreadResponse" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="metadata"></param>
        /// <param name="title"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsUpdateThreadResponse(
            global::System.Guid? agentId,
            global::System.DateTime? createdAt,
            global::System.Guid? id,
            global::LangSmith.ThreadsUpdateThreadMetadata? metadata,
            string? title,
            global::System.DateTime? updatedAt)
        {
            this.AgentId = agentId;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Metadata = metadata;
            this.Title = title;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsUpdateThreadResponse" /> class.
        /// </summary>
        public ThreadsUpdateThreadResponse()
        {
        }

    }
}