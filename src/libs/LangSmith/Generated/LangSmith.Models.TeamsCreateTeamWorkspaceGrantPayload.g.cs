
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamsCreateTeamWorkspaceGrantPayload
    {
        /// <summary>
        /// RoleID is a workspace role: a built-in one, or a custom one in this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RoleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsCreateTeamWorkspaceGrantPayload" /> class.
        /// </summary>
        /// <param name="roleId">
        /// RoleID is a workspace role: a built-in one, or a custom one in this organization.
        /// </param>
        /// <param name="workspaceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsCreateTeamWorkspaceGrantPayload(
            global::System.Guid roleId,
            global::System.Guid workspaceId)
        {
            this.RoleId = roleId;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsCreateTeamWorkspaceGrantPayload" /> class.
        /// </summary>
        public TeamsCreateTeamWorkspaceGrantPayload()
        {
        }

    }
}