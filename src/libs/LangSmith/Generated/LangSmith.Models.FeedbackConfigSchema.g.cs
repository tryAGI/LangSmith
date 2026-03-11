
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackConfigSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string FeedbackKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.FeedbackConfig FeedbackConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime ModifiedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_lower_score_better")]
        public bool? IsLowerScoreBetter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackConfigSchema" /> class.
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="tenantId"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="isLowerScoreBetter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackConfigSchema(
            string feedbackKey,
            global::LangSmith.FeedbackConfig feedbackConfig,
            global::System.Guid tenantId,
            global::System.DateTime modifiedAt,
            bool? isLowerScoreBetter)
        {
            this.FeedbackKey = feedbackKey ?? throw new global::System.ArgumentNullException(nameof(feedbackKey));
            this.FeedbackConfig = feedbackConfig ?? throw new global::System.ArgumentNullException(nameof(feedbackConfig));
            this.TenantId = tenantId;
            this.ModifiedAt = modifiedAt;
            this.IsLowerScoreBetter = isLowerScoreBetter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackConfigSchema" /> class.
        /// </summary>
        public FeedbackConfigSchema()
        {
        }
    }
}