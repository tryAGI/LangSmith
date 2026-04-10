#nullable enable

namespace LangSmith
{
    public partial interface IForgeConfigurationsClient
    {
        /// <summary>
        /// Create a forge configuration<br/>
        /// Creates a new Forge configuration for the given tracing project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ForgeConfigurationsForgeConfiguration> CreateAForgeConfigurationAsync(

            global::LangSmith.ForgeConfigurationsCreateForgeConfigurationRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a forge configuration<br/>
        /// Creates a new Forge configuration for the given tracing project.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="gitCommitMetadataKey"></param>
        /// <param name="githubRepo"></param>
        /// <param name="scheduleCron"></param>
        /// <param name="tracerSessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ForgeConfigurationsForgeConfiguration> CreateAForgeConfigurationAsync(
            bool? enabled = default,
            string? gitCommitMetadataKey = default,
            string? githubRepo = default,
            string? scheduleCron = default,
            string? tracerSessionId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}