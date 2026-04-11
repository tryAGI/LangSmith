
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageAgentUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::LangSmith.UsageAgentUsage>? Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAgentUsageResponse" /> class.
        /// </summary>
        /// <param name="agents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageAgentUsageResponse(
            global::System.Collections.Generic.IList<global::LangSmith.UsageAgentUsage>? agents)
        {
            this.Agents = agents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAgentUsageResponse" /> class.
        /// </summary>
        public UsageAgentUsageResponse()
        {
        }
    }
}