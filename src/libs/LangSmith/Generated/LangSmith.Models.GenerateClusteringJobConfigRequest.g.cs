
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request to auto-generate a clustering job config.
    /// </summary>
    public sealed partial class GenerateClusteringJobConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.Dictionary<string, string> UserContext { get; set; } = default!;

        /// <summary>
        /// Default Value: openai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.GenerateClusteringJobConfigRequestModelJsonConverter))]
        public global::LangSmith.GenerateClusteringJobConfigRequestModel? Model { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateClusteringJobConfigRequest" /> class.
        /// </summary>
        /// <param name="userContext"></param>
        /// <param name="model">
        /// Default Value: openai
        /// </param>
        /// <param name="clusterModel"></param>
        /// <param name="summaryModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateClusteringJobConfigRequest(
            global::System.Collections.Generic.Dictionary<string, string> userContext,
            global::LangSmith.GenerateClusteringJobConfigRequestModel? model,
            string? clusterModel,
            string? summaryModel)
        {
            this.UserContext = userContext ?? throw new global::System.ArgumentNullException(nameof(userContext));
            this.Model = model;
            this.ClusterModel = clusterModel;
            this.SummaryModel = summaryModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateClusteringJobConfigRequest" /> class.
        /// </summary>
        public GenerateClusteringJobConfigRequest()
        {
        }
    }
}