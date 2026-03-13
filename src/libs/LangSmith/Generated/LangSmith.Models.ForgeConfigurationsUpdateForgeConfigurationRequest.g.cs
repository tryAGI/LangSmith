
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ForgeConfigurationsUpdateForgeConfigurationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_commit_metadata_key")]
        public string? GitCommitMetadataKey { get; set; }

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
        /// Initializes a new instance of the <see cref="ForgeConfigurationsUpdateForgeConfigurationRequest" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="gitCommitMetadataKey"></param>
        /// <param name="scheduleCron"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForgeConfigurationsUpdateForgeConfigurationRequest(
            bool? enabled,
            string? gitCommitMetadataKey,
            string? scheduleCron)
        {
            this.Enabled = enabled;
            this.GitCommitMetadataKey = gitCommitMetadataKey;
            this.ScheduleCron = scheduleCron;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgeConfigurationsUpdateForgeConfigurationRequest" /> class.
        /// </summary>
        public ForgeConfigurationsUpdateForgeConfigurationRequest()
        {
        }
    }
}