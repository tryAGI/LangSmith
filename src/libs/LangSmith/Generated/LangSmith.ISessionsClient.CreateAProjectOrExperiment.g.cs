#nullable enable

namespace LangSmith
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Create a project or experiment<br/>
        /// Create a session, or update an existing session with the same name when upsert is true. Returns the refreshed session representation without optional run statistics.
        /// </summary>
        /// <param name="upsert"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Session> CreateAProjectOrExperimentAsync(

            global::LangSmith.TracerSessionsCreateSessionRequest request,
            bool? upsert = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project or experiment<br/>
        /// Create a session, or update an existing session with the same name when upsert is true. Returns the refreshed session representation without optional run statistics.
        /// </summary>
        /// <param name="upsert"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.Session>> CreateAProjectOrExperimentAsResponseAsync(

            global::LangSmith.TracerSessionsCreateSessionRequest request,
            bool? upsert = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project or experiment<br/>
        /// Create a session, or update an existing session with the same name when upsert is true. Returns the refreshed session representation without optional run statistics.
        /// </summary>
        /// <param name="upsert"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="description"></param>
        /// <param name="endTime"></param>
        /// <param name="evaluatorKeys"></param>
        /// <param name="extra"></param>
        /// <param name="id"></param>
        /// <param name="kickedOffBy"></param>
        /// <param name="longlivedTtlDays">
        /// LonglivedTTLDays overrides long-lived trace retention. Null restores the workspace default.
        /// </param>
        /// <param name="name"></param>
        /// <param name="numExamples"></param>
        /// <param name="numRepetitions"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="startTime"></param>
        /// <param name="tagValueIds"></param>
        /// <param name="traceTier"></param>
        /// <param name="type">
        /// Type identifies a tracing project, Agent tracing project, or experiment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Session> CreateAProjectOrExperimentAsync(
            global::LangSmith.TracerSessionsCreateSessionRequestType type,
            bool? upsert = default,
            global::System.Guid? defaultDatasetId = default,
            string? description = default,
            global::System.DateTime? endTime = default,
            global::System.Collections.Generic.IList<string>? evaluatorKeys = default,
            object? extra = default,
            global::System.Guid? id = default,
            string? kickedOffBy = default,
            int? longlivedTtlDays = default,
            string? name = default,
            int? numExamples = default,
            int? numRepetitions = default,
            global::System.Guid? referenceDatasetId = default,
            global::System.DateTime? startTime = default,
            global::System.Collections.Generic.IList<string>? tagValueIds = default,
            global::LangSmith.TracerSessionsCreateSessionRequestTraceTier? traceTier = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}