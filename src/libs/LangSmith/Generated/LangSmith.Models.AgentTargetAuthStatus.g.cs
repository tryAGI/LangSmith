
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTargetAuthStatus
    {
        /// <summary>
        /// True when a credential is stored but cannot be read back, so the UI can<br/>
        /// offer to replace it instead of showing an unconfigured board.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_unreadable_credentials")]
        public bool? HasUnreadableCredentials { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_names")]
        public global::System.Collections.Generic.IList<string>? HeaderNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTargetAuthStatus" /> class.
        /// </summary>
        /// <param name="hasUnreadableCredentials">
        /// True when a credential is stored but cannot be read back, so the UI can<br/>
        /// offer to replace it instead of showing an unconfigured board.
        /// </param>
        /// <param name="headerNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTargetAuthStatus(
            bool? hasUnreadableCredentials,
            global::System.Collections.Generic.IList<string>? headerNames)
        {
            this.HasUnreadableCredentials = hasUnreadableCredentials;
            this.HeaderNames = headerNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTargetAuthStatus" /> class.
        /// </summary>
        public AgentTargetAuthStatus()
        {
        }

    }
}