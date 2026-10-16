
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageUserUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AgentCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FirstUsed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUsed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public string? LsUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerEmail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageUserUsage" /> class.
        /// </summary>
        /// <param name="agentCount"></param>
        /// <param name="firstUsed"></param>
        /// <param name="lastUsed"></param>
        /// <param name="ownerEmail"></param>
        /// <param name="runCount"></param>
        /// <param name="totalCost"></param>
        /// <param name="lsUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageUserUsage(
            int agentCount,
            global::System.DateTime firstUsed,
            global::System.DateTime lastUsed,
            string ownerEmail,
            int runCount,
            double totalCost,
            string? lsUserId)
        {
            this.AgentCount = agentCount;
            this.FirstUsed = firstUsed;
            this.LastUsed = lastUsed;
            this.LsUserId = lsUserId;
            this.OwnerEmail = ownerEmail ?? throw new global::System.ArgumentNullException(nameof(ownerEmail));
            this.RunCount = runCount;
            this.TotalCost = totalCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageUserUsage" /> class.
        /// </summary>
        public UsageUserUsage()
        {
        }

    }
}