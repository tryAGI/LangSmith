
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsSectionRequest
    {
        /// <summary>
        /// Default Value: UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Timedelta input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stride")]
        public global::LangSmith.TimedeltaInput? Stride { get; set; }

        /// <summary>
        /// Group by param for run stats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::LangSmith.RunStatsGroupBy? GroupBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionRequest" /> class.
        /// </summary>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stride">
        /// Timedelta input.
        /// </param>
        /// <param name="groupBy">
        /// Group by param for run stats.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartsSectionRequest(
            global::System.DateTime startTime,
            string? timezone,
            global::System.DateTime? endTime,
            global::LangSmith.TimedeltaInput? stride,
            global::LangSmith.RunStatsGroupBy? groupBy)
        {
            this.StartTime = startTime;
            this.Timezone = timezone;
            this.EndTime = endTime;
            this.Stride = stride;
            this.GroupBy = groupBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionRequest" /> class.
        /// </summary>
        public CustomChartsSectionRequest()
        {
        }
    }
}