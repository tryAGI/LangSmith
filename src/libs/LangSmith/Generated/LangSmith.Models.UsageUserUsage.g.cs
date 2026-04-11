
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
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public string? LsUserId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("week_to_date_cost")]
        public double? WeekToDateCost { get; set; }

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
        /// <param name="lsUserId"></param>
        /// <param name="ownerEmail"></param>
        /// <param name="runCount"></param>
        /// <param name="totalCost"></param>
        /// <param name="weekToDateCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageUserUsage(
            int? agentCount,
            string? firstUsed,
            string? lastUsed,
            string? lsUserId,
            string? ownerEmail,
            int? runCount,
            double? totalCost,
            double? weekToDateCost)
        {
            this.AgentCount = agentCount;
            this.FirstUsed = firstUsed;
            this.LastUsed = lastUsed;
            this.LsUserId = lsUserId;
            this.OwnerEmail = ownerEmail;
            this.RunCount = runCount;
            this.TotalCost = totalCost;
            this.WeekToDateCost = weekToDateCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageUserUsage" /> class.
        /// </summary>
        public UsageUserUsage()
        {
        }
    }
}