
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsCreateThreadRequest
    {
        /// <summary>
        /// Example: 11111111-1111-1111-1111-111111111111
        /// </summary>
        /// <example>11111111-1111-1111-1111-111111111111</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("if_exists")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ThreadsCreateThreadRequestIfExistsJsonConverter))]
        public global::LangSmith.ThreadsCreateThreadRequestIfExists? IfExists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::LangSmith.ThreadsCreateThreadOptions? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public global::System.Guid? ThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsCreateThreadRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Example: 11111111-1111-1111-1111-111111111111
        /// </param>
        /// <param name="ifExists"></param>
        /// <param name="metadata"></param>
        /// <param name="options"></param>
        /// <param name="threadId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsCreateThreadRequest(
            string? agentId,
            global::LangSmith.ThreadsCreateThreadRequestIfExists? ifExists,
            object? metadata,
            global::LangSmith.ThreadsCreateThreadOptions? options,
            global::System.Guid? threadId)
        {
            this.AgentId = agentId;
            this.IfExists = ifExists;
            this.Metadata = metadata;
            this.Options = options;
            this.ThreadId = threadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsCreateThreadRequest" /> class.
        /// </summary>
        public ThreadsCreateThreadRequest()
        {
        }

    }
}