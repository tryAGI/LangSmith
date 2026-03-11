
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Information about an organization.<br/>
    /// IMPORTANT: Keep in sync with Go OrganizationInfo in smith-go/orgs/handler.go<br/>
    /// while both implementations are in use (weighted routing rollout).
    /// </summary>
    public sealed partial class OrganizationInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Organization level configuration. May include any field that exists in tenant config and additional fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.OrganizationConfig Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool IsPersonal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public global::LangSmith.PaymentPlanTier? Tier { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reached_max_workspaces")]
        public bool? ReachedMaxWorkspaces { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_disabled")]
        public bool? MemberDisabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_only")]
        public bool? SsoOnly { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jit_provisioning_enabled")]
        public bool? JitProvisioningEnabled { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invites_enabled")]
        public bool? InvitesEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_login_slug")]
        public string? SsoLoginSlug { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_sharing_disabled")]
        public bool? PublicSharingDisabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pat_creation_disabled")]
        public bool? PatCreationDisabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_admin_can_invite_to_org")]
        public bool? WorkspaceAdminCanInviteToOrg { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplace_payouts_enabled")]
        public bool? MarketplacePayoutsEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_sso_provision")]
        public bool? DefaultSsoProvision { get; set; }

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
        /// Default Value: :
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_group_name_separator")]
        public string? ScimGroupNameSeparator { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_export_usage_backfill")]
        public bool? CanExportUsageBackfill { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInfo" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="config">
        /// Organization level configuration. May include any field that exists in tenant config and additional fields.
        /// </param>
        /// <param name="isPersonal"></param>
        /// <param name="tier"></param>
        /// <param name="reachedMaxWorkspaces">
        /// Default Value: false
        /// </param>
        /// <param name="permissions">
        /// Default Value: []
        /// </param>
        /// <param name="disabled">
        /// Default Value: false
        /// </param>
        /// <param name="memberDisabled">
        /// Default Value: false
        /// </param>
        /// <param name="ssoOnly">
        /// Default Value: false
        /// </param>
        /// <param name="jitProvisioningEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="invitesEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="ssoLoginSlug"></param>
        /// <param name="publicSharingDisabled">
        /// Default Value: false
        /// </param>
        /// <param name="patCreationDisabled">
        /// Default Value: false
        /// </param>
        /// <param name="workspaceAdminCanInviteToOrg">
        /// Default Value: false
        /// </param>
        /// <param name="marketplacePayoutsEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="defaultSsoProvision">
        /// Default Value: false
        /// </param>
        /// <param name="maxApiKeyExpiryDays"></param>
        /// <param name="securityContact"></param>
        /// <param name="maxPatExpiryDays"></param>
        /// <param name="maxServiceKeyExpiryDays"></param>
        /// <param name="scimGroupNameSeparator">
        /// Default Value: :
        /// </param>
        /// <param name="canExportUsageBackfill">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationInfo(
            global::LangSmith.OrganizationConfig config,
            bool isPersonal,
            global::System.Guid? id,
            string? displayName,
            global::LangSmith.PaymentPlanTier? tier,
            bool? reachedMaxWorkspaces,
            global::System.Collections.Generic.IList<string>? permissions,
            bool? disabled,
            bool? memberDisabled,
            bool? ssoOnly,
            bool? jitProvisioningEnabled,
            bool? invitesEnabled,
            string? ssoLoginSlug,
            bool? publicSharingDisabled,
            bool? patCreationDisabled,
            bool? workspaceAdminCanInviteToOrg,
            bool? marketplacePayoutsEnabled,
            bool? defaultSsoProvision,
            int? maxApiKeyExpiryDays,
            string? securityContact,
            int? maxPatExpiryDays,
            int? maxServiceKeyExpiryDays,
            string? scimGroupNameSeparator,
            bool? canExportUsageBackfill)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.IsPersonal = isPersonal;
            this.Id = id;
            this.DisplayName = displayName;
            this.Tier = tier;
            this.ReachedMaxWorkspaces = reachedMaxWorkspaces;
            this.Permissions = permissions;
            this.Disabled = disabled;
            this.MemberDisabled = memberDisabled;
            this.SsoOnly = ssoOnly;
            this.JitProvisioningEnabled = jitProvisioningEnabled;
            this.InvitesEnabled = invitesEnabled;
            this.SsoLoginSlug = ssoLoginSlug;
            this.PublicSharingDisabled = publicSharingDisabled;
            this.PatCreationDisabled = patCreationDisabled;
            this.WorkspaceAdminCanInviteToOrg = workspaceAdminCanInviteToOrg;
            this.MarketplacePayoutsEnabled = marketplacePayoutsEnabled;
            this.DefaultSsoProvision = defaultSsoProvision;
            this.MaxApiKeyExpiryDays = maxApiKeyExpiryDays;
            this.SecurityContact = securityContact;
            this.MaxPatExpiryDays = maxPatExpiryDays;
            this.MaxServiceKeyExpiryDays = maxServiceKeyExpiryDays;
            this.ScimGroupNameSeparator = scimGroupNameSeparator;
            this.CanExportUsageBackfill = canExportUsageBackfill;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInfo" /> class.
        /// </summary>
        public OrganizationInfo()
        {
        }
    }
}