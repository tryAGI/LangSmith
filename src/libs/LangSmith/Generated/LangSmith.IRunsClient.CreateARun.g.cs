#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Create a Run<br/>
        /// Queues a single run for ingestion. The request body must be a JSON-encoded run object that follows the Run schema.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateARunAsync(
            global::LangSmith.RunsRun request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a Run<br/>
        /// Queues a single run for ingestion. The request body must be a JSON-encoded run object that follows the Run schema.
        /// </summary>
        /// <param name="dottedOrder"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="events"></param>
        /// <param name="extra"></param>
        /// <param name="id"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="inputs"></param>
        /// <param name="name"></param>
        /// <param name="outputAttachments"></param>
        /// <param name="outputs"></param>
        /// <param name="parentRunId"></param>
        /// <param name="referenceExampleId"></param>
        /// <param name="runType"></param>
        /// <param name="serialized"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="startTime"></param>
        /// <param name="status"></param>
        /// <param name="tags"></param>
        /// <param name="traceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateARunAsync(
            string? dottedOrder = default,
            string? endTime = default,
            string? error = default,
            global::System.Collections.Generic.IList<object>? events = default,
            object? extra = default,
            string? id = default,
            object? inputAttachments = default,
            object? inputs = default,
            string? name = default,
            object? outputAttachments = default,
            object? outputs = default,
            string? parentRunId = default,
            string? referenceExampleId = default,
            global::LangSmith.RunsRunRunType? runType = default,
            object? serialized = default,
            string? sessionId = default,
            string? sessionName = default,
            string? startTime = default,
            string? status = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? traceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}