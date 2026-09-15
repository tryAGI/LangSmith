
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesProxyAWSStaticConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxesProxySecretValue AccessKeyId { get; set; }

        /// <summary>
        /// RoleARN selects automatically renewed IAM-role credentials instead of static keys.<br/>
        /// Access follows the role's effective AWS permissions, not the sandbox's mount scope.<br/>
        /// Configure at creation; the role cannot be changed afterward.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesProxyAWSStaticConfigRoleArnJsonConverter))]
        public global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn? RoleArn { get; set; }

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
        /// Initializes a new instance of the <see cref="SandboxesProxyAWSStaticConfig" /> class.
        /// </summary>
        /// <param name="accessKeyId"></param>
        /// <param name="secretAccessKey"></param>
        /// <param name="roleArn">
        /// RoleARN selects automatically renewed IAM-role credentials instead of static keys.<br/>
        /// Access follows the role's effective AWS permissions, not the sandbox's mount scope.<br/>
        /// Configure at creation; the role cannot be changed afterward.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyAWSStaticConfig(
            global::LangSmith.SandboxesProxySecretValue accessKeyId,
            global::LangSmith.SandboxesProxySecretValue secretAccessKey,
            global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn? roleArn)
        {
            this.AccessKeyId = accessKeyId ?? throw new global::System.ArgumentNullException(nameof(accessKeyId));
            this.RoleArn = roleArn;
            this.SecretAccessKey = secretAccessKey ?? throw new global::System.ArgumentNullException(nameof(secretAccessKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyAWSStaticConfig" /> class.
        /// </summary>
        public SandboxesProxyAWSStaticConfig()
        {
        }

    }
}