
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationqueuesAddReviewerResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_id")]
        public string? IdentityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAddReviewerResponse" /> class.
        /// </summary>
        /// <param name="identityId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesAddReviewerResponse(
            string? identityId)
        {
            this.IdentityId = identityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAddReviewerResponse" /> class.
        /// </summary>
        public AnnotationqueuesAddReviewerResponse()
        {
        }
    }
}