
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
        [global::System.Text.Json.Serialization.JsonPropertyName("config_id")]
        public global::System.Guid? ConfigId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>))]
        public global::LangSmith.AnyOf<double?, int?, object>? Sample { get; set; }

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
        /// Default Value: openai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.CreateRunClusteringJobRequestModelJsonConverter))]
        public global::LangSmith.CreateRunClusteringJobRequestModel? Model { get; set; }

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
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_scheduled")]
        public bool? IsScheduled { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validate_model_secrets")]
        public bool? ValidateModelSecrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunClusteringJobRequest" /> class.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="lastNHours"></param>
        /// <param name="hierarchy"></param>
        /// <param name="partitions"></param>
        /// <param name="sample"></param>
        /// <param name="summaryPrompt"></param>
        /// <param name="filter"></param>
        /// <param name="name"></param>
        /// <param name="attributeSchemas"></param>
        /// <param name="userContext"></param>
        /// <param name="model">
        /// Default Value: openai
        /// </param>
        /// <param name="clusterModel"></param>
        /// <param name="summaryModel"></param>
        /// <param name="isScheduled">
        /// Default Value: false
        /// </param>
        /// <param name="validateModelSecrets">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRunClusteringJobRequest(
            global::System.Guid? configId,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            int? lastNHours,
            global::System.Collections.Generic.IList<int>? hierarchy,
            global::System.Collections.Generic.Dictionary<string, string>? partitions,
            global::LangSmith.AnyOf<double?, int?, object>? sample,
            string? summaryPrompt,
            string? filter,
            string? name,
            object? attributeSchemas,
            global::System.Collections.Generic.Dictionary<string, string>? userContext,
            global::LangSmith.CreateRunClusteringJobRequestModel? model,
            string? clusterModel,
            string? summaryModel,
            bool? isScheduled,
            bool? validateModelSecrets)
        {
            this.ConfigId = configId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.LastNHours = lastNHours;
            this.Hierarchy = hierarchy;
            this.Partitions = partitions;
            this.Sample = sample;
            this.SummaryPrompt = summaryPrompt;
            this.Filter = filter;
            this.Name = name;
            this.AttributeSchemas = attributeSchemas;
            this.UserContext = userContext;
            this.Model = model;
            this.ClusterModel = clusterModel;
            this.SummaryModel = summaryModel;
            this.IsScheduled = isScheduled;
            this.ValidateModelSecrets = validateModelSecrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunClusteringJobRequest" /> class.
        /// </summary>
        public CreateRunClusteringJobRequest()
        {
        }
    }
}