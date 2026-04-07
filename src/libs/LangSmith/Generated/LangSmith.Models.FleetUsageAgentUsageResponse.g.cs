
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FleetUsageAgentUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::LangSmith.FleetUsageAgentUsage>? Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FleetUsageAgentUsageResponse" /> class.
        /// </summary>
        /// <param name="agents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FleetUsageAgentUsageResponse(
            global::System.Collections.Generic.IList<global::LangSmith.FleetUsageAgentUsage>? agents)
        {
            this.Agents = agents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FleetUsageAgentUsageResponse" /> class.
        /// </summary>
        public FleetUsageAgentUsageResponse()
        {
        }
    }
}