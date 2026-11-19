
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesItemKeyAgreement
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public global::LangSmith.AgreementAnswer? Answer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_final")]
        public bool? HasFinal { get; set; }

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
        /// Initializes a new instance of the <see cref="AnnotationqueuesItemKeyAgreement" /> class.
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="hasFinal"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesItemKeyAgreement(
            global::LangSmith.AgreementAnswer? answer,
            bool? hasFinal,
            global::LangSmith.AgreementState? state)
        {
            this.Answer = answer;
            this.HasFinal = hasFinal;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesItemKeyAgreement" /> class.
        /// </summary>
        public AnnotationqueuesItemKeyAgreement()
        {
        }

    }
}