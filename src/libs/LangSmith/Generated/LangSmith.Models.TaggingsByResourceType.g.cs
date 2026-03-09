
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaggingsByResourceType
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alerts")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Alerts { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashboards")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Dashboards { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Datasets { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Deployments { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiments")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Experiments { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Projects { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Prompts { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queues")]
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Queues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggingsByResourceType" /> class.
        /// </summary>
        /// <param name="alerts">
        /// Default Value: []
        /// </param>
        /// <param name="dashboards">
        /// Default Value: []
        /// </param>
        /// <param name="datasets">
        /// Default Value: []
        /// </param>
        /// <param name="deployments">
        /// Default Value: []
        /// </param>
        /// <param name="experiments">
        /// Default Value: []
        /// </param>
        /// <param name="projects">
        /// Default Value: []
        /// </param>
        /// <param name="prompts">
        /// Default Value: []
        /// </param>
        /// <param name="queues">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaggingsByResourceType(
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? alerts,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? dashboards,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? datasets,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? deployments,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? experiments,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? projects,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? prompts,
            global::System.Collections.Generic.IList<global::LangSmith.Resource>? queues)
        {
            this.Alerts = alerts;
            this.Dashboards = dashboards;
            this.Datasets = datasets;
            this.Deployments = deployments;
            this.Experiments = experiments;
            this.Projects = projects;
            this.Prompts = prompts;
            this.Queues = queues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggingsByResourceType" /> class.
        /// </summary>
        public TaggingsByResourceType()
        {
        }
    }
}