
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamsAttachTeamAccessPolicyPayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_policy_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccessPolicyId { get; set; }

        /// <summary>
        /// WorkspaceID limits an organization-wide team's policy to one workspace. Omit it to apply<br/>
        /// the policy in every workspace the team has access to. A workspace team's policy always<br/>
        /// applies in the team's workspace, so this must be omitted or match it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAttachTeamAccessPolicyPayload" /> class.
        /// </summary>
        /// <param name="accessPolicyId"></param>
        /// <param name="workspaceId">
        /// WorkspaceID limits an organization-wide team's policy to one workspace. Omit it to apply<br/>
        /// the policy in every workspace the team has access to. A workspace team's policy always<br/>
        /// applies in the team's workspace, so this must be omitted or match it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsAttachTeamAccessPolicyPayload(
            global::System.Guid accessPolicyId,
            global::System.Guid? workspaceId)
        {
            this.AccessPolicyId = accessPolicyId;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAttachTeamAccessPolicyPayload" /> class.
        /// </summary>
        public TeamsAttachTeamAccessPolicyPayload()
        {
        }

    }
}