#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Create Tracer Session<br/>
        /// Create a new project.
        /// </summary>
        /// <param name="upsert">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> CreateTracerSessionAsync(

            global::LangSmith.TracerSessionCreate request,
            bool? upsert = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tracer Session<br/>
        /// Create a new project.
        /// </summary>
        /// <param name="upsert">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionWithoutVirtualFields>> CreateTracerSessionAsResponseAsync(

            global::LangSmith.TracerSessionCreate request,
            bool? upsert = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tracer Session<br/>
        /// Create a new project.
        /// </summary>
        /// <param name="upsert">
        /// Default Value: false
        /// </param>
        /// <param name="tagValueIds"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="traceTier"></param>
        /// <param name="id"></param>
        /// <param name="numExamples"></param>
        /// <param name="numRepetitions"></param>
        /// <param name="evaluatorKeys"></param>
        /// <param name="kickedOffBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> CreateTracerSessionAsync(
            bool? upsert = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueIds = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            object? extra = default,
            string? name = default,
            string? description = default,
            global::System.Guid? defaultDatasetId = default,
            global::System.Guid? referenceDatasetId = default,
            global::LangSmith.TraceTier? traceTier = default,
            global::System.Guid? id = default,
            int? numExamples = default,
            int? numRepetitions = default,
            global::System.Collections.Generic.IList<string>? evaluatorKeys = default,
            string? kickedOffBy = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}