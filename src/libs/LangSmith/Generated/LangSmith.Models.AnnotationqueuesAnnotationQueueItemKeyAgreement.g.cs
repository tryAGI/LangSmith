
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesAnnotationQueueItemKeyAgreement
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public global::LangSmith.AgreementAnswer? Answer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final")]
        public global::LangSmith.AgreementAnswer? Final { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_set_at")]
        public global::System.DateTime? FinalSetAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_set_by")]
        public string? FinalSetBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_final")]
        public bool? HasFinal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgreementStateJsonConverter))]
        public global::LangSmith.AgreementState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueItemKeyAgreement" /> class.
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="final"></param>
        /// <param name="finalSetAt"></param>
        /// <param name="finalSetBy"></param>
        /// <param name="hasFinal"></param>
        /// <param name="key"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesAnnotationQueueItemKeyAgreement(
            global::LangSmith.AgreementAnswer? answer,
            global::LangSmith.AgreementAnswer? final,
            global::System.DateTime? finalSetAt,
            string? finalSetBy,
            bool? hasFinal,
            string? key,
            global::LangSmith.AgreementState? state)
        {
            this.Answer = answer;
            this.Final = final;
            this.FinalSetAt = finalSetAt;
            this.FinalSetBy = finalSetBy;
            this.HasFinal = hasFinal;
            this.Key = key;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueItemKeyAgreement" /> class.
        /// </summary>
        public AnnotationqueuesAnnotationQueueItemKeyAgreement()
        {
        }

    }
}