
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response to get all cluster jobs for a session.
    /// </summary>
    public sealed partial class GetRunClusteringJobsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clustering_jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.RunClusteringJobPydantic> ClusteringJobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRunClusteringJobsResponse" /> class.
        /// </summary>
        /// <param name="clusteringJobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRunClusteringJobsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.RunClusteringJobPydantic> clusteringJobs)
        {
            this.ClusteringJobs = clusteringJobs ?? throw new global::System.ArgumentNullException(nameof(clusteringJobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRunClusteringJobsResponse" /> class.
        /// </summary>
        public GetRunClusteringJobsResponse()
        {
        }
    }
}