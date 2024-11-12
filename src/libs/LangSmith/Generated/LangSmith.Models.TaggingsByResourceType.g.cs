
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaggingsByResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Prompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queues")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Queues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiments")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Experiments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Datasets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashboards")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Dashboards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggingsByResourceType" /> class.
        /// </summary>
        /// <param name="prompts"></param>
        /// <param name="projects"></param>
        /// <param name="queues"></param>
        /// <param name="deployments"></param>
        /// <param name="experiments"></param>
        /// <param name="datasets"></param>
        /// <param name="dashboards"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TaggingsByResourceType(
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? prompts,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? projects,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? queues,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? deployments,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? experiments,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? datasets,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? dashboards)
        {
            this.Prompts = prompts;
            this.Projects = projects;
            this.Queues = queues;
            this.Deployments = deployments;
            this.Experiments = experiments;
            this.Datasets = datasets;
            this.Dashboards = dashboards;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggingsByResourceType" /> class.
        /// </summary>
        public TaggingsByResourceType()
        {
        }
    }
}