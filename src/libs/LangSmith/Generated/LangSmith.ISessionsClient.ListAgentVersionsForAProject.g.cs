#nullable enable

namespace LangSmith
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// List agent versions for a project<br/>
        /// Returns all agent versions (commit SHAs) seen in the given tracing project, ordered by first_seen_at descending.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TracerSessionsAgentVersionResponse>> ListAgentVersionsForAProjectAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}