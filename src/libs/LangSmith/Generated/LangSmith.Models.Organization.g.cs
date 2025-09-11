
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Information about an organization.
    /// </summary>
    public sealed partial class Organization
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
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_to_stripe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ConnectedToStripe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_to_metronome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ConnectedToMetronome { get; set; }

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
        /// Stripe customer billing info.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_method")]
        public global::LangSmith.StripePaymentMethodInfo? PaymentMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_cancelled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasCancelled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_of_billing_period")]
        public global::System.DateTime? EndOfBillingPeriod { get; set; }

        /// <summary>
        /// Customer visible plan information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_plan")]
        public global::LangSmith.CustomerVisiblePlanInfo? CurrentPlan { get; set; }

        /// <summary>
        /// Customer visible plan information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upcoming_plan")]
        public global::LangSmith.CustomerVisiblePlanInfo? UpcomingPlan { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplace_payouts_enabled")]
        public bool? MarketplacePayoutsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wallet")]
        public global::LangSmith.Wallet? Wallet { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_sso_provision")]
        public bool? DefaultSsoProvision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="config">
        /// Organization level configuration. May include any field that exists in tenant config and additional fields.
        /// </param>
        /// <param name="connectedToStripe"></param>
        /// <param name="connectedToMetronome"></param>
        /// <param name="isPersonal"></param>
        /// <param name="tier"></param>
        /// <param name="paymentMethod">
        /// Stripe customer billing info.
        /// </param>
        /// <param name="hasCancelled"></param>
        /// <param name="endOfBillingPeriod"></param>
        /// <param name="currentPlan">
        /// Customer visible plan information.
        /// </param>
        /// <param name="upcomingPlan">
        /// Customer visible plan information.
        /// </param>
        /// <param name="reachedMaxWorkspaces">
        /// Default Value: false
        /// </param>
        /// <param name="permissions"></param>
        /// <param name="marketplacePayoutsEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="wallet"></param>
        /// <param name="defaultSsoProvision">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Organization(
            global::LangSmith.OrganizationConfig config,
            bool connectedToStripe,
            bool connectedToMetronome,
            bool isPersonal,
            bool hasCancelled,
            global::System.Guid? id,
            string? displayName,
            global::LangSmith.PaymentPlanTier? tier,
            global::LangSmith.StripePaymentMethodInfo? paymentMethod,
            global::System.DateTime? endOfBillingPeriod,
            global::LangSmith.CustomerVisiblePlanInfo? currentPlan,
            global::LangSmith.CustomerVisiblePlanInfo? upcomingPlan,
            bool? reachedMaxWorkspaces,
            global::System.Collections.Generic.IList<string>? permissions,
            bool? marketplacePayoutsEnabled,
            global::LangSmith.Wallet? wallet,
            bool? defaultSsoProvision)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.ConnectedToStripe = connectedToStripe;
            this.ConnectedToMetronome = connectedToMetronome;
            this.IsPersonal = isPersonal;
            this.HasCancelled = hasCancelled;
            this.Id = id;
            this.DisplayName = displayName;
            this.Tier = tier;
            this.PaymentMethod = paymentMethod;
            this.EndOfBillingPeriod = endOfBillingPeriod;
            this.CurrentPlan = currentPlan;
            this.UpcomingPlan = upcomingPlan;
            this.ReachedMaxWorkspaces = reachedMaxWorkspaces;
            this.Permissions = permissions;
            this.MarketplacePayoutsEnabled = marketplacePayoutsEnabled;
            this.Wallet = wallet;
            this.DefaultSsoProvision = defaultSsoProvision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        public Organization()
        {
        }
    }
}