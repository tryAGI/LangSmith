
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FilterView
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.FilterViewTypeJsonConverter))]
        public global::LangSmith.FilterViewType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterView" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="displayName"></param>
        /// <param name="id"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="duration"></param>
        /// <param name="endTime"></param>
        /// <param name="filterString"></param>
        /// <param name="sessionId"></param>
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
        public FilterView(
            global::System.DateTime createdAt,
            string displayName,
            global::System.Guid id,
            global::System.DateTime updatedAt,
            string? description,
            string? duration,
            global::System.DateTime? endTime,
            string? filterString,
            global::System.Guid? sessionId,
            global::System.DateTime? startTime,
            int? syntaxVersion,
            string? threadFilterString,
            string? traceFilterString,
            string? treeFilterString,
            global::LangSmith.FilterViewType? type)
        {
            this.CreatedAt = createdAt;
            this.Description = description;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Duration = duration;
            this.EndTime = endTime;
            this.FilterString = filterString;
            this.Id = id;
            this.SessionId = sessionId;
            this.StartTime = startTime;
            this.SyntaxVersion = syntaxVersion;
            this.ThreadFilterString = threadFilterString;
            this.TraceFilterString = traceFilterString;
            this.TreeFilterString = treeFilterString;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterView" /> class.
        /// </summary>
        public FilterView()
        {
        }

    }
}