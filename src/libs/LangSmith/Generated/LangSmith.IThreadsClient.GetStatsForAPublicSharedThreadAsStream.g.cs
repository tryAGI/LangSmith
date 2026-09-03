#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Get stats for a public shared thread<br/>
        /// Returns aggregate stats for the thread identified by the share token.<br/>
        /// Self-hosted deployments require LangSmith `v0.16` or later.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="shareToken"></param>
        /// <param name="selects"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> GetStatsForAPublicSharedThreadAsStreamAsync(
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<string> selects,
            string? accept = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}