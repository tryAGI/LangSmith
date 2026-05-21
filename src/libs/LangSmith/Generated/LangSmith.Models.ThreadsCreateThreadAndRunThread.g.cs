
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsCreateThreadAndRunThread
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("if_exists")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ThreadsCreateThreadAndRunThreadIfExistsJsonConverter))]
        public global::LangSmith.ThreadsCreateThreadAndRunThreadIfExists? IfExists { get; set; }

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
        /// Initializes a new instance of the <see cref="ThreadsCreateThreadAndRunThread" /> class.
        /// </summary>
        /// <param name="ifExists"></param>
        /// <param name="metadata"></param>
        /// <param name="options"></param>
        /// <param name="threadId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsCreateThreadAndRunThread(
            global::LangSmith.ThreadsCreateThreadAndRunThreadIfExists? ifExists,
            object? metadata,
            global::LangSmith.ThreadsCreateThreadOptions? options,
            global::System.Guid? threadId)
        {
            this.IfExists = ifExists;
            this.Metadata = metadata;
            this.Options = options;
            this.ThreadId = threadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsCreateThreadAndRunThread" /> class.
        /// </summary>
        public ThreadsCreateThreadAndRunThread()
        {
        }

    }
}