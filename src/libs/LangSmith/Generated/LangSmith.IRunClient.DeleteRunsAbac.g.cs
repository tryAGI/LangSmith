#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Delete Runs Abac<br/>
        /// Delete specific runs by trace IDs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunsAbacAsync(

            global::LangSmith.BodyDeleteRunsAbacApiV1RunsDeleteTracesPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete Runs Abac<br/>
        /// Delete specific runs by trace IDs.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="traceIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunsAbacAsync(
            global::System.Guid sessionId,
            global::System.Collections.Generic.IList<global::System.Guid> traceIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}