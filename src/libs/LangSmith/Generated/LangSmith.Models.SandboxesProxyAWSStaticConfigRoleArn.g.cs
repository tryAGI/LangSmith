
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// RoleARN selects automatically renewed IAM-role credentials instead of static keys.<br/>
    /// Access follows the role's effective AWS permissions, not the sandbox's mount scope.<br/>
    /// Configure at creation; the role cannot be changed afterward.
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