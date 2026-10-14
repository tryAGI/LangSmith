
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesProxyAWSRoleConfig
    {
        /// <summary>
        /// IAM role to assume with AssumeRoleWithWebIdentity, using a short-lived OIDC token LangSmith signs for this workspace. The role's trust policy must trust LangSmith's issuer for the token subject. Credentials renew automatically, and access follows the role's effective AWS permissions. Mutually exclusive with static keys, and cannot be changed after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// SubjectScope picks the token subject the role trusts: "workspace" (the default) or "tag:&lt;tag value id&gt;", which must be one of the sandbox's tag_value_ids. Only valid with role_arn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_scope")]
        public string? SubjectScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyAWSRoleConfig" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// IAM role to assume with AssumeRoleWithWebIdentity, using a short-lived OIDC token LangSmith signs for this workspace. The role's trust policy must trust LangSmith's issuer for the token subject. Credentials renew automatically, and access follows the role's effective AWS permissions. Mutually exclusive with static keys, and cannot be changed after creation.
        /// </param>
        /// <param name="subjectScope">
        /// SubjectScope picks the token subject the role trusts: "workspace" (the default) or "tag:&lt;tag value id&gt;", which must be one of the sandbox's tag_value_ids. Only valid with role_arn.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyAWSRoleConfig(
            string roleArn,
            string? subjectScope)
        {
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.SubjectScope = subjectScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyAWSRoleConfig" /> class.
        /// </summary>
        public SandboxesProxyAWSRoleConfig()
        {
        }

    }
}