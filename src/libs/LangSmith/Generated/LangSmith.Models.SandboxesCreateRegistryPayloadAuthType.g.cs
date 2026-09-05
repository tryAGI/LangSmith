
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesCreateRegistryPayloadAuthType
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
    public static class SandboxesCreateRegistryPayloadAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesCreateRegistryPayloadAuthType value)
        {
            return value switch
            {
                SandboxesCreateRegistryPayloadAuthType.AwsRole => "AWS_ROLE",
                SandboxesCreateRegistryPayloadAuthType.DockerConfig => "DOCKER_CONFIG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesCreateRegistryPayloadAuthType? ToEnum(string value)
        {
            return value switch
            {
                "AWS_ROLE" => SandboxesCreateRegistryPayloadAuthType.AwsRole,
                "DOCKER_CONFIG" => SandboxesCreateRegistryPayloadAuthType.DockerConfig,
                _ => null,
            };
        }
    }
}