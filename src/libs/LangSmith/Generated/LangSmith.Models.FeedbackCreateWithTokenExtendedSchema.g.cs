
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Feedback create schema with token.
    /// </summary>
    public sealed partial class FeedbackCreateWithTokenExtendedSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory3))]
        public global::LangSmith.AnyOf<double?, int?, bool?>? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory4))]
        public global::LangSmith.AnyOf<double?, int?, bool?, string>? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<object, string>? Correction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateWithTokenExtendedSchema" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="metadata"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FeedbackCreateWithTokenExtendedSchema(
            global::LangSmith.AnyOf<double?, int?, bool?>? score,
            global::LangSmith.AnyOf<double?, int?, bool?, string>? value,
            string? comment,
            global::LangSmith.AnyOf<object, string>? correction,
            object? metadata)
        {
            this.Score = score;
            this.Value = value;
            this.Comment = comment;
            this.Correction = correction;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateWithTokenExtendedSchema" /> class.
        /// </summary>
        public FeedbackCreateWithTokenExtendedSchema()
        {
        }
    }
}