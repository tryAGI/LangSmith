
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhooksSlackHandoffResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BotUserId { get; set; }

        /// <summary>
        /// Message is the custom instruction after the mention; "" means the default<br/>
        /// text ("Investigate this issue and open a fix if needed.").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSlackHandoffResponse" /> class.
        /// </summary>
        /// <param name="botUserId"></param>
        /// <param name="message">
        /// Message is the custom instruction after the mention; "" means the default<br/>
        /// text ("Investigate this issue and open a fix if needed.").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksSlackHandoffResponse(
            string botUserId,
            string message)
        {
            this.BotUserId = botUserId ?? throw new global::System.ArgumentNullException(nameof(botUserId));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSlackHandoffResponse" /> class.
        /// </summary>
        public WebhooksSlackHandoffResponse()
        {
        }

    }
}