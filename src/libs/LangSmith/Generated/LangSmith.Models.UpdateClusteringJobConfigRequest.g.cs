
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Request to create a run clustering job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::LangSmith.CreateRunClusteringJobRequest? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_cron")]
        public string? ScheduleCron { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClusteringJobConfigRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config">
        /// Request to create a run clustering job.
        /// </param>
        /// <param name="scheduleCron"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateClusteringJobConfigRequest(
            string? name,
            string? description,
            global::LangSmith.CreateRunClusteringJobRequest? config,
            string? scheduleCron)
        {
            this.Name = name;
            this.Description = description;
            this.Config = config;
            this.ScheduleCron = scheduleCron;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClusteringJobConfigRequest" /> class.
        /// </summary>
        public UpdateClusteringJobConfigRequest()
        {
        }
    }
}