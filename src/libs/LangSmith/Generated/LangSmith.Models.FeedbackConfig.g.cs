
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackConfig
    {
        /// <summary>
        /// Enum for feedback types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.FeedbackTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.FeedbackType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCategory>? Categories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Enum for feedback types.
        /// </param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="categories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackConfig(
            global::LangSmith.FeedbackType type,
            double? min,
            double? max,
            global::System.Collections.Generic.IList<global::LangSmith.FeedbackCategory>? categories)
        {
            this.Type = type;
            this.Min = min;
            this.Max = max;
            this.Categories = categories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackConfig" /> class.
        /// </summary>
        public FeedbackConfig()
        {
        }
    }
}