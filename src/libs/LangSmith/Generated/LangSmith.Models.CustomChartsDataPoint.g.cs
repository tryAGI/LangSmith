
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsDataPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SeriesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, double?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<int?, double?, object>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsDataPoint" /> class.
        /// </summary>
        /// <param name="seriesId"></param>
        /// <param name="timestamp"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartsDataPoint(
            string seriesId,
            global::System.DateTime timestamp,
            global::LangSmith.AnyOf<int?, double?, object>? value)
        {
            this.SeriesId = seriesId ?? throw new global::System.ArgumentNullException(nameof(seriesId));
            this.Timestamp = timestamp;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsDataPoint" /> class.
        /// </summary>
        public CustomChartsDataPoint()
        {
        }
    }
}