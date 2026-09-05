
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesRegistryResponseAuthType
    {
        /// <summary>
        ///
        /// </summary>
        AwsRole,
        /// <summary>
        ///
        /// </summary>
        DockerConfig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesRegistryResponseAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesRegistryResponseAuthType value)
        {
            return value switch
            {
                SandboxesRegistryResponseAuthType.AwsRole => "AWS_ROLE",
                SandboxesRegistryResponseAuthType.DockerConfig => "DOCKER_CONFIG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesRegistryResponseAuthType? ToEnum(string value)
        {
            return value switch
            {
                "AWS_ROLE" => SandboxesRegistryResponseAuthType.AwsRole,
                "DOCKER_CONFIG" => SandboxesRegistryResponseAuthType.DockerConfig,
                _ => null,
            };
        }
    }
}