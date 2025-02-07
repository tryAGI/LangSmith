
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Information about an organization.
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
        public required global::LangSmith.OrganizationConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPersonal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.PaymentPlanTierJsonConverter))]
        public global::LangSmith.PaymentPlanTier? Tier { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reached_max_workspaces")]
        public bool? ReachedMaxWorkspaces { get; set; }

        /// <summary>
        /// 
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
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_only")]
        public bool? SsoOnly { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplace_payouts_enabled")]
        public bool? MarketplacePayoutsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wallet")]
        public global::LangSmith.Wallet? Wallet { get; set; }

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
        /// <param name="permissions"></param>
        /// <param name="disabled">
        /// Default Value: false
        /// </param>
        /// <param name="ssoOnly">
        /// Default Value: false
        /// </param>
        /// <param name="ssoLoginSlug"></param>
        /// <param name="publicSharingDisabled">
        /// Default Value: false
        /// </param>
        /// <param name="marketplacePayoutsEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="wallet"></param>
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
            bool? ssoOnly,
            string? ssoLoginSlug,
            bool? publicSharingDisabled,
            bool? marketplacePayoutsEnabled,
            global::LangSmith.Wallet? wallet)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.IsPersonal = isPersonal;
            this.Id = id;
            this.DisplayName = displayName;
            this.Tier = tier;
            this.ReachedMaxWorkspaces = reachedMaxWorkspaces;
            this.Permissions = permissions;
            this.Disabled = disabled;
            this.SsoOnly = ssoOnly;
            this.SsoLoginSlug = ssoLoginSlug;
            this.PublicSharingDisabled = publicSharingDisabled;
            this.MarketplacePayoutsEnabled = marketplacePayoutsEnabled;
            this.Wallet = wallet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInfo" /> class.
        /// </summary>
        public OrganizationInfo()
        {
        }
    }
}