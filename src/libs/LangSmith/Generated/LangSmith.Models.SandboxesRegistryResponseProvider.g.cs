
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesRegistryResponseProvider
    {
        /// <summary>
        ///
        /// </summary>
        DockerHub,
        /// <summary>
        ///
        /// </summary>
        DockerRegistry,
        /// <summary>
        ///
        /// </summary>
        Ecr,
        /// <summary>
        ///
        /// </summary>
        Gar,
        /// <summary>
        ///
        /// </summary>
        Ghcr,
        /// <summary>
        ///
        /// </summary>
        Harbor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesRegistryResponseProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesRegistryResponseProvider value)
        {
            return value switch
            {
                SandboxesRegistryResponseProvider.DockerHub => "DOCKER_HUB",
                SandboxesRegistryResponseProvider.DockerRegistry => "DOCKER_REGISTRY",
                SandboxesRegistryResponseProvider.Ecr => "ECR",
                SandboxesRegistryResponseProvider.Gar => "GAR",
                SandboxesRegistryResponseProvider.Ghcr => "GHCR",
                SandboxesRegistryResponseProvider.Harbor => "HARBOR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesRegistryResponseProvider? ToEnum(string value)
        {
            return value switch
            {
                "DOCKER_HUB" => SandboxesRegistryResponseProvider.DockerHub,
                "DOCKER_REGISTRY" => SandboxesRegistryResponseProvider.DockerRegistry,
                "ECR" => SandboxesRegistryResponseProvider.Ecr,
                "GAR" => SandboxesRegistryResponseProvider.Gar,
                "GHCR" => SandboxesRegistryResponseProvider.Ghcr,
                "HARBOR" => SandboxesRegistryResponseProvider.Harbor,
                _ => null,
            };
        }
    }
}