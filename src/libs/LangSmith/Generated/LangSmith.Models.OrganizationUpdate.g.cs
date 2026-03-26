
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Update organization schema.
    /// </summary>
    public sealed partial class OrganizationUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_sharing_disabled")]
        public bool? PublicSharingDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pat_creation_disabled")]
        public bool? PatCreationDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unshare_all")]
        public bool? UnshareAll { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jit_provisioning_enabled")]
        public bool? JitProvisioningEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_admin_can_invite_to_org")]
        public bool? WorkspaceAdminCanInviteToOrg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invites_enabled")]
        public bool? InvitesEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_api_key_expiry_days")]
        public int? MaxApiKeyExpiryDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_contact")]
        public string? SecurityContact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_pat_expiry_days")]
        public int? MaxPatExpiryDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_service_key_expiry_days")]
        public int? MaxServiceKeyExpiryDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_group_name_separator")]
        public string? ScimGroupNameSeparator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_auth_proxy_enabled")]
        public bool? LlmAuthProxyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_auth_proxy_jwt_audience")]
        public string? LlmAuthProxyJwtAudience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_allowlist")]
        public global::System.Collections.Generic.IList<string>? IpAllowlist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdate" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="publicSharingDisabled"></param>
        /// <param name="patCreationDisabled"></param>
        /// <param name="unshareAll"></param>
        /// <param name="jitProvisioningEnabled"></param>
        /// <param name="workspaceAdminCanInviteToOrg"></param>
        /// <param name="invitesEnabled"></param>
        /// <param name="maxApiKeyExpiryDays"></param>
        /// <param name="securityContact"></param>
        /// <param name="maxPatExpiryDays"></param>
        /// <param name="maxServiceKeyExpiryDays"></param>
        /// <param name="scimGroupNameSeparator"></param>
        /// <param name="llmAuthProxyEnabled"></param>
        /// <param name="llmAuthProxyJwtAudience"></param>
        /// <param name="ipAllowlist"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationUpdate(
            string? displayName,
            bool? publicSharingDisabled,
            bool? patCreationDisabled,
            bool? unshareAll,
            bool? jitProvisioningEnabled,
            bool? workspaceAdminCanInviteToOrg,
            bool? invitesEnabled,
            int? maxApiKeyExpiryDays,
            string? securityContact,
            int? maxPatExpiryDays,
            int? maxServiceKeyExpiryDays,
            string? scimGroupNameSeparator,
            bool? llmAuthProxyEnabled,
            string? llmAuthProxyJwtAudience,
            global::System.Collections.Generic.IList<string>? ipAllowlist)
        {
            this.DisplayName = displayName;
            this.PublicSharingDisabled = publicSharingDisabled;
            this.PatCreationDisabled = patCreationDisabled;
            this.UnshareAll = unshareAll;
            this.JitProvisioningEnabled = jitProvisioningEnabled;
            this.WorkspaceAdminCanInviteToOrg = workspaceAdminCanInviteToOrg;
            this.InvitesEnabled = invitesEnabled;
            this.MaxApiKeyExpiryDays = maxApiKeyExpiryDays;
            this.SecurityContact = securityContact;
            this.MaxPatExpiryDays = maxPatExpiryDays;
            this.MaxServiceKeyExpiryDays = maxServiceKeyExpiryDays;
            this.ScimGroupNameSeparator = scimGroupNameSeparator;
            this.LlmAuthProxyEnabled = llmAuthProxyEnabled;
            this.LlmAuthProxyJwtAudience = llmAuthProxyJwtAudience;
            this.IpAllowlist = ipAllowlist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdate" /> class.
        /// </summary>
        public OrganizationUpdate()
        {
        }
    }
}