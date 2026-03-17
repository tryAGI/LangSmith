
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Schema for an organization in postgres for list views.
    /// </summary>
    public sealed partial class OrganizationPGSchemaSlim
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
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public global::LangSmith.PaymentPlanTier? Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_user_id")]
        public global::System.Guid? CreatedByUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_ls_user_id")]
        public global::System.Guid? CreatedByLsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPersonal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_login_slug")]
        public string? SsoLoginSlug { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPGSchemaSlim" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="tier"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdByUserId"></param>
        /// <param name="createdByLsUserId"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="isPersonal"></param>
        /// <param name="disabled"></param>
        /// <param name="ssoLoginSlug"></param>
        /// <param name="ssoOnly">
        /// Default Value: false
        /// </param>
        /// <param name="jitProvisioningEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="invitesEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="publicSharingDisabled">
        /// Default Value: false
        /// </param>
        /// <param name="patCreationDisabled">
        /// Default Value: false
        /// </param>
        /// <param name="workspaceAdminCanInviteToOrg">
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
        /// <param name="llmAuthProxyEnabled"></param>
        /// <param name="llmAuthProxyJwtAudience"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationPGSchemaSlim(
            global::System.Guid id,
            string displayName,
            bool isPersonal,
            bool disabled,
            global::LangSmith.PaymentPlanTier? tier,
            global::System.DateTime? createdAt,
            global::System.Guid? createdByUserId,
            global::System.Guid? createdByLsUserId,
            global::System.DateTime? modifiedAt,
            string? ssoLoginSlug,
            bool? ssoOnly,
            bool? jitProvisioningEnabled,
            bool? invitesEnabled,
            bool? publicSharingDisabled,
            bool? patCreationDisabled,
            bool? workspaceAdminCanInviteToOrg,
            bool? defaultSsoProvision,
            int? maxApiKeyExpiryDays,
            string? securityContact,
            int? maxPatExpiryDays,
            int? maxServiceKeyExpiryDays,
            string? scimGroupNameSeparator,
            bool? llmAuthProxyEnabled,
            string? llmAuthProxyJwtAudience)
        {
            this.Id = id;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.IsPersonal = isPersonal;
            this.Disabled = disabled;
            this.Tier = tier;
            this.CreatedAt = createdAt;
            this.CreatedByUserId = createdByUserId;
            this.CreatedByLsUserId = createdByLsUserId;
            this.ModifiedAt = modifiedAt;
            this.SsoLoginSlug = ssoLoginSlug;
            this.SsoOnly = ssoOnly;
            this.JitProvisioningEnabled = jitProvisioningEnabled;
            this.InvitesEnabled = invitesEnabled;
            this.PublicSharingDisabled = publicSharingDisabled;
            this.PatCreationDisabled = patCreationDisabled;
            this.WorkspaceAdminCanInviteToOrg = workspaceAdminCanInviteToOrg;
            this.DefaultSsoProvision = defaultSsoProvision;
            this.MaxApiKeyExpiryDays = maxApiKeyExpiryDays;
            this.SecurityContact = securityContact;
            this.MaxPatExpiryDays = maxPatExpiryDays;
            this.MaxServiceKeyExpiryDays = maxServiceKeyExpiryDays;
            this.ScimGroupNameSeparator = scimGroupNameSeparator;
            this.LlmAuthProxyEnabled = llmAuthProxyEnabled;
            this.LlmAuthProxyJwtAudience = llmAuthProxyJwtAudience;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPGSchemaSlim" /> class.
        /// </summary>
        public OrganizationPGSchemaSlim()
        {
        }
    }
}