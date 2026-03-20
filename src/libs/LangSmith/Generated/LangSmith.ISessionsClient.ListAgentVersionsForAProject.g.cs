#nullable enable

namespace LangSmith
{
    public partial interface ISessionsClient
    {

        /// <summary>
        /// List agent versions for a project<br/>
        /// Returns all agent versions (commit SHAs) seen in the given tracing project, ordered by first_seen_at descending.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TracerSessionsAgentVersionResponse>> ListAgentVersionsForAProjectAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}