
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// An Insights job configuration.
    /// </summary>
    public sealed partial class CreateClusteringJobConfigResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

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
        /// Saved configuration for an Insights job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SavedRunClusteringJobRequest Config { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateClusteringJobConfigResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="config">
        /// Saved configuration for an Insights job.
        /// </param>
        /// <param name="description"></param>
        /// <param name="scheduleCron"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClusteringJobConfigResponse(
            global::System.Guid id,
            string name,
            global::LangSmith.SavedRunClusteringJobRequest config,
            string? description,
            string? scheduleCron)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.ScheduleCron = scheduleCron;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClusteringJobConfigResponse" /> class.
        /// </summary>
        public CreateClusteringJobConfigResponse()
        {
        }

    }
}