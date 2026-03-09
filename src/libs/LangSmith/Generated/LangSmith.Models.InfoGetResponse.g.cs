
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// The LangSmith server info.
    /// </summary>
    public sealed partial class InfoGetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_expiration_time")]
        public global::System.DateTime? LicenseExpirationTime { get; set; }

        /// <summary>
        /// Batch ingest config.<br/>
        /// Default Value: {"use_multipart_endpoint":true,"scale_up_qsize_trigger":1000,"scale_up_nthreads_limit":16,"scale_down_nempty_trigger":4,"size_limit":100,"size_limit_bytes":20971520}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_ingest_config")]
        public global::LangSmith.BatchIngestConfig? BatchIngestConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_flags")]
        public object? InstanceFlags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_info")]
        public global::LangSmith.CustomerInfo? CustomerInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoGetResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="licenseExpirationTime"></param>
        /// <param name="batchIngestConfig">
        /// Batch ingest config.<br/>
        /// Default Value: {"use_multipart_endpoint":true,"scale_up_qsize_trigger":1000,"scale_up_nthreads_limit":16,"scale_down_nempty_trigger":4,"size_limit":100,"size_limit_bytes":20971520}
        /// </param>
        /// <param name="instanceFlags"></param>
        /// <param name="customerInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfoGetResponse(
            string version,
            global::System.DateTime? licenseExpirationTime,
            global::LangSmith.BatchIngestConfig? batchIngestConfig,
            object? instanceFlags,
            global::LangSmith.CustomerInfo? customerInfo)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.LicenseExpirationTime = licenseExpirationTime;
            this.BatchIngestConfig = batchIngestConfig;
            this.InstanceFlags = instanceFlags;
            this.CustomerInfo = customerInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoGetResponse" /> class.
        /// </summary>
        public InfoGetResponse()
        {
        }
    }
}