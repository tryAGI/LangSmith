
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsSectionUpdate
    {
        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Title { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? Description { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionUpdate" /> class.
        /// </summary>
        /// <param name="title">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="index">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartsSectionUpdate(
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? title,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? description,
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