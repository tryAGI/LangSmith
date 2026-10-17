
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsagePublicUserUsage
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
        [global::System.Text.Json.Serialization.JsonPropertyName("run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunCount { get; set; }

        /// <summary>
        /// Estimated cost in USD from recorded traces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCost { get; set; }

        /// <summary>
        /// Recorded user email used to group usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsagePublicUserUsage" /> class.
        /// </summary>
        /// <param name="agentCount"></param>
        /// <param name="firstUsed"></param>
        /// <param name="lastUsed"></param>
        /// <param name="runCount"></param>
        /// <param name="totalCost">
        /// Estimated cost in USD from recorded traces.
        /// </param>
        /// <param name="userEmail">
        /// Recorded user email used to group usage.
        /// </param>
        /// <param name="lsUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsagePublicUserUsage(
            int agentCount,
            global::System.DateTime firstUsed,
            global::System.DateTime lastUsed,
            int runCount,
            double totalCost,
            string userEmail,
            string? lsUserId)
        {
            this.AgentCount = agentCount;
            this.FirstUsed = firstUsed;
            this.LastUsed = lastUsed;
            this.LsUserId = lsUserId;
            this.RunCount = runCount;
            this.TotalCost = totalCost;
            this.UserEmail = userEmail ?? throw new global::System.ArgumentNullException(nameof(userEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsagePublicUserUsage" /> class.
        /// </summary>
        public UsagePublicUserUsage()
        {
        }

    }
}