
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProviderId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_url")]
        public string? MetadataUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_xml")]
        public string? MetadataXml { get; set; }

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
        /// Initializes a new instance of the <see cref="SSOProvider" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organizationId"></param>
        /// <param name="providerId"></param>
        /// <param name="defaultWorkspaceRoleId"></param>
        /// <param name="defaultWorkspaceIds"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="metadataXml"></param>
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
        public SSOProvider(
            global::System.Guid id,
            global::System.Guid organizationId,
            global::System.Guid providerId,
            global::System.Guid defaultWorkspaceRoleId,
            global::System.Collections.Generic.IList<global::System.Guid> defaultWorkspaceIds,
            string? metadataUrl,
            string? metadataXml,
            bool? ssoGroupsEnabled,
            string? ssoGroupsClaimField,
            bool? ssoGroupsRequired,
            bool? ssoGroupsRoleSyncEnabled)
        {
            this.Id = id;
            this.OrganizationId = organizationId;
            this.ProviderId = providerId;
            this.DefaultWorkspaceRoleId = defaultWorkspaceRoleId;
            this.DefaultWorkspaceIds = defaultWorkspaceIds ?? throw new global::System.ArgumentNullException(nameof(defaultWorkspaceIds));
            this.MetadataUrl = metadataUrl;
            this.MetadataXml = metadataXml;
            this.SsoGroupsEnabled = ssoGroupsEnabled;
            this.SsoGroupsClaimField = ssoGroupsClaimField;
            this.SsoGroupsRequired = ssoGroupsRequired;
            this.SsoGroupsRoleSyncEnabled = ssoGroupsRoleSyncEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOProvider" /> class.
        /// </summary>
        public SSOProvider()
        {
        }
    }
}