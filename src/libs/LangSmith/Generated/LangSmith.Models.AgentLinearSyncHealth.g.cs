
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentLinearSyncHealth
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_required")]
        public int? AuthRequired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public int? Failed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused")]
        public int? Paused { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        public int? Pending { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synced")]
        public int? Synced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLinearSyncHealth" /> class.
        /// </summary>
        /// <param name="authRequired"></param>
        /// <param name="failed"></param>
        /// <param name="paused"></param>
        /// <param name="pending"></param>
        /// <param name="synced"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentLinearSyncHealth(
            int? authRequired,
            int? failed,
            int? paused,
            int? pending,
            int? synced)
        {
            this.AuthRequired = authRequired;
            this.Failed = failed;
            this.Paused = paused;
            this.Pending = pending;
            this.Synced = synced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLinearSyncHealth" /> class.
        /// </summary>
        public AgentLinearSyncHealth()
        {
        }

    }
}