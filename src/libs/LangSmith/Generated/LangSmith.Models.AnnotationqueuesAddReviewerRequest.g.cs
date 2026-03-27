
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationqueuesAddReviewerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdentityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAddReviewerRequest" /> class.
        /// </summary>
        /// <param name="identityId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesAddReviewerRequest(
            string identityId)
        {
            this.IdentityId = identityId ?? throw new global::System.ArgumentNullException(nameof(identityId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAddReviewerRequest" /> class.
        /// </summary>
        public AnnotationqueuesAddReviewerRequest()
        {
        }
    }
}