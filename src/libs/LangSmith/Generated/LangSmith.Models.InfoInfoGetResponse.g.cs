
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InfoInfoGetResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_ingest_config")]
        public global::LangSmith.InfoBatchIngestConfig? BatchIngestConfig { get; set; }

        /// <summary>
        /// BillingInstallationID is the persistent per-installation identity for<br/>
        /// self-hosted deployments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_installation_id")]
        public string? BillingInstallationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_info")]
        public global::LangSmith.InfoCustomerInfo? CustomerInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_sha")]
        public string? GitSha { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_flags")]
        public object? InstanceFlags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_expiration_time")]
        public string? LicenseExpirationTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdk_versions")]
        public global::LangSmith.InfoSDKVersions? SdkVersions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoInfoGetResponse" /> class.
        /// </summary>
        /// <param name="batchIngestConfig"></param>
        /// <param name="billingInstallationId">
        /// BillingInstallationID is the persistent per-installation identity for<br/>
        /// self-hosted deployments.
        /// </param>
        /// <param name="customerInfo"></param>
        /// <param name="gitSha"></param>
        /// <param name="instanceFlags"></param>
        /// <param name="licenseExpirationTime"></param>
        /// <param name="sdkVersions"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfoInfoGetResponse(
            global::LangSmith.InfoBatchIngestConfig? batchIngestConfig,
            string? billingInstallationId,
            global::LangSmith.InfoCustomerInfo? customerInfo,
            string? gitSha,
            object? instanceFlags,
            string? licenseExpirationTime,
            global::LangSmith.InfoSDKVersions? sdkVersions,
            string? version)
        {
            this.BatchIngestConfig = batchIngestConfig;
            this.BillingInstallationId = billingInstallationId;
            this.CustomerInfo = customerInfo;
            this.GitSha = gitSha;
            this.InstanceFlags = instanceFlags;
            this.LicenseExpirationTime = licenseExpirationTime;
            this.SdkVersions = sdkVersions;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoInfoGetResponse" /> class.
        /// </summary>
        public InfoInfoGetResponse()
        {
        }

    }
}