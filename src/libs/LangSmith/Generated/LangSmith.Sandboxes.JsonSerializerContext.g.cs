
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthSandboxDelegationMode), TypeInfoPropertyName = "AuthSandboxDelegationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiContextHubMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiFileInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGCSMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGitMountRefSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGitMountRefSpecType), TypeInfoPropertyName = "SandboxapiGitMountRefSpecType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGitMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGrepMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountCacheSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountKind), TypeInfoPropertyName = "SandboxapiMountKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiS3MountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiS3BucketMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGCSBucketMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGitRepoMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiContextHubRepoMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountSpecDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType), TypeInfoPropertyName = "SandboxapiMountSpecDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiRunConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesAccessControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesAccessDelegation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesBatchDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesBatchDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesBatchDeleteSkipped>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesBatchDeleteSkipped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCaptureSnapshotPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCreateRegistryPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCreateRegistryPayloadAuthType), TypeInfoPropertyName = "SandboxesCreateRegistryPayloadAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCreateSandboxPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxMountConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCreateSnapshotPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesDownloadURLPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag), TypeInfoPropertyName = "SandboxesDownloadURLPayloadCspSandboxFlag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle), TypeInfoPropertyName = "SandboxesDownloadURLPayloadCspSourceBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesDownloadURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesErrorResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesExecRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesExecResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesExecStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesExecStreamResumeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesGlobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesGlobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxapiFileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesGrepRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesGrepResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxapiGrepMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesHeaderType), TypeInfoPropertyName = "SandboxesHeaderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyAWSConfig), TypeInfoPropertyName = "SandboxesProxyAWSConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyAWSRoleConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyAWSStaticConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesCallback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyGCPConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxySecretValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesRegistryListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesRegistryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesRegistryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesRegistryResponseAuthType), TypeInfoPropertyName = "SandboxesRegistryResponseAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesRegistryResponseProvider), TypeInfoPropertyName = "SandboxesRegistryResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesRegistryResponseRepositorySearchMode), TypeInfoPropertyName = "SandboxesRegistryResponseRepositorySearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxAWSMountAuthConfig), TypeInfoPropertyName = "SandboxesSandboxAWSMountAuthConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxGCPMountAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxMountAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxapiMountSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxUsageCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUsageCostResourceType), TypeInfoPropertyName = "SandboxesUsageCostResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxUsageCostsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesServiceURLPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesServiceURLPayloadAccess), TypeInfoPropertyName = "SandboxesServiceURLPayloadAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesServiceURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesServiceURLResponseAccess), TypeInfoPropertyName = "SandboxesServiceURLResponseAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSnapshotListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSnapshotNameResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotNameTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSnapshotNameTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUpdateRegistryPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUpdateRegistryPayloadAuthType), TypeInfoPropertyName = "SandboxesUpdateRegistryPayloadAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUpdateSandboxPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedParseErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetailsErrorClass), TypeInfoPropertyName = "SharedProblemDetailsErrorClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn), TypeInfoPropertyName = "SandboxesProxyAWSStaticConfigRoleArn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfigRoleArn), TypeInfoPropertyName = "SandboxesSandboxAWSMountStaticAuthConfigRoleArn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateSandboxesUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetSandboxesUsageCostsResourceType), TypeInfoPropertyName = "GetSandboxesUsageCostsResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetSandboxesUsageCostsGranularity), TypeInfoPropertyName = "GetSandboxesUsageCostsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthSandboxDelegationMode?), TypeInfoPropertyName = "NullableAuthSandboxDelegationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGitMountRefSpecType?), TypeInfoPropertyName = "NullableSandboxapiGitMountRefSpecType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountKind?), TypeInfoPropertyName = "NullableSandboxapiMountKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType?), TypeInfoPropertyName = "NullableSandboxapiMountSpecDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCreateRegistryPayloadAuthType?), TypeInfoPropertyName = "NullableSandboxesCreateRegistryPayloadAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag?), TypeInfoPropertyName = "NullableSandboxesDownloadURLPayloadCspSandboxFlag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle?), TypeInfoPropertyName = "NullableSandboxesDownloadURLPayloadCspSourceBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesHeaderType?), TypeInfoPropertyName = "NullableSandboxesHeaderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyAWSConfig?), TypeInfoPropertyName = "NullableSandboxesProxyAWSConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesRegistryResponseAuthType?), TypeInfoPropertyName = "NullableSandboxesRegistryResponseAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesRegistryResponseProvider?), TypeInfoPropertyName = "NullableSandboxesRegistryResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesRegistryResponseRepositorySearchMode?), TypeInfoPropertyName = "NullableSandboxesRegistryResponseRepositorySearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxAWSMountAuthConfig?), TypeInfoPropertyName = "NullableSandboxesSandboxAWSMountAuthConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUsageCostResourceType?), TypeInfoPropertyName = "NullableSandboxesUsageCostResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesServiceURLPayloadAccess?), TypeInfoPropertyName = "NullableSandboxesServiceURLPayloadAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesServiceURLResponseAccess?), TypeInfoPropertyName = "NullableSandboxesServiceURLResponseAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUpdateRegistryPayloadAuthType?), TypeInfoPropertyName = "NullableSandboxesUpdateRegistryPayloadAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetailsErrorClass?), TypeInfoPropertyName = "NullableSharedProblemDetailsErrorClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn?), TypeInfoPropertyName = "NullableSandboxesProxyAWSStaticConfigRoleArn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfigRoleArn?), TypeInfoPropertyName = "NullableSandboxesSandboxAWSMountStaticAuthConfigRoleArn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetSandboxesUsageCostsResourceType?), TypeInfoPropertyName = "NullableGetSandboxesUsageCostsResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetSandboxesUsageCostsGranularity?), TypeInfoPropertyName = "NullableGetSandboxesUsageCostsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesBatchDeleteSkipped>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxapiFileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxapiGrepMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesCallback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesRegistryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxapiMountSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxUsageCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotNameTag>))]
    internal sealed partial class SandboxesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SandboxesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SandboxesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LangSmith.JsonConverters.SandboxesProxyAWSConfigJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.SandboxesSandboxAWSMountAuthConfigJsonConverter());
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
                    typeToConvert == typeof(global::LangSmith.AuthSandboxDelegationMode)

                    || typeToConvert == typeof(global::LangSmith.AuthSandboxDelegationMode?)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiGitMountRefSpecType)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiGitMountRefSpecType?)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiMountKind)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiMountKind?)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesCreateRegistryPayloadAuthType)

                    || typeToConvert == typeof(global::LangSmith.SandboxesCreateRegistryPayloadAuthType?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag)

                    || typeToConvert == typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle)

                    || typeToConvert == typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesHeaderType)

                    || typeToConvert == typeof(global::LangSmith.SandboxesHeaderType?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseAuthType)

                    || typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseAuthType?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseProvider)

                    || typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseProvider?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseRepositorySearchMode)

                    || typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseRepositorySearchMode?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesServiceURLPayloadAccess)

                    || typeToConvert == typeof(global::LangSmith.SandboxesServiceURLPayloadAccess?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesServiceURLResponseAccess)

                    || typeToConvert == typeof(global::LangSmith.SandboxesServiceURLResponseAccess?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesUpdateRegistryPayloadAuthType)

                    || typeToConvert == typeof(global::LangSmith.SandboxesUpdateRegistryPayloadAuthType?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesUsageCostResourceType)

                    || typeToConvert == typeof(global::LangSmith.SandboxesUsageCostResourceType?)

                    || typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass)

                    || typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn)

                    || typeToConvert == typeof(global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfigRoleArn)

                    || typeToConvert == typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfigRoleArn?)

                    || typeToConvert == typeof(global::LangSmith.GetSandboxesUsageCostsResourceType)

                    || typeToConvert == typeof(global::LangSmith.GetSandboxesUsageCostsResourceType?)

                    || typeToConvert == typeof(global::LangSmith.GetSandboxesUsageCostsGranularity)

                    || typeToConvert == typeof(global::LangSmith.GetSandboxesUsageCostsGranularity?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.AuthSandboxDelegationMode))
                {
                    return new global::LangSmith.JsonConverters.AuthSandboxDelegationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuthSandboxDelegationMode?))
                {
                    return new global::LangSmith.JsonConverters.AuthSandboxDelegationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiGitMountRefSpecType))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiGitMountRefSpecTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiGitMountRefSpecType?))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiGitMountRefSpecTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiMountKind))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiMountKindJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiMountKind?))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiMountKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiMountSpecDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType?))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiMountSpecDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesCreateRegistryPayloadAuthType))
                {
                    return new global::LangSmith.JsonConverters.SandboxesCreateRegistryPayloadAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesCreateRegistryPayloadAuthType?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesCreateRegistryPayloadAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag))
                {
                    return new global::LangSmith.JsonConverters.SandboxesDownloadURLPayloadCspSandboxFlagJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesDownloadURLPayloadCspSandboxFlagNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle))
                {
                    return new global::LangSmith.JsonConverters.SandboxesDownloadURLPayloadCspSourceBundleJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesDownloadURLPayloadCspSourceBundleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesHeaderType))
                {
                    return new global::LangSmith.JsonConverters.SandboxesHeaderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesHeaderType?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesHeaderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseAuthType))
                {
                    return new global::LangSmith.JsonConverters.SandboxesRegistryResponseAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseAuthType?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesRegistryResponseAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseProvider))
                {
                    return new global::LangSmith.JsonConverters.SandboxesRegistryResponseProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseProvider?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesRegistryResponseProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseRepositorySearchMode))
                {
                    return new global::LangSmith.JsonConverters.SandboxesRegistryResponseRepositorySearchModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesRegistryResponseRepositorySearchMode?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesRegistryResponseRepositorySearchModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesServiceURLPayloadAccess))
                {
                    return new global::LangSmith.JsonConverters.SandboxesServiceURLPayloadAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesServiceURLPayloadAccess?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesServiceURLPayloadAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesServiceURLResponseAccess))
                {
                    return new global::LangSmith.JsonConverters.SandboxesServiceURLResponseAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesServiceURLResponseAccess?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesServiceURLResponseAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesUpdateRegistryPayloadAuthType))
                {
                    return new global::LangSmith.JsonConverters.SandboxesUpdateRegistryPayloadAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesUpdateRegistryPayloadAuthType?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesUpdateRegistryPayloadAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesUsageCostResourceType))
                {
                    return new global::LangSmith.JsonConverters.SandboxesUsageCostResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesUsageCostResourceType?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesUsageCostResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass))
                {
                    return new global::LangSmith.JsonConverters.SharedProblemDetailsErrorClassJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass?))
                {
                    return new global::LangSmith.JsonConverters.SharedProblemDetailsErrorClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn))
                {
                    return new global::LangSmith.JsonConverters.SandboxesProxyAWSStaticConfigRoleArnJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesProxyAWSStaticConfigRoleArnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfigRoleArn))
                {
                    return new global::LangSmith.JsonConverters.SandboxesSandboxAWSMountStaticAuthConfigRoleArnJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfigRoleArn?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesSandboxAWSMountStaticAuthConfigRoleArnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetSandboxesUsageCostsResourceType))
                {
                    return new global::LangSmith.JsonConverters.GetSandboxesUsageCostsResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetSandboxesUsageCostsResourceType?))
                {
                    return new global::LangSmith.JsonConverters.GetSandboxesUsageCostsResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetSandboxesUsageCostsGranularity))
                {
                    return new global::LangSmith.JsonConverters.GetSandboxesUsageCostsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetSandboxesUsageCostsGranularity?))
                {
                    return new global::LangSmith.JsonConverters.GetSandboxesUsageCostsGranularityNullableJsonConverter();
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
                    0 => new SandboxesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}