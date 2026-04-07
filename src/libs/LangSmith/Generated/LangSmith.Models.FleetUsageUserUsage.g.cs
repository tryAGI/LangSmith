
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FleetUsageUserUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_count")]
        public int? AgentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_used")]
        public string? FirstUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used")]
        public string? LastUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_email")]
        public string? OwnerEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_count")]
        public int? RunCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FleetUsageUserUsage" /> class.
        /// </summary>
        /// <param name="agentCount"></param>
        /// <param name="firstUsed"></param>
        /// <param name="lastUsed"></param>
        /// <param name="ownerEmail"></param>
        /// <param name="runCount"></param>
        /// <param name="totalCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FleetUsageUserUsage(
            int? agentCount,
            string? firstUsed,
            string? lastUsed,
            string? ownerEmail,
            int? runCount,
            double? totalCost)
        {
            this.AgentCount = agentCount;
            this.FirstUsed = firstUsed;
            this.LastUsed = lastUsed;
            this.OwnerEmail = ownerEmail;
            this.RunCount = runCount;
            this.TotalCost = totalCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FleetUsageUserUsage" /> class.
        /// </summary>
        public FleetUsageUserUsage()
        {
        }
    }
}