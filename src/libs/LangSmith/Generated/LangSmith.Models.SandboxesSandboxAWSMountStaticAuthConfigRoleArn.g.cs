
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// IAM role to assume with permissions scoped to the configured S3 mounts.<br/>
    /// Mutually exclusive with static credentials. Configure only at creation.
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