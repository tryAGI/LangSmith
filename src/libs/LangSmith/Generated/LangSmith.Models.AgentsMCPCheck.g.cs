
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsMCPCheck
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ok")]
        public bool? Ok { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("servers")]
        public global::System.Collections.Generic.IList<global::LangSmith.AgentsMCPServerHealth>? Servers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsMCPCheck" /> class.
        /// </summary>
        /// <param name="ok"></param>
        /// <param name="servers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsMCPCheck(
            bool? ok,
            global::System.Collections.Generic.IList<global::LangSmith.AgentsMCPServerHealth>? servers)
        {
            this.Ok = ok;
            this.Servers = servers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsMCPCheck" /> class.
        /// </summary>
        public AgentsMCPCheck()
        {
        }

    }
}