
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesSetItemReviewRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<string>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesSetItemReviewRequest" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesSetItemReviewRequest(
            double? score,
            string? value,
            global::System.Collections.Generic.IList<string>? values)
        {
            this.Score = score;
            this.Value = value;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesSetItemReviewRequest" /> class.
        /// </summary>
        public AnnotationqueuesSetItemReviewRequest()
        {
        }

    }
}