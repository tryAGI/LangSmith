
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TypesFeedbackConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<global::LangSmith.TypesFeedbackCategory>? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.TypesFeedbackTypeJsonConverter))]
        public global::LangSmith.TypesFeedbackType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypesFeedbackConfig" /> class.
        /// </summary>
        /// <param name="categories"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypesFeedbackConfig(
            global::System.Collections.Generic.IList<global::LangSmith.TypesFeedbackCategory>? categories,
            double? max,
            double? min,
            global::LangSmith.TypesFeedbackType? type)
        {
            this.Categories = categories;
            this.Max = max;
            this.Min = min;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypesFeedbackConfig" /> class.
        /// </summary>
        public TypesFeedbackConfig()
        {
        }
    }
}