
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserOnboardingStateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid LsUserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing_completed_at")]
        public global::System.DateTime? TracingCompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lgstudio_completed_at")]
        public global::System.DateTime? LgstudioCompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playground_completed_at")]
        public global::System.DateTime? PlaygroundCompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_completed_at")]
        public global::System.DateTime? EvaluationCompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_viewed_at")]
        public global::System.DateTime? SuccessViewedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserOnboardingStateResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lsUserId"></param>
        /// <param name="tracingCompletedAt"></param>
        /// <param name="lgstudioCompletedAt"></param>
        /// <param name="playgroundCompletedAt"></param>
        /// <param name="evaluationCompletedAt"></param>
        /// <param name="successViewedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserOnboardingStateResponse(
            global::System.Guid id,
            global::System.Guid lsUserId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? tracingCompletedAt,
            global::System.DateTime? lgstudioCompletedAt,
            global::System.DateTime? playgroundCompletedAt,
            global::System.DateTime? evaluationCompletedAt,
            global::System.DateTime? successViewedAt)
        {
            this.Id = id;
            this.LsUserId = lsUserId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TracingCompletedAt = tracingCompletedAt;
            this.LgstudioCompletedAt = lgstudioCompletedAt;
            this.PlaygroundCompletedAt = playgroundCompletedAt;
            this.EvaluationCompletedAt = evaluationCompletedAt;
            this.SuccessViewedAt = successViewedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserOnboardingStateResponse" /> class.
        /// </summary>
        public UserOnboardingStateResponse()
        {
        }
    }
}