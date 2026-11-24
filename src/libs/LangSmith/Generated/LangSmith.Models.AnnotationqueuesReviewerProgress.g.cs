
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesReviewerProgress
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_count")]
        public int? CompletedCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_id")]
        public string? IdentityId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_on_roster")]
        public bool? IsOnRoster { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active_at")]
        public global::System.DateTime? LastActiveAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_count")]
        public int? PendingCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesReviewerProgress" /> class.
        /// </summary>
        /// <param name="completedCount"></param>
        /// <param name="email"></param>
        /// <param name="identityId"></param>
        /// <param name="isOnRoster"></param>
        /// <param name="lastActiveAt"></param>
        /// <param name="name"></param>
        /// <param name="pendingCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesReviewerProgress(
            int? completedCount,
            string? email,
            string? identityId,
            bool? isOnRoster,
            global::System.DateTime? lastActiveAt,
            string? name,
            int? pendingCount)
        {
            this.CompletedCount = completedCount;
            this.Email = email;
            this.IdentityId = identityId;
            this.IsOnRoster = isOnRoster;
            this.LastActiveAt = lastActiveAt;
            this.Name = name;
            this.PendingCount = pendingCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesReviewerProgress" /> class.
        /// </summary>
        public AnnotationqueuesReviewerProgress()
        {
        }

    }
}