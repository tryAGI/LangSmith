
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request to create a run clustering job.
    /// </summary>
    public sealed partial class SavedRunClusteringJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_n_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastNHours { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<double?, int?, object> Sample { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_schemas")]
        public object? AttributeSchemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_context")]
        public global::System.Collections.Generic.Dictionary<string, string>? UserContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SavedRunClusteringJobRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SavedRunClusteringJobRequestModel Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_model")]
        public string? ClusterModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_model")]
        public string? SummaryModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedRunClusteringJobRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastNHours"></param>
        /// <param name="hierarchy"></param>
        /// <param name="partitions"></param>
        /// <param name="sample"></param>
        /// <param name="summaryPrompt"></param>
        /// <param name="filter"></param>
        /// <param name="attributeSchemas"></param>
        /// <param name="userContext"></param>
        /// <param name="model"></param>
        /// <param name="clusterModel"></param>
        /// <param name="summaryModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SavedRunClusteringJobRequest(
            int lastNHours,
            global::LangSmith.AnyOf<double?, int?, object> sample,
            global::LangSmith.SavedRunClusteringJobRequestModel model,
            string? name,
            global::System.Collections.Generic.IList<int>? hierarchy,
            global::System.Collections.Generic.Dictionary<string, string>? partitions,
            string? summaryPrompt,
            string? filter,
            object? attributeSchemas,
            global::System.Collections.Generic.Dictionary<string, string>? userContext,
            string? clusterModel,
            string? summaryModel)
        {
            this.LastNHours = lastNHours;
            this.Sample = sample;
            this.Model = model;
            this.Name = name;
            this.Hierarchy = hierarchy;
            this.Partitions = partitions;
            this.SummaryPrompt = summaryPrompt;
            this.Filter = filter;
            this.AttributeSchemas = attributeSchemas;
            this.UserContext = userContext;
            this.ClusterModel = clusterModel;
            this.SummaryModel = summaryModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedRunClusteringJobRequest" /> class.
        /// </summary>
        public SavedRunClusteringJobRequest()
        {
        }
    }
}