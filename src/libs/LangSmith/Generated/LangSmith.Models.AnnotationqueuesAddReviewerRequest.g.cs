
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
        /// Give the new reviewer pending reviews nobody has opened. Defaults to true. Only applies when the queue's reviews per item is a number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("should_redistribute")]
        public bool? ShouldRedistribute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAddReviewerRequest" /> class.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="shouldRedistribute">
        /// Give the new reviewer pending reviews nobody has opened. Defaults to true. Only applies when the queue's reviews per item is a number.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesAddReviewerRequest(
            string identityId,
            bool? shouldRedistribute)
        {
            this.IdentityId = identityId ?? throw new global::System.ArgumentNullException(nameof(identityId));
            this.ShouldRedistribute = shouldRedistribute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAddReviewerRequest" /> class.
        /// </summary>
        public AnnotationqueuesAddReviewerRequest()
        {
        }

    }
}