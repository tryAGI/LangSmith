
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsagePublicAgentUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsagePublicAgentUsage" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="firstUsed"></param>
        /// <param name="lastUsed"></param>
        /// <param name="runCount"></param>
        /// <param name="totalCost">
        /// Estimated cost in USD from recorded traces.
        /// </param>
        /// <param name="agentName"></param>
        /// <param name="modelName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsagePublicAgentUsage(
            string agentId,
            global::System.DateTime firstUsed,
            global::System.DateTime lastUsed,
            int runCount,
            double totalCost,
            string? agentName,
            string? modelName)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName;
            this.FirstUsed = firstUsed;
            this.LastUsed = lastUsed;
            this.ModelName = modelName;
            this.RunCount = runCount;
            this.TotalCost = totalCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsagePublicAgentUsage" /> class.
        /// </summary>
        public UsagePublicAgentUsage()
        {
        }

    }
}