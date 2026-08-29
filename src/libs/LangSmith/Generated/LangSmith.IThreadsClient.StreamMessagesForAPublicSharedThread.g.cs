#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Stream messages for a public shared thread<br/>
        /// Streams the thread's conversation as server-sent events. SSE only.<br/>
        /// Self-hosted deployments require LangSmith `v0.16` or later.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="shareToken"></param>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="traceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> StreamMessagesForAPublicSharedThreadAsync(
            string accept,
            global::System.Guid shareToken,
            int? pageSize = default,
            string? cursor = default,
            global::System.Guid? traceId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}