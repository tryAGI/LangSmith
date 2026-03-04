
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportDestinationS3Config
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        public string? EndpointUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string? BucketName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_additional_kwargs")]
        public object? S3AdditionalKwargs { get; set; }

        /// <summary>
        /// Whether to prepend the bucket name to the S3 file path. Defaults to True. Set to False to skip prepending the bucket name if bucket name is already in the endpoint URL.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_bucket_in_prefix")]
        public bool? IncludeBucketInPrefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestinationS3Config" /> class.
        /// </summary>
        /// <param name="endpointUrl"></param>
        /// <param name="prefix"></param>
        /// <param name="bucketName"></param>
        /// <param name="region"></param>
        /// <param name="s3AdditionalKwargs"></param>
        /// <param name="includeBucketInPrefix">
        /// Whether to prepend the bucket name to the S3 file path. Defaults to True. Set to False to skip prepending the bucket name if bucket name is already in the endpoint URL.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkExportDestinationS3Config(
            string? endpointUrl,
            string? prefix,
            string? bucketName,
            string? region,
            object? s3AdditionalKwargs,
            bool? includeBucketInPrefix)
        {
            this.EndpointUrl = endpointUrl;
            this.Prefix = prefix;
            this.BucketName = bucketName;
            this.Region = region;
            this.S3AdditionalKwargs = s3AdditionalKwargs;
            this.IncludeBucketInPrefix = includeBucketInPrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestinationS3Config" /> class.
        /// </summary>
        public BulkExportDestinationS3Config()
        {
        }
    }
}