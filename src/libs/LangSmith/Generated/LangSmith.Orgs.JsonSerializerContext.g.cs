
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIKeyCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIKeyCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AccessScope), TypeInfoPropertyName = "AccessScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIKeyGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIKeyUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllowedLoginMethodsUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TraceTier), TypeInfoPropertyName = "TraceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthProvider), TypeInfoPropertyName = "AuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BasicAuthMemberCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BasicAuthUserPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChangePaymentPlanReq), TypeInfoPropertyName = "ChangePaymentPlanReq2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChangePaymentPlanSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ConfiguredBy), TypeInfoPropertyName = "ConfiguredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomerVisiblePlanInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PaymentPlanTier), TypeInfoPropertyName = "PaymentPlanTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageGroupBy), TypeInfoPropertyName = "GranularUsageGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageKind), TypeInfoPropertyName = "GranularUsageKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageStride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GranularUsageRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Identity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProviderUserSlim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.MemberSortField), TypeInfoPropertyName = "MemberSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgIdentityPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgMemberIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgPendingIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripePaymentMethodInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationBillingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlusPlanTransitionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardColorScheme), TypeInfoPropertyName = "OrganizationDashboardColorScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardType), TypeInfoPropertyName = "OrganizationDashboardType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationRoles), TypeInfoPropertyName = "OrganizationRoles2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgMemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationPGSchemaSlim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, string, object>), TypeInfoPropertyName = "AnyOfDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingIdentityCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingIdentityPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PermissionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProblemDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProvisioningMethod), TypeInfoPropertyName = "ProvisioningMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RoleRestrictionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SupabaseAttributeMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOSettingsCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOSettingsUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeAccountLinksCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeBusinessBillingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeCustomerAddress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeBusinessInfoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeTaxId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeBusinessInfoOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeCheckoutSessionsCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeCustomerBillingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripePaymentInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeSetupIntentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.SupabaseAttributeMappingKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SupabaseAttributeMappingKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TTLSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpsertTTLSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UserWithPassword))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsLinkedLoginMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsOrgMemberEnriched))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsLinkedLoginMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsSCIMGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsSCIMGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsWorkspaceMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsWorkspaceMembership))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PermissionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AccessScope?), TypeInfoPropertyName = "NullableAccessScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TraceTier?), TypeInfoPropertyName = "NullableTraceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthProvider?), TypeInfoPropertyName = "NullableAuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChangePaymentPlanReq?), TypeInfoPropertyName = "NullableChangePaymentPlanReq2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ConfiguredBy?), TypeInfoPropertyName = "NullableConfiguredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PaymentPlanTier?), TypeInfoPropertyName = "NullablePaymentPlanTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageGroupBy?), TypeInfoPropertyName = "NullableGranularUsageGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageKind?), TypeInfoPropertyName = "NullableGranularUsageKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.MemberSortField?), TypeInfoPropertyName = "NullableMemberSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardColorScheme?), TypeInfoPropertyName = "NullableOrganizationDashboardColorScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardType?), TypeInfoPropertyName = "NullableOrganizationDashboardType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationRoles?), TypeInfoPropertyName = "NullableOrganizationRoles2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, string, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProvisioningMethod?), TypeInfoPropertyName = "NullableProvisioningMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GranularUsageRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ProviderUserSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgMemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgPendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsLinkedLoginMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsSCIMGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsWorkspaceMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PendingIdentityCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BasicAuthMemberCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TTLSettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrganizationPGSchemaSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PermissionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.UserWithPassword>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SSOProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.APIKeyGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsOrgMemberEnriched>))]
    internal sealed partial class OrgsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OrgsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OrgsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, double?, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?, double?>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::LangSmith.AccessScope)

                    || typeToConvert == typeof(global::LangSmith.AccessScope?)

                    || typeToConvert == typeof(global::LangSmith.AuthProvider)

                    || typeToConvert == typeof(global::LangSmith.AuthProvider?)

                    || typeToConvert == typeof(global::LangSmith.ChangePaymentPlanReq)

                    || typeToConvert == typeof(global::LangSmith.ChangePaymentPlanReq?)

                    || typeToConvert == typeof(global::LangSmith.ConfiguredBy)

                    || typeToConvert == typeof(global::LangSmith.ConfiguredBy?)

                    || typeToConvert == typeof(global::LangSmith.GranularUsageGroupBy)

                    || typeToConvert == typeof(global::LangSmith.GranularUsageGroupBy?)

                    || typeToConvert == typeof(global::LangSmith.GranularUsageKind)

                    || typeToConvert == typeof(global::LangSmith.GranularUsageKind?)

                    || typeToConvert == typeof(global::LangSmith.MemberSortField)

                    || typeToConvert == typeof(global::LangSmith.MemberSortField?)

                    || typeToConvert == typeof(global::LangSmith.OrganizationDashboardColorScheme)

                    || typeToConvert == typeof(global::LangSmith.OrganizationDashboardColorScheme?)

                    || typeToConvert == typeof(global::LangSmith.OrganizationDashboardType)

                    || typeToConvert == typeof(global::LangSmith.OrganizationDashboardType?)

                    || typeToConvert == typeof(global::LangSmith.OrganizationRoles)

                    || typeToConvert == typeof(global::LangSmith.OrganizationRoles?)

                    || typeToConvert == typeof(global::LangSmith.PaymentPlanTier)

                    || typeToConvert == typeof(global::LangSmith.PaymentPlanTier?)

                    || typeToConvert == typeof(global::LangSmith.ProvisioningMethod)

                    || typeToConvert == typeof(global::LangSmith.ProvisioningMethod?)

                    || typeToConvert == typeof(global::LangSmith.TraceTier)

                    || typeToConvert == typeof(global::LangSmith.TraceTier?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.AccessScope))
                {
                    return new global::LangSmith.JsonConverters.AccessScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AccessScope?))
                {
                    return new global::LangSmith.JsonConverters.AccessScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuthProvider))
                {
                    return new global::LangSmith.JsonConverters.AuthProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuthProvider?))
                {
                    return new global::LangSmith.JsonConverters.AuthProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ChangePaymentPlanReq))
                {
                    return new global::LangSmith.JsonConverters.ChangePaymentPlanReqJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ChangePaymentPlanReq?))
                {
                    return new global::LangSmith.JsonConverters.ChangePaymentPlanReqNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ConfiguredBy))
                {
                    return new global::LangSmith.JsonConverters.ConfiguredByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ConfiguredBy?))
                {
                    return new global::LangSmith.JsonConverters.ConfiguredByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GranularUsageGroupBy))
                {
                    return new global::LangSmith.JsonConverters.GranularUsageGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GranularUsageGroupBy?))
                {
                    return new global::LangSmith.JsonConverters.GranularUsageGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GranularUsageKind))
                {
                    return new global::LangSmith.JsonConverters.GranularUsageKindJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GranularUsageKind?))
                {
                    return new global::LangSmith.JsonConverters.GranularUsageKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.MemberSortField))
                {
                    return new global::LangSmith.JsonConverters.MemberSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.MemberSortField?))
                {
                    return new global::LangSmith.JsonConverters.MemberSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OrganizationDashboardColorScheme))
                {
                    return new global::LangSmith.JsonConverters.OrganizationDashboardColorSchemeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OrganizationDashboardColorScheme?))
                {
                    return new global::LangSmith.JsonConverters.OrganizationDashboardColorSchemeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OrganizationDashboardType))
                {
                    return new global::LangSmith.JsonConverters.OrganizationDashboardTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OrganizationDashboardType?))
                {
                    return new global::LangSmith.JsonConverters.OrganizationDashboardTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OrganizationRoles))
                {
                    return new global::LangSmith.JsonConverters.OrganizationRolesJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OrganizationRoles?))
                {
                    return new global::LangSmith.JsonConverters.OrganizationRolesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PaymentPlanTier))
                {
                    return new global::LangSmith.JsonConverters.PaymentPlanTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PaymentPlanTier?))
                {
                    return new global::LangSmith.JsonConverters.PaymentPlanTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ProvisioningMethod))
                {
                    return new global::LangSmith.JsonConverters.ProvisioningMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ProvisioningMethod?))
                {
                    return new global::LangSmith.JsonConverters.ProvisioningMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TraceTier))
                {
                    return new global::LangSmith.JsonConverters.TraceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TraceTier?))
                {
                    return new global::LangSmith.JsonConverters.TraceTierNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new OrgsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}