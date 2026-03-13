
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ForgeConfigurationsForgeConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_cron")]
        public string? ScheduleCron { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracer_session_id")]
        public string? TracerSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgeConfigurationsForgeConfiguration" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="enabled"></param>
        /// <param name="gitCommitMetadataKey"></param>
        /// <param name="id"></param>
        /// <param name="scheduleCron"></param>
        /// <param name="sessionName"></param>
        /// <param name="tenantId"></param>
        /// <param name="tracerSessionId"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForgeConfigurationsForgeConfiguration(
            string? createdAt,
            bool? enabled,
            string? gitCommitMetadataKey,
            string? id,
            string? scheduleCron,
            string? sessionName,
            string? tenantId,
            string? tracerSessionId,
            string? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.Enabled = enabled;
            this.GitCommitMetadataKey = gitCommitMetadataKey;
            this.Id = id;
            this.ScheduleCron = scheduleCron;
            this.SessionName = sessionName;
            this.TenantId = tenantId;
            this.TracerSessionId = tracerSessionId;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgeConfigurationsForgeConfiguration" /> class.
        /// </summary>
        public ForgeConfigurationsForgeConfiguration()
        {
        }
    }
}