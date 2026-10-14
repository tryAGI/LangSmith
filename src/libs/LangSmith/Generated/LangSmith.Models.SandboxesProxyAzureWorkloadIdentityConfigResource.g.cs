
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesProxyAzureWorkloadIdentityConfigResource
    {
        /// <summary>
        ///
        /// </summary>
        Https_CognitiveservicesAzureCom,
        /// <summary>
        ///
        /// </summary>
        Https_ManagementAzureCom,
        /// <summary>
        ///
        /// </summary>
        Https_StorageAzureCom,
        /// <summary>
        ///
        /// </summary>
        Https_VaultAzureNet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesProxyAzureWorkloadIdentityConfigResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesProxyAzureWorkloadIdentityConfigResource value)
        {
            return value switch
            {
                SandboxesProxyAzureWorkloadIdentityConfigResource.Https_CognitiveservicesAzureCom => "https://cognitiveservices.azure.com",
                SandboxesProxyAzureWorkloadIdentityConfigResource.Https_ManagementAzureCom => "https://management.azure.com",
                SandboxesProxyAzureWorkloadIdentityConfigResource.Https_StorageAzureCom => "https://storage.azure.com",
                SandboxesProxyAzureWorkloadIdentityConfigResource.Https_VaultAzureNet => "https://vault.azure.net",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesProxyAzureWorkloadIdentityConfigResource? ToEnum(string value)
        {
            return value switch
            {
                "https://cognitiveservices.azure.com" => SandboxesProxyAzureWorkloadIdentityConfigResource.Https_CognitiveservicesAzureCom,
                "https://management.azure.com" => SandboxesProxyAzureWorkloadIdentityConfigResource.Https_ManagementAzureCom,
                "https://storage.azure.com" => SandboxesProxyAzureWorkloadIdentityConfigResource.Https_StorageAzureCom,
                "https://vault.azure.net" => SandboxesProxyAzureWorkloadIdentityConfigResource.Https_VaultAzureNet,
                _ => null,
            };
        }
    }
}