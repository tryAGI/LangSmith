#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Create Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="upsert">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> CreateTracerSessionAsync(
            global::LangSmith.TracerSessionCreate request,
            bool? upsert = false,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="upsert">
        /// Default Value: false
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="traceTier"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> CreateTracerSessionAsync(
            bool? upsert = false,
            global::System.DateTime? startTime = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::LangSmith.AnyOf<object, object>? extra = default,
            string? name = default,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? defaultDatasetId = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? referenceDatasetId = default,
            global::LangSmith.AnyOf<global::LangSmith.TraceTier3?, object>? traceTier = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}