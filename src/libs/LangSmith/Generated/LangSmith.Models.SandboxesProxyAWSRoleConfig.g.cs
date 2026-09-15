
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesProxyAWSRoleConfig
    {
        /// <summary>
        /// RoleARN selects automatically renewed IAM-role credentials instead of static keys.<br/>
        /// Access follows the role's effective AWS permissions, not the sandbox's mount scope.<br/>
        /// Configure at creation; the role cannot be changed afterward.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyAWSRoleConfig" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// RoleARN selects automatically renewed IAM-role credentials instead of static keys.<br/>
        /// Access follows the role's effective AWS permissions, not the sandbox's mount scope.<br/>
        /// Configure at creation; the role cannot be changed afterward.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyAWSRoleConfig(
            string roleArn)
        {
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyAWSRoleConfig" /> class.
        /// </summary>
        public SandboxesProxyAWSRoleConfig()
        {
        }

    }
}