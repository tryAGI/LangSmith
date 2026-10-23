
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorFeedbackMapping
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_array_index")]
        public int? JsonArrayIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_items")]
        public int? MinItems { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_object_keys")]
        public global::System.Collections.Generic.IList<string>? JsonObjectKeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorFeedbackMapping" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="jsonArrayIndex"></param>
        /// <param name="minItems"></param>
        /// <param name="jsonObjectKeys"></param>
        /// <param name="comment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorFeedbackMapping(
            string source,
            int? jsonArrayIndex,
            int? minItems,
            global::System.Collections.Generic.IList<string>? jsonObjectKeys,
            string? comment)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.JsonArrayIndex = jsonArrayIndex;
            this.MinItems = minItems;
            this.JsonObjectKeys = jsonObjectKeys;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorFeedbackMapping" /> class.
        /// </summary>
        public EvaluatorFeedbackMapping()
        {
        }

    }
}