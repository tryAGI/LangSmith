
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FilterViewCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_string")]
        public string? FilterString { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syntax_version")]
        public int? SyntaxVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_filter_string")]
        public string? ThreadFilterString { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filter_string")]
        public string? TraceFilterString { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_filter_string")]
        public string? TreeFilterString { get; set; }

        /// <summary>
        /// Default Value: runs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.FilterViewCreateTypeJsonConverter))]
        public global::LangSmith.FilterViewCreateType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterViewCreate" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="duration"></param>
        /// <param name="endTime"></param>
        /// <param name="filterString"></param>
        /// <param name="startTime"></param>
        /// <param name="syntaxVersion">
        /// Default Value: 1
        /// </param>
        /// <param name="threadFilterString"></param>
        /// <param name="traceFilterString"></param>
        /// <param name="treeFilterString"></param>
        /// <param name="type">
        /// Default Value: runs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterViewCreate(
            string displayName,
            string? description,
            string? duration,
            global::System.DateTime? endTime,
            string? filterString,
            global::System.DateTime? startTime,
            int? syntaxVersion,
            string? threadFilterString,
            string? traceFilterString,
            string? treeFilterString,
            global::LangSmith.FilterViewCreateType? type)
        {
            this.Description = description;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Duration = duration;
            this.EndTime = endTime;
            this.FilterString = filterString;
            this.StartTime = startTime;
            this.SyntaxVersion = syntaxVersion;
            this.ThreadFilterString = threadFilterString;
            this.TraceFilterString = traceFilterString;
            this.TreeFilterString = treeFilterString;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterViewCreate" /> class.
        /// </summary>
        public FilterViewCreate()
        {
        }

    }
}