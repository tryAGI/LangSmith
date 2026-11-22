
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesAnnotationQueueItemReviewAnswer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public global::LangSmith.AgreementAnswer? Answer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public string? LsUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueItemReviewAnswer" /> class.
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="lsUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesAnnotationQueueItemReviewAnswer(
            global::LangSmith.AgreementAnswer? answer,
            string? lsUserId)
        {
            this.Answer = answer;
            this.LsUserId = lsUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueItemReviewAnswer" /> class.
        /// </summary>
        public AnnotationqueuesAnnotationQueueItemReviewAnswer()
        {
        }

    }
}