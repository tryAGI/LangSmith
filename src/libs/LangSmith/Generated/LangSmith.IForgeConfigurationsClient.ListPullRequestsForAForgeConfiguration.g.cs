#nullable enable

namespace LangSmith
{
    public partial interface IForgeConfigurationsClient
    {
        /// <summary>
        /// List pull requests for a forge configuration<br/>
        /// Returns open GitHub pull requests for the repository connected to the given Forge configuration.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.ForgeConfigurationsForgePR>> ListPullRequestsForAForgeConfigurationAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}