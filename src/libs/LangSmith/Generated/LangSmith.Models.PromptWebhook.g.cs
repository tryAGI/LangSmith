
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Schema for a prompt webhook.
    /// </summary>
    public sealed partial class PromptWebhook
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? Triggers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWebhook" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        /// <param name="includePrompts"></param>
        /// <param name="excludePrompts"></param>
        /// <param name="triggers"></param>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptWebhook(
            string url,
            global::System.Guid id,
            global::System.Guid tenantId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object? headers,
            global::System.Collections.Generic.IList<global::System.Guid>? includePrompts,
            global::System.Collections.Generic.IList<global::System.Guid>? excludePrompts,
            global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? triggers)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.TenantId = tenantId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Headers = headers;
            this.IncludePrompts = includePrompts;
            this.ExcludePrompts = excludePrompts;
            this.Triggers = triggers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWebhook" /> class.
        /// </summary>
        public PromptWebhook()
        {
        }
    }
}