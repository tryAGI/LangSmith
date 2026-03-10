
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsOrganizationInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_export_usage_backfill")]
        public bool? CanExportUsageBackfill { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::LangSmith.AuthnOrganizationConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_sso_provision")]
        public bool? DefaultSsoProvision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invites_enabled")]
        public bool? InvitesEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        public bool? IsPersonal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jit_provisioning_enabled")]
        public bool? JitProvisioningEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplace_payouts_enabled")]
        public bool? MarketplacePayoutsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_api_key_expiry_days")]
        public int? MaxApiKeyExpiryDays { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("member_disabled")]
        public bool? MemberDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pat_creation_disabled")]
        public bool? PatCreationDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_sharing_disabled")]
        public bool? PublicSharingDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reached_max_workspaces")]
        public bool? ReachedMaxWorkspaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_group_name_separator")]
        public string? ScimGroupNameSeparator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_contact")]
        public string? SecurityContact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_login_slug")]
        public string? SsoLoginSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_only")]
        public bool? SsoOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_admin_can_invite_to_org")]
        public bool? WorkspaceAdminCanInviteToOrg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsOrganizationInfo" /> class.
        /// </summary>
        /// <param name="canExportUsageBackfill"></param>
        /// <param name="config"></param>
        /// <param name="defaultSsoProvision"></param>
        /// <param name="disabled"></param>
        /// <param name="displayName"></param>
        /// <param name="id"></param>
        /// <param name="invitesEnabled"></param>
        /// <param name="isPersonal"></param>
        /// <param name="jitProvisioningEnabled"></param>
        /// <param name="marketplacePayoutsEnabled"></param>
        /// <param name="maxApiKeyExpiryDays"></param>
        /// <param name="maxPatExpiryDays"></param>
        /// <param name="maxServiceKeyExpiryDays"></param>
        /// <param name="memberDisabled"></param>
        /// <param name="patCreationDisabled"></param>
        /// <param name="permissions"></param>
        /// <param name="publicSharingDisabled"></param>
        /// <param name="reachedMaxWorkspaces"></param>
        /// <param name="scimGroupNameSeparator"></param>
        /// <param name="securityContact"></param>
        /// <param name="ssoLoginSlug"></param>
        /// <param name="ssoOnly"></param>
        /// <param name="tier"></param>
        /// <param name="workspaceAdminCanInviteToOrg"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsOrganizationInfo(
            bool? canExportUsageBackfill,
            global::LangSmith.AuthnOrganizationConfig? config,
            bool? defaultSsoProvision,
            bool? disabled,
            string? displayName,
            string? id,
            bool? invitesEnabled,
            bool? isPersonal,
            bool? jitProvisioningEnabled,
            bool? marketplacePayoutsEnabled,
            int? maxApiKeyExpiryDays,
            int? maxPatExpiryDays,
            int? maxServiceKeyExpiryDays,
            bool? memberDisabled,
            bool? patCreationDisabled,
            global::System.Collections.Generic.IList<string>? permissions,
            bool? publicSharingDisabled,
            bool? reachedMaxWorkspaces,
            string? scimGroupNameSeparator,
            string? securityContact,
            string? ssoLoginSlug,
            bool? ssoOnly,
            string? tier,
            bool? workspaceAdminCanInviteToOrg)
        {
            this.CanExportUsageBackfill = canExportUsageBackfill;
            this.Config = config;
            this.DefaultSsoProvision = defaultSsoProvision;
            this.Disabled = disabled;
            this.DisplayName = displayName;
            this.Id = id;
            this.InvitesEnabled = invitesEnabled;
            this.IsPersonal = isPersonal;
            this.JitProvisioningEnabled = jitProvisioningEnabled;
            this.MarketplacePayoutsEnabled = marketplacePayoutsEnabled;
            this.MaxApiKeyExpiryDays = maxApiKeyExpiryDays;
            this.MaxPatExpiryDays = maxPatExpiryDays;
            this.MaxServiceKeyExpiryDays = maxServiceKeyExpiryDays;
            this.MemberDisabled = memberDisabled;
            this.PatCreationDisabled = patCreationDisabled;
            this.Permissions = permissions;
            this.PublicSharingDisabled = publicSharingDisabled;
            this.ReachedMaxWorkspaces = reachedMaxWorkspaces;
            this.ScimGroupNameSeparator = scimGroupNameSeparator;
            this.SecurityContact = securityContact;
            this.SsoLoginSlug = ssoLoginSlug;
            this.SsoOnly = ssoOnly;
            this.Tier = tier;
            this.WorkspaceAdminCanInviteToOrg = workspaceAdminCanInviteToOrg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsOrganizationInfo" /> class.
        /// </summary>
        public OrgsOrganizationInfo()
        {
        }
    }
}