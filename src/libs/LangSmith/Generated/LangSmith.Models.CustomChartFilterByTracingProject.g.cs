
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartFilterByTracingProject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"tracing_project"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public string SourceType { get; set; } = "tracing_project";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_filter")]
        public string? RunFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_filter")]
        public string? TreeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFilterByTracingProject" /> class.
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="runFilter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="sourceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartFilterByTracingProject(
            global::System.Collections.Generic.IList<global::System.Guid> projectIds,
            string? runFilter,
            string? traceFilter,
            string? treeFilter,
            string sourceType = "tracing_project")
        {
            this.SourceType = sourceType;
            this.RunFilter = runFilter;
            this.TraceFilter = traceFilter;
            this.TreeFilter = treeFilter;
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFilterByTracingProject" /> class.
        /// </summary>
        public CustomChartFilterByTracingProject()
        {
        }

    }
}