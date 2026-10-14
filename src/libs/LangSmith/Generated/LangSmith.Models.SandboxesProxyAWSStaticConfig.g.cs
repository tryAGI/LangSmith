
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
        /// IAM role to assume with AssumeRoleWithWebIdentity, using a short-lived OIDC token LangSmith signs for this workspace. The role's trust policy must trust LangSmith's issuer for the token subject. Credentials renew automatically, and access follows the role's effective AWS permissions. Mutually exclusive with static keys, and cannot be changed after creation.
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
        /// IAM role to assume with AssumeRoleWithWebIdentity, using a short-lived OIDC token LangSmith signs for this workspace. The role's trust policy must trust LangSmith's issuer for the token subject. Credentials renew automatically, and access follows the role's effective AWS permissions. Mutually exclusive with static keys, and cannot be changed after creation.
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