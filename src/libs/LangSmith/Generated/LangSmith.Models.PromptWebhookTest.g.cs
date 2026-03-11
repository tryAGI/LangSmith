
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Schema for testing a prompt webhook.
    /// </summary>
    public sealed partial class PromptWebhookTest
    {
        /// <summary>
        /// Base schema for prompt webhooks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.PromptWebhookBase Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.PromptWebhookPayload Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWebhookTest" /> class.
        /// </summary>
        /// <param name="webhook">
        /// Base schema for prompt webhooks.
        /// </param>
        /// <param name="payload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptWebhookTest(
            global::LangSmith.PromptWebhookBase webhook,
            global::LangSmith.PromptWebhookPayload payload)
        {
            this.Webhook = webhook ?? throw new global::System.ArgumentNullException(nameof(webhook));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWebhookTest" /> class.
        /// </summary>
        public PromptWebhookTest()
        {
        }
    }
}