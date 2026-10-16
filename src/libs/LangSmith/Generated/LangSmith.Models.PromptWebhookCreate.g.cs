
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Schema for creating a prompt webhook.
    /// </summary>
    public sealed partial class PromptWebhookCreate
    {
        /// <summary>
        /// URL that receives a POST request with the prompt event payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// HTTP headers sent with each request, for example an Authorization header. Values are stored encrypted and are masked in responses to callers who cannot update prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// IDs of the prompts whose events fire the webhook. When empty, events from every prompt in the workspace fire it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_prompts")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludePrompts { get; set; }

        /// <summary>
        /// IDs of prompts whose events never fire the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_prompts")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExcludePrompts { get; set; }

        /// <summary>
        /// Events that fire the webhook: commit (a new prompt commit), tag:create, and tag:update. A webhook with no triggers never fires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? Triggers { get; set; }

        /// <summary>
        /// ID to assign to the webhook. Generated when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWebhookCreate" /> class.
        /// </summary>
        /// <param name="url">
        /// URL that receives a POST request with the prompt event payload.
        /// </param>
        /// <param name="headers">
        /// HTTP headers sent with each request, for example an Authorization header. Values are stored encrypted and are masked in responses to callers who cannot update prompts.
        /// </param>
        /// <param name="includePrompts">
        /// IDs of the prompts whose events fire the webhook. When empty, events from every prompt in the workspace fire it.
        /// </param>
        /// <param name="excludePrompts">
        /// IDs of prompts whose events never fire the webhook.
        /// </param>
        /// <param name="triggers">
        /// Events that fire the webhook: commit (a new prompt commit), tag:create, and tag:update. A webhook with no triggers never fires.
        /// </param>
        /// <param name="id">
        /// ID to assign to the webhook. Generated when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptWebhookCreate(
            string url,
            object? headers,
            global::System.Collections.Generic.IList<global::System.Guid>? includePrompts,
            global::System.Collections.Generic.IList<global::System.Guid>? excludePrompts,
            global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? triggers,
            global::System.Guid? id)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.IncludePrompts = includePrompts;
            this.ExcludePrompts = excludePrompts;
            this.Triggers = triggers;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWebhookCreate" /> class.
        /// </summary>
        public PromptWebhookCreate()
        {
        }

    }
}