
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOSettingsUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_workspace_role_id")]
        public global::System.Guid? DefaultWorkspaceRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_workspace_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? DefaultWorkspaceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_url")]
        public string? MetadataUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_xml")]
        public string? MetadataXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_groups_enabled")]
        public bool? SsoGroupsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_groups_claim_field")]
        public string? SsoGroupsClaimField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_groups_required")]
        public bool? SsoGroupsRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_groups_role_sync_enabled")]
        public bool? SsoGroupsRoleSyncEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOSettingsUpdate" /> class.
        /// </summary>
        /// <param name="defaultWorkspaceRoleId"></param>
        /// <param name="defaultWorkspaceIds"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="metadataXml"></param>
        /// <param name="ssoGroupsEnabled"></param>
        /// <param name="ssoGroupsClaimField"></param>
        /// <param name="ssoGroupsRequired"></param>
        /// <param name="ssoGroupsRoleSyncEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSOSettingsUpdate(
            global::System.Guid? defaultWorkspaceRoleId,
            global::System.Collections.Generic.IList<global::System.Guid>? defaultWorkspaceIds,
            string? metadataUrl,
            string? metadataXml,
            bool? ssoGroupsEnabled,
            string? ssoGroupsClaimField,
            bool? ssoGroupsRequired,
            bool? ssoGroupsRoleSyncEnabled)
        {
            this.DefaultWorkspaceRoleId = defaultWorkspaceRoleId;
            this.DefaultWorkspaceIds = defaultWorkspaceIds;
            this.MetadataUrl = metadataUrl;
            this.MetadataXml = metadataXml;
            this.SsoGroupsEnabled = ssoGroupsEnabled;
            this.SsoGroupsClaimField = ssoGroupsClaimField;
            this.SsoGroupsRequired = ssoGroupsRequired;
            this.SsoGroupsRoleSyncEnabled = ssoGroupsRoleSyncEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOSettingsUpdate" /> class.
        /// </summary>
        public SSOSettingsUpdate()
        {
        }
    }
}