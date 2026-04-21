
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOSettingsCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_workspace_role_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DefaultWorkspaceRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_workspace_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> DefaultWorkspaceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_xml")]
        public string? MetadataXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_url")]
        public string? MetadataUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? AttributeMapping { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_groups_enabled")]
        public bool? SsoGroupsEnabled { get; set; }

        /// <summary>
        /// Default Value: groups
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_groups_claim_field")]
        public string? SsoGroupsClaimField { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_groups_required")]
        public bool? SsoGroupsRequired { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_groups_role_sync_enabled")]
        public bool? SsoGroupsRoleSyncEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOSettingsCreate" /> class.
        /// </summary>
        /// <param name="defaultWorkspaceRoleId"></param>
        /// <param name="defaultWorkspaceIds"></param>
        /// <param name="metadataXml"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="attributeMapping"></param>
        /// <param name="ssoGroupsEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="ssoGroupsClaimField">
        /// Default Value: groups
        /// </param>
        /// <param name="ssoGroupsRequired">
        /// Default Value: false
        /// </param>
        /// <param name="ssoGroupsRoleSyncEnabled">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSOSettingsCreate(
            global::System.Guid defaultWorkspaceRoleId,
            global::System.Collections.Generic.IList<global::System.Guid> defaultWorkspaceIds,
            string? metadataXml,
            string? metadataUrl,
            global::System.Collections.Generic.Dictionary<string, string>? attributeMapping,
            bool? ssoGroupsEnabled,
            string? ssoGroupsClaimField,
            bool? ssoGroupsRequired,
            bool? ssoGroupsRoleSyncEnabled)
        {
            this.DefaultWorkspaceRoleId = defaultWorkspaceRoleId;
            this.DefaultWorkspaceIds = defaultWorkspaceIds ?? throw new global::System.ArgumentNullException(nameof(defaultWorkspaceIds));
            this.MetadataXml = metadataXml;
            this.MetadataUrl = metadataUrl;
            this.AttributeMapping = attributeMapping;
            this.SsoGroupsEnabled = ssoGroupsEnabled;
            this.SsoGroupsClaimField = ssoGroupsClaimField;
            this.SsoGroupsRequired = ssoGroupsRequired;
            this.SsoGroupsRoleSyncEnabled = ssoGroupsRoleSyncEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOSettingsCreate" /> class.
        /// </summary>
        public SSOSettingsCreate()
        {
        }
    }
}