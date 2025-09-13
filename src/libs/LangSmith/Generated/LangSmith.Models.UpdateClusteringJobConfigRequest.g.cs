
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request to update a clustering job config.
    /// </summary>
    public sealed partial class UpdateClusteringJobConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Request to create a run clustering job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::LangSmith.CreateRunClusteringJobRequest? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClusteringJobConfigRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="config">
        /// Request to create a run clustering job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateClusteringJobConfigRequest(
            string? name,
            global::LangSmith.CreateRunClusteringJobRequest? config)
        {
            this.Name = name;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClusteringJobConfigRequest" /> class.
        /// </summary>
        public UpdateClusteringJobConfigRequest()
        {
        }
    }
}