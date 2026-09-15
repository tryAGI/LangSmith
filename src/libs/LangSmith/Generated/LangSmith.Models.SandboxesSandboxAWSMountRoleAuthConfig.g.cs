
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxAWSMountRoleAuthConfig
    {
        /// <summary>
        /// IAM role to assume with permissions scoped to the configured S3 mounts.<br/>
        /// Mutually exclusive with static credentials. Configure only at creation.
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
        /// Initializes a new instance of the <see cref="SandboxesSandboxAWSMountRoleAuthConfig" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// IAM role to assume with permissions scoped to the configured S3 mounts.<br/>
        /// Mutually exclusive with static credentials. Configure only at creation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxAWSMountRoleAuthConfig(
            string roleArn)
        {
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxAWSMountRoleAuthConfig" /> class.
        /// </summary>
        public SandboxesSandboxAWSMountRoleAuthConfig()
        {
        }

    }
}