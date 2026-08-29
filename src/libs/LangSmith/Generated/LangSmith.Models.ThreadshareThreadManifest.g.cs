
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ThreadshareThreadManifest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations")]
        public object? Conversations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SessionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadshareThreadManifest" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="threadId"></param>
        /// <param name="conversations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadshareThreadManifest(
            global::System.Guid sessionId,
            string sessionName,
            string threadId,
            object? conversations)
        {
            this.Conversations = conversations;
            this.SessionId = sessionId;
            this.SessionName = sessionName ?? throw new global::System.ArgumentNullException(nameof(sessionName));
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadshareThreadManifest" /> class.
        /// </summary>
        public ThreadshareThreadManifest()
        {
        }

    }
}