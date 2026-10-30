
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamsTeam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idp_group_name")]
        public string? IdpGroupName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idp_sync_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IdpSyncEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrganizationId { get; set; }

        /// <summary>
        /// ParentTeamID is the organization-wide team a workspace team belongs to.<br/>
        /// It is omitted for organization-wide teams.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_team_id")]
        public global::System.Guid? ParentTeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// WorkspaceID is the workspace the team belongs to. It is omitted for<br/>
        /// organization-wide teams.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeam" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="idpSyncEnabled"></param>
        /// <param name="name"></param>
        /// <param name="organizationId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="idpGroupName"></param>
        /// <param name="parentTeamId">
        /// ParentTeamID is the organization-wide team a workspace team belongs to.<br/>
        /// It is omitted for organization-wide teams.
        /// </param>
        /// <param name="workspaceId">
        /// WorkspaceID is the workspace the team belongs to. It is omitted for<br/>
        /// organization-wide teams.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsTeam(
            string createdAt,
            string description,
            global::System.Guid id,
            bool idpSyncEnabled,
            string name,
            global::System.Guid organizationId,
            string updatedAt,
            string? idpGroupName,
            global::System.Guid? parentTeamId,
            global::System.Guid? workspaceId)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Id = id;
            this.IdpGroupName = idpGroupName;
            this.IdpSyncEnabled = idpSyncEnabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationId = organizationId;
            this.ParentTeamId = parentTeamId;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeam" /> class.
        /// </summary>
        public TeamsTeam()
        {
        }

    }
}