#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Read Tracer Session<br/>
        /// Get a specific session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="includeStats">
        /// Default Value: false
        /// </param>
        /// <param name="accept"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSession> ReadTracerSessionAsync(
            global::System.Guid sessionId,
            bool includeStats = false,
            global::LangSmith.AnyOf<string, object>? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}