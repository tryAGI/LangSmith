
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TracerSessionsAgentVersionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_sha")]
        public string? CommitSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen_at")]
        public string? FirstSeenAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionsAgentVersionResponse" /> class.
        /// </summary>
        /// <param name="commitSha"></param>
        /// <param name="firstSeenAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionsAgentVersionResponse(
            string? commitSha,
            string? firstSeenAt)
        {
            this.CommitSha = commitSha;
            this.FirstSeenAt = firstSeenAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionsAgentVersionResponse" /> class.
        /// </summary>
        public TracerSessionsAgentVersionResponse()
        {
        }
    }
}