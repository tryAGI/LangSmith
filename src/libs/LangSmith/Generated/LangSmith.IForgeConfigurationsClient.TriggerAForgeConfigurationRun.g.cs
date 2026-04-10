#nullable enable

namespace LangSmith
{
    public partial interface IForgeConfigurationsClient
    {
        /// <summary>
        /// Trigger a forge configuration run<br/>
        /// Enqueues an immediate forge agent run for the given configuration.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task TriggerAForgeConfigurationRunAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}