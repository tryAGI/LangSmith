
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Feedback ingest token create schema.
    /// </summary>
    public sealed partial class FeedbackIngestTokenCreateSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public global::LangSmith.TimedeltaInput? ExpiresIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid RunId { get; set; } = default!;

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
        public global::LangSmith.FeedbackConfig? FeedbackConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackIngestTokenCreateSchema" /> class.
        /// </summary>
        /// <param name="expiresIn"></param>
        /// <param name="expiresAt"></param>
        /// <param name="runId"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="feedbackConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackIngestTokenCreateSchema(
            global::System.Guid runId,
            string feedbackKey,
            global::LangSmith.TimedeltaInput? expiresIn,
            global::System.DateTime? expiresAt,
            global::LangSmith.FeedbackConfig? feedbackConfig)
        {
            this.RunId = runId;
            this.FeedbackKey = feedbackKey ?? throw new global::System.ArgumentNullException(nameof(feedbackKey));
            this.ExpiresIn = expiresIn;
            this.ExpiresAt = expiresAt;
            this.FeedbackConfig = feedbackConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackIngestTokenCreateSchema" /> class.
        /// </summary>
        public FeedbackIngestTokenCreateSchema()
        {
        }
    }
}