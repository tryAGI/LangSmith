
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxapiS3MountSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        public string? EndpointUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path_style")]
        public bool? PathStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiS3MountSpec" /> class.
        /// </summary>
        /// <param name="bucket"></param>
        /// <param name="region"></param>
        /// <param name="endpointUrl"></param>
        /// <param name="pathStyle"></param>
        /// <param name="prefix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiS3MountSpec(
            string bucket,
            string region,
            string? endpointUrl,
            bool? pathStyle,
            string? prefix)
        {
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.EndpointUrl = endpointUrl;
            this.PathStyle = pathStyle;
            this.Prefix = prefix;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiS3MountSpec" /> class.
        /// </summary>
        public SandboxapiS3MountSpec()
        {
        }

    }
}