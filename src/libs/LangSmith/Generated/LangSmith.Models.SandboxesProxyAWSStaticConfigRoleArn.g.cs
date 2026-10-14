
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// IAM role to assume with AssumeRoleWithWebIdentity, using a short-lived OIDC token LangSmith signs for this workspace. The role's trust policy must trust LangSmith's issuer for the token subject. Credentials renew automatically, and access follows the role's effective AWS permissions. Mutually exclusive with static keys, and cannot be changed after creation.
    /// </summary>
    public enum SandboxesProxyAWSStaticConfigRoleArn
    {
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesProxyAWSStaticConfigRoleArnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesProxyAWSStaticConfigRoleArn value)
        {
            return value switch
            {
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesProxyAWSStaticConfigRoleArn? ToEnum(string value)
        {
            return value switch
            {
                _ => null,
            };
        }
    }
}