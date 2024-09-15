#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Delete Tracer Session<br/>
        /// Delete a specific session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DeleteTracerSessionApiV1SessionsSessionIdDeleteResponse> DeleteTracerSessionAsync(
            global::System.Guid sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}