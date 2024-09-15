#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Update Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> UpdateTracerSessionAsync(
            global::System.Guid sessionId,
            global::LangSmith.TracerSessionUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="traceTier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> UpdateTracerSessionAsync(
            global::System.Guid sessionId,
            global::LangSmith.AnyOf<string, object>? name = default,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? defaultDatasetId = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::LangSmith.AnyOf<global::LangSmith.TracerSessionUpdateExtra, object>? extra = default,
            global::LangSmith.AnyOf<global::LangSmith.TraceTier3?, object>? traceTier = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}