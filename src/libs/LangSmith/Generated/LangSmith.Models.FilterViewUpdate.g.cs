
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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_string")]
        public string? FilterString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.FilterViewTypeJsonConverter))]
        public global::LangSmith.FilterViewType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterViewUpdate" /> class.
        /// </summary>
        /// <param name="filterString"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="traceFilterString"></param>
        /// <param name="treeFilterString"></param>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FilterViewUpdate(
            string? filterString,
            string? displayName,
            string? description,
            string? traceFilterString,
            string? treeFilterString,
            global::LangSmith.FilterViewType? type)
        {
            this.FilterString = filterString;
            this.DisplayName = displayName;
            this.Description = description;
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