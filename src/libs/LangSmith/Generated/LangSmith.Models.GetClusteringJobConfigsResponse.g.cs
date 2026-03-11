
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response to get clustering job configs.
    /// </summary>
    public sealed partial class GetClusteringJobConfigsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.ClusteringJobConfigResponse> Configs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClusteringJobConfigsResponse" /> class.
        /// </summary>
        /// <param name="configs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetClusteringJobConfigsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.ClusteringJobConfigResponse> configs)
        {
            this.Configs = configs ?? throw new global::System.ArgumentNullException(nameof(configs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClusteringJobConfigsResponse" /> class.
        /// </summary>
        public GetClusteringJobConfigsResponse()
        {
        }
    }
}