
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Full clustering job config with all details.
    /// </summary>
    public sealed partial class ClusteringJobConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<global::System.Guid?, string> Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Request to create a run clustering job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SavedRunClusteringJobRequest Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prebuilt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Prebuilt { get; set; }

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
        /// Initializes a new instance of the <see cref="ClusteringJobConfigResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="config">
        /// Request to create a run clustering job.
        /// </param>
        /// <param name="prebuilt"></param>
        /// <param name="description"></param>
        /// <param name="scheduleCron"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusteringJobConfigResponse(
            global::LangSmith.AnyOf<global::System.Guid?, string> id,
            string name,
            global::LangSmith.SavedRunClusteringJobRequest config,
            bool prebuilt,
            string? description,
            string? scheduleCron)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Prebuilt = prebuilt;
            this.ScheduleCron = scheduleCron;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusteringJobConfigResponse" /> class.
        /// </summary>
        public ClusteringJobConfigResponse()
        {
        }
    }
}