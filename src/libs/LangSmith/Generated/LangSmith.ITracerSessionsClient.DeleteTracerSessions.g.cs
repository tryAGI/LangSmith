#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Delete Tracer Sessions<br/>
        /// Delete sessions.
        /// </summary>
        /// <param name="sessionIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTracerSessionsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}