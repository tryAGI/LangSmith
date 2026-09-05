
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesUpdateRegistryPayloadAuthType
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
    public static class SandboxesUpdateRegistryPayloadAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesUpdateRegistryPayloadAuthType value)
        {
            return value switch
            {
                SandboxesUpdateRegistryPayloadAuthType.AwsRole => "AWS_ROLE",
                SandboxesUpdateRegistryPayloadAuthType.DockerConfig => "DOCKER_CONFIG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesUpdateRegistryPayloadAuthType? ToEnum(string value)
        {
            return value switch
            {
                "AWS_ROLE" => SandboxesUpdateRegistryPayloadAuthType.AwsRole,
                "DOCKER_CONFIG" => SandboxesUpdateRegistryPayloadAuthType.DockerConfig,
                _ => null,
            };
        }
    }
}