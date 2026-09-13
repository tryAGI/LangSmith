
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AccessScope), TypeInfoPropertyName = "AccessScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthProvider), TypeInfoPropertyName = "AuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Identity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IdentityCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IdentityPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InternalSecretsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListTagsForResourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResourceType), TypeInfoPropertyName = "ResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.MemberIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProviderUserSlim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.MemberSortField), TypeInfoPropertyName = "MemberSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingIdentityCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingIdentityPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProvisioningMethod), TypeInfoPropertyName = "ProvisioningMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Resource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SecretKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SecretUpsert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyWithValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyWithValuesAndTaggings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagValueWithTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValueWithTaggings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValueCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValueUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Tagging>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Tagging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TaggingCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TaggingsByResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Resource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TaggingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantBulkUnshareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantForUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareDatasetToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareRunToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareThreadToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EntitiesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EntitiesItem), TypeInfoPropertyName = "EntitiesItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType), TypeInfoPropertyName = "TenantShareTokensResponseEntitieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantUsageLimitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantUsageLimitType), TypeInfoPropertyName = "TenantUsageLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.WorkspaceCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.WorkspaceInviteResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.WorkspacePatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AppSchemasTenant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SecretUpsert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ListTagsForResourceRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService), TypeInfoPropertyName = "GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SecretKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AppSchemasTenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.WorkspaceInviteResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AccessScope?), TypeInfoPropertyName = "NullableAccessScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthProvider?), TypeInfoPropertyName = "NullableAuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResourceType?), TypeInfoPropertyName = "NullableResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.MemberSortField?), TypeInfoPropertyName = "NullableMemberSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProvisioningMethod?), TypeInfoPropertyName = "NullableProvisioningMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EntitiesItem?), TypeInfoPropertyName = "NullableEntitiesItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType?), TypeInfoPropertyName = "NullableTenantShareTokensResponseEntitieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantUsageLimitType?), TypeInfoPropertyName = "NullableTenantUsageLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService?), TypeInfoPropertyName = "NullableGetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ProviderUserSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagValueWithTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Tagging>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Resource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.MemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EntitiesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SecretUpsert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ListTagsForResourceRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PendingIdentityCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TenantForUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SecretKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TaggingsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AppSchemasTenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.WorkspaceInviteResult>))]
    internal sealed partial class WorkspacesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkspacesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WorkspacesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WorkspacesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LangSmith.JsonConverters.EntitiesItemJsonConverter());
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

                    || typeToConvert == typeof(global::LangSmith.MemberSortField)

                    || typeToConvert == typeof(global::LangSmith.MemberSortField?)

                    || typeToConvert == typeof(global::LangSmith.ProvisioningMethod)

                    || typeToConvert == typeof(global::LangSmith.ProvisioningMethod?)

                    || typeToConvert == typeof(global::LangSmith.ResourceType)

                    || typeToConvert == typeof(global::LangSmith.ResourceType?)

                    || typeToConvert == typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType)

                    || typeToConvert == typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType?)

                    || typeToConvert == typeof(global::LangSmith.TenantUsageLimitType)

                    || typeToConvert == typeof(global::LangSmith.TenantUsageLimitType?)

                    || typeToConvert == typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService)

                    || typeToConvert == typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService?);
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

                if (typeToConvert == typeof(global::LangSmith.MemberSortField))
                {
                    return new global::LangSmith.JsonConverters.MemberSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.MemberSortField?))
                {
                    return new global::LangSmith.JsonConverters.MemberSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ProvisioningMethod))
                {
                    return new global::LangSmith.JsonConverters.ProvisioningMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ProvisioningMethod?))
                {
                    return new global::LangSmith.JsonConverters.ProvisioningMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ResourceType))
                {
                    return new global::LangSmith.JsonConverters.ResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ResourceType?))
                {
                    return new global::LangSmith.JsonConverters.ResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType))
                {
                    return new global::LangSmith.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType?))
                {
                    return new global::LangSmith.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TenantUsageLimitType))
                {
                    return new global::LangSmith.JsonConverters.TenantUsageLimitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TenantUsageLimitType?))
                {
                    return new global::LangSmith.JsonConverters.TenantUsageLimitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService))
                {
                    return new global::LangSmith.JsonConverters.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetServiceJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService?))
                {
                    return new global::LangSmith.JsonConverters.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetServiceNullableJsonConverter();
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
                    0 => new WorkspacesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}