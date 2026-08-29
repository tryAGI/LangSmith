
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TenantShareThreadToken
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "thread";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShareToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadId { get; set; }

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
        public string? SessionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareThreadToken" /> class.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="createdAt"></param>
        /// <param name="threadId"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TenantShareThreadToken(
            string shareToken,
            global::System.DateTime createdAt,
            string threadId,
            global::System.Guid sessionId,
            string? sessionName,
            string type = "thread")
        {
            this.Type = type;
            this.ShareToken = shareToken ?? throw new global::System.ArgumentNullException(nameof(shareToken));
            this.CreatedAt = createdAt;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.SessionId = sessionId;
            this.SessionName = sessionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareThreadToken" /> class.
        /// </summary>
        public TenantShareThreadToken()
        {
        }

    }
}