
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsSectionUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionUpdate" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CustomChartsSectionUpdate(
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? title,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? description,
            global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? index)
        {
            this.Title = title;
            this.Description = description;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionUpdate" /> class.
        /// </summary>
        public CustomChartsSectionUpdate()
        {
        }
    }
}