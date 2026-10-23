
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FilterViewUpdate
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
        public string? DisplayName { get; set; }

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
        ///
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::LangSmith.FilterViewUpdateType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterViewUpdate" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="displayName"></param>
        /// <param name="duration"></param>
        /// <param name="endTime"></param>
        /// <param name="filterString"></param>
        /// <param name="startTime"></param>
        /// <param name="syntaxVersion"></param>
        /// <param name="threadFilterString"></param>
        /// <param name="traceFilterString"></param>
        /// <param name="treeFilterString"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterViewUpdate(
            string? description,
            string? displayName,
            string? duration,
            global::System.DateTime? endTime,
            string? filterString,
            global::System.DateTime? startTime,
            int? syntaxVersion,
            string? threadFilterString,
            string? traceFilterString,
            string? treeFilterString,
            global::LangSmith.FilterViewUpdateType? type)
        {
            this.Description = description;
            this.DisplayName = displayName;
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
        /// Initializes a new instance of the <see cref="FilterViewUpdate" /> class.
        /// </summary>
        public FilterViewUpdate()
        {
        }

    }
}