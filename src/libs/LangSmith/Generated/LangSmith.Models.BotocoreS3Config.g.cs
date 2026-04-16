
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Typed subset of botocore Config s3 parameter.<br/>
    /// See: https://botocore.amazonaws.com/v1/documentation/api/latest/reference/config.html
    /// </summary>
    public sealed partial class BotocoreS3Config
    {
        /// <summary>
        /// S3 addressing style. Use "virtual" for services that require virtual-hosted style (e.g. Volcengine TOS), "path" for path-style, or "auto" (default) to let boto3 decide.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addressing_style")]
        public global::LangSmith.BotocoreS3ConfigAddressingStyle2? AddressingStyle { get; set; }

        /// <summary>
        /// Whether to use the S3 Accelerate endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_accelerate_endpoint")]
        public bool? UseAccelerateEndpoint { get; set; }

        /// <summary>
        /// Whether to SHA256 sign SigV4 payloads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_signing_enabled")]
        public bool? PayloadSigningEnabled { get; set; }

        /// <summary>
        /// Which S3 endpoint to use when region is us-east-1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("us_east_1_regional_endpoint")]
        public global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2? UsEast1RegionalEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BotocoreS3Config" /> class.
        /// </summary>
        /// <param name="addressingStyle">
        /// S3 addressing style. Use "virtual" for services that require virtual-hosted style (e.g. Volcengine TOS), "path" for path-style, or "auto" (default) to let boto3 decide.
        /// </param>
        /// <param name="useAccelerateEndpoint">
        /// Whether to use the S3 Accelerate endpoint.
        /// </param>
        /// <param name="payloadSigningEnabled">
        /// Whether to SHA256 sign SigV4 payloads.
        /// </param>
        /// <param name="usEast1RegionalEndpoint">
        /// Which S3 endpoint to use when region is us-east-1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BotocoreS3Config(
            global::LangSmith.BotocoreS3ConfigAddressingStyle2? addressingStyle,
            bool? useAccelerateEndpoint,
            bool? payloadSigningEnabled,
            global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2? usEast1RegionalEndpoint)
        {
            this.AddressingStyle = addressingStyle;
            this.UseAccelerateEndpoint = useAccelerateEndpoint;
            this.PayloadSigningEnabled = payloadSigningEnabled;
            this.UsEast1RegionalEndpoint = usEast1RegionalEndpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BotocoreS3Config" /> class.
        /// </summary>
        public BotocoreS3Config()
        {
        }
    }
}