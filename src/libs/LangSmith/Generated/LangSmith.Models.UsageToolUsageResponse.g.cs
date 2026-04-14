
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageToolUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::LangSmith.UsageToolUsage>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageToolUsageResponse" /> class.
        /// </summary>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageToolUsageResponse(
            global::System.Collections.Generic.IList<global::LangSmith.UsageToolUsage>? tools)
        {
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageToolUsageResponse" /> class.
        /// </summary>
        public UsageToolUsageResponse()
        {
        }
    }
}