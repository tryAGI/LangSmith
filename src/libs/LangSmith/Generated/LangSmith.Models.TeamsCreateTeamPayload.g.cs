
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamsCreateTeamPayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_team_id")]
        public global::System.Guid? ParentTeamId { get; set; }

        /// <summary>
        /// Rejected with 400, so a request for a workspace team does not create an<br/>
        /// organization-wide team. Granting a team a workspace creates its workspace team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsCreateTeamPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="parentTeamId"></param>
        /// <param name="workspaceId">
        /// Rejected with 400, so a request for a workspace team does not create an<br/>
        /// organization-wide team. Granting a team a workspace creates its workspace team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsCreateTeamPayload(
            string name,
            string? description,
            global::System.Guid? parentTeamId,
            global::System.Guid? workspaceId)
        {
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParentTeamId = parentTeamId;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsCreateTeamPayload" /> class.
        /// </summary>
        public TeamsCreateTeamPayload()
        {
        }

    }
}