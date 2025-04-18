
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleCustomChartSubSectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<global::System.Guid?, string> Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponse> Charts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCustomChartSubSectionResponse" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="id"></param>
        /// <param name="charts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SingleCustomChartSubSectionResponse(
            string title,
            int index,
            global::LangSmith.AnyOf<global::System.Guid?, string> id,
            global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponse> charts,
            string? description)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Index = index;
            this.Id = id;
            this.Charts = charts ?? throw new global::System.ArgumentNullException(nameof(charts));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCustomChartSubSectionResponse" /> class.
        /// </summary>
        public SingleCustomChartSubSectionResponse()
        {
        }
    }
}