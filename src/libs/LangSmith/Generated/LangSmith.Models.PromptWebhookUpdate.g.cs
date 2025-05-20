
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Schema for updating a prompt webhook.
    /// </summary>
    public sealed partial class PromptWebhookUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_prompts")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludePrompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_prompts")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExcludePrompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? Triggers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWebhookUpdate" /> class.
        /// </summary>
        /// <param name="includePrompts"></param>
        /// <param name="excludePrompts"></param>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        /// <param name="triggers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptWebhookUpdate(
            global::System.Collections.Generic.IList<global::System.Guid>? includePrompts,
            global::System.Collections.Generic.IList<global::System.Guid>? excludePrompts,
            string? url,
            object? headers,
            global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? triggers)
        {
            this.IncludePrompts = includePrompts;
            this.ExcludePrompts = excludePrompts;
            this.Url = url;
            this.Headers = headers;
            this.Triggers = triggers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWebhookUpdate" /> class.
        /// </summary>
        public PromptWebhookUpdate()
        {
        }
    }
}