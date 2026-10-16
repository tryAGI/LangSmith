
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageAgentUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssistantId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_email")]
        public string? OwnerEmail { get; set; }

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
        /// Initializes a new instance of the <see cref="UsageAgentUsage" /> class.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="firstUsed"></param>
        /// <param name="lastUsed"></param>
        /// <param name="runCount"></param>
        /// <param name="totalCost"></param>
        /// <param name="agentName"></param>
        /// <param name="modelName"></param>
        /// <param name="ownerEmail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageAgentUsage(
            string assistantId,
            global::System.DateTime firstUsed,
            global::System.DateTime lastUsed,
            int runCount,
            double totalCost,
            string? agentName,
            string? modelName,
            string? ownerEmail)
        {
            this.AgentName = agentName;
            this.AssistantId = assistantId ?? throw new global::System.ArgumentNullException(nameof(assistantId));
            this.FirstUsed = firstUsed;
            this.LastUsed = lastUsed;
            this.ModelName = modelName;
            this.OwnerEmail = ownerEmail;
            this.RunCount = runCount;
            this.TotalCost = totalCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAgentUsage" /> class.
        /// </summary>
        public UsageAgentUsage()
        {
        }

    }
}