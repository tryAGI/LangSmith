
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
        /// Batch ingest config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_ingest_config")]
        public global::LangSmith.BatchIngestConfig? BatchIngestConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_flags")]
        public object? InstanceFlags { get; set; }

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
        /// Batch ingest config.
        /// </param>
        /// <param name="instanceFlags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfoGetResponse(
            string version,
            global::System.DateTime? licenseExpirationTime,
            global::LangSmith.BatchIngestConfig? batchIngestConfig,
            object? instanceFlags)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.LicenseExpirationTime = licenseExpirationTime;
            this.BatchIngestConfig = batchIngestConfig;
            this.InstanceFlags = instanceFlags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoGetResponse" /> class.
        /// </summary>
        public InfoGetResponse()
        {
        }
    }
}