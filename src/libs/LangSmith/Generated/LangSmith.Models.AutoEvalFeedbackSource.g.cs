
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Auto eval feedback source.
    /// </summary>
    public sealed partial class AutoEvalFeedbackSource
    {
        /// <summary>
        /// Default Value: auto_eval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoEvalFeedbackSource" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: auto_eval
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoEvalFeedbackSource(
            string? type,
            object? metadata)
        {
            this.Type = type;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoEvalFeedbackSource" /> class.
        /// </summary>
        public AutoEvalFeedbackSource()
        {
        }
    }
}