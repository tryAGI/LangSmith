
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentRedTeamTargetView
    {
        /// <summary>
        /// Auth describes the headers sent to this endpoint, and only to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::LangSmith.AgentTargetAuthStatus? Auth { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRedTeamTargetView" /> class.
        /// </summary>
        /// <param name="auth">
        /// Auth describes the headers sent to this endpoint, and only to it.
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRedTeamTargetView(
            global::LangSmith.AgentTargetAuthStatus? auth,
            string? url)
        {
            this.Auth = auth;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRedTeamTargetView" /> class.
        /// </summary>
        public AgentRedTeamTargetView()
        {
        }

    }
}