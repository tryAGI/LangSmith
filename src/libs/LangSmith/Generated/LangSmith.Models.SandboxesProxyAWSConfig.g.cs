
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesProxyAWSConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxesProxySecretValue AccessKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_access_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxesProxySecretValue SecretAccessKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyAWSConfig" /> class.
        /// </summary>
        /// <param name="accessKeyId"></param>
        /// <param name="secretAccessKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyAWSConfig(
            global::LangSmith.SandboxesProxySecretValue accessKeyId,
            global::LangSmith.SandboxesProxySecretValue secretAccessKey)
        {
            this.AccessKeyId = accessKeyId ?? throw new global::System.ArgumentNullException(nameof(accessKeyId));
            this.SecretAccessKey = secretAccessKey ?? throw new global::System.ArgumentNullException(nameof(secretAccessKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyAWSConfig" /> class.
        /// </summary>
        public SandboxesProxyAWSConfig()
        {
        }

    }
}