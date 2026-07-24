
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
        [global::System.Text.Json.Serialization.JsonPropertyName("byoc_create_saas_workspace_enabled")]
        public bool? ByocCreateSaasWorkspaceEnabled { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_model_providers")]
        public global::System.Collections.Generic.IList<string>? DisabledModelProviders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine_enabled")]
        public bool? EngineEnabled { get; set; }

        /// <summary>
        /// EngineLCUSpendLimitMonthly is the org admin (Layer 3) monthly Engine LCU spend<br/>
        /// limit; null means the admin set no limit. The effective enforced limit is the<br/>
        /// minimum of this and the finance/plan limits carried on Config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine_lcu_spend_limit_monthly")]
        public string? EngineLcuSpendLimitMonthly { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_allowlist")]
        public global::System.Collections.Generic.IList<string>? IpAllowlist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_allowlist_enabled")]
        public bool? IpAllowlistEnabled { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_auth_proxy_allowed_urls")]
        public global::System.Collections.Generic.IList<string>? LlmAuthProxyAllowedUrls { get; set; }

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
        /// ManagedEvalTermsAcceptedAt is the raw ISO 8601 timestamp string from the<br/>
        /// config JSONB of when an org admin accepted the managed evaluator terms;<br/>
        /// null if never accepted. Returned verbatim so the value is byte-identical<br/>
        /// to the smith-backend implementation under weighted routing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed_eval_terms_accepted_at")]
        public string? ManagedEvalTermsAcceptedAt { get; set; }

        /// <summary>
        /// ManagedEvalsEnabled is the org-level consent flag for managed evaluators<br/>
        /// (evaluators that spend a LangChain-held provider key).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed_evals_enabled")]
        public bool? ManagedEvalsEnabled { get; set; }

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
        /// <param name="byocCreateSaasWorkspaceEnabled"></param>
        /// <param name="canExportUsageBackfill"></param>
        /// <param name="config"></param>
        /// <param name="defaultSsoProvision"></param>
        /// <param name="disabled"></param>
        /// <param name="disabledModelProviders"></param>
        /// <param name="displayName"></param>
        /// <param name="engineEnabled"></param>
        /// <param name="engineLcuSpendLimitMonthly">
        /// EngineLCUSpendLimitMonthly is the org admin (Layer 3) monthly Engine LCU spend<br/>
        /// limit; null means the admin set no limit. The effective enforced limit is the<br/>
        /// minimum of this and the finance/plan limits carried on Config.
        /// </param>
        /// <param name="id"></param>
        /// <param name="invitesEnabled"></param>
        /// <param name="ipAllowlist"></param>
        /// <param name="ipAllowlistEnabled"></param>
        /// <param name="isPersonal"></param>
        /// <param name="jitProvisioningEnabled"></param>
        /// <param name="llmAuthProxyAllowedUrls"></param>
        /// <param name="llmAuthProxyEnabled"></param>
        /// <param name="llmAuthProxyJwtAudience"></param>
        /// <param name="managedEvalTermsAcceptedAt">
        /// ManagedEvalTermsAcceptedAt is the raw ISO 8601 timestamp string from the<br/>
        /// config JSONB of when an org admin accepted the managed evaluator terms;<br/>
        /// null if never accepted. Returned verbatim so the value is byte-identical<br/>
        /// to the smith-backend implementation under weighted routing.
        /// </param>
        /// <param name="managedEvalsEnabled">
        /// ManagedEvalsEnabled is the org-level consent flag for managed evaluators<br/>
        /// (evaluators that spend a LangChain-held provider key).
        /// </param>
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
            bool? byocCreateSaasWorkspaceEnabled,
            bool? canExportUsageBackfill,
            global::LangSmith.AuthnOrganizationConfig? config,
            bool? defaultSsoProvision,
            bool? disabled,
            global::System.Collections.Generic.IList<string>? disabledModelProviders,
            string? displayName,
            bool? engineEnabled,
            string? engineLcuSpendLimitMonthly,
            string? id,
            bool? invitesEnabled,
            global::System.Collections.Generic.IList<string>? ipAllowlist,
            bool? ipAllowlistEnabled,
            bool? isPersonal,
            bool? jitProvisioningEnabled,
            global::System.Collections.Generic.IList<string>? llmAuthProxyAllowedUrls,
            bool? llmAuthProxyEnabled,
            string? llmAuthProxyJwtAudience,
            string? managedEvalTermsAcceptedAt,
            bool? managedEvalsEnabled,
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
            this.ByocCreateSaasWorkspaceEnabled = byocCreateSaasWorkspaceEnabled;
            this.CanExportUsageBackfill = canExportUsageBackfill;
            this.Config = config;
            this.DefaultSsoProvision = defaultSsoProvision;
            this.Disabled = disabled;
            this.DisabledModelProviders = disabledModelProviders;
            this.DisplayName = displayName;
            this.EngineEnabled = engineEnabled;
            this.EngineLcuSpendLimitMonthly = engineLcuSpendLimitMonthly;
            this.Id = id;
            this.InvitesEnabled = invitesEnabled;
            this.IpAllowlist = ipAllowlist;
            this.IpAllowlistEnabled = ipAllowlistEnabled;
            this.IsPersonal = isPersonal;
            this.JitProvisioningEnabled = jitProvisioningEnabled;
            this.LlmAuthProxyAllowedUrls = llmAuthProxyAllowedUrls;
            this.LlmAuthProxyEnabled = llmAuthProxyEnabled;
            this.LlmAuthProxyJwtAudience = llmAuthProxyJwtAudience;
            this.ManagedEvalTermsAcceptedAt = managedEvalTermsAcceptedAt;
            this.ManagedEvalsEnabled = managedEvalsEnabled;
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