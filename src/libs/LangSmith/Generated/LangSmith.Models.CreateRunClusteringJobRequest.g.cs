
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request to create a run clustering job.
    /// </summary>
    public sealed partial class CreateRunClusteringJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_n_hours")]
        public int? LastNHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy")]
        public global::System.Collections.Generic.IList<int>? Hierarchy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitions")]
        public global::System.Collections.Generic.Dictionary<string, string>? Partitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?>))]
        public global::LangSmith.AnyOf<double?, int?>? Sample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_prompt")]
        public string? SummaryPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunClusteringJobRequest" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="lastNHours"></param>
        /// <param name="hierarchy"></param>
        /// <param name="partitions"></param>
        /// <param name="sample"></param>
        /// <param name="summaryPrompt"></param>
        /// <param name="filter"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRunClusteringJobRequest(
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            int? lastNHours,
            global::System.Collections.Generic.IList<int>? hierarchy,
            global::System.Collections.Generic.Dictionary<string, string>? partitions,
            global::LangSmith.AnyOf<double?, int?>? sample,
            string? summaryPrompt,
            string? filter,
            string? name)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.LastNHours = lastNHours;
            this.Hierarchy = hierarchy;
            this.Partitions = partitions;
            this.Sample = sample;
            this.SummaryPrompt = summaryPrompt;
            this.Filter = filter;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunClusteringJobRequest" /> class.
        /// </summary>
        public CreateRunClusteringJobRequest()
        {
        }
    }
}