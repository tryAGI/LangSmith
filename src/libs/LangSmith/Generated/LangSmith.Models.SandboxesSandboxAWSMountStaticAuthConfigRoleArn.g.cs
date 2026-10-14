
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// IAM role to assume with AssumeRoleWithWebIdentity, using a short-lived OIDC token LangSmith signs for this workspace; the role's trust policy must trust LangSmith's issuer for the token subject. LangSmith scopes the credentials to the configured S3 mounts. Mutually exclusive with static credentials, and cannot be changed after creation.
    /// </summary>
    public enum SandboxesSandboxAWSMountStaticAuthConfigRoleArn
    {
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesSandboxAWSMountStaticAuthConfigRoleArnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesSandboxAWSMountStaticAuthConfigRoleArn value)
        {
            return value switch
            {
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesSandboxAWSMountStaticAuthConfigRoleArn? ToEnum(string value)
        {
            return value switch
            {
                _ => null,
            };
        }
    }
}