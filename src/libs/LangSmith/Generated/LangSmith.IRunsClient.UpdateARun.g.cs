#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Update a Run<br/>
        /// Updates a run identified by its ID. The body should contain only the fields to be changed; unknown fields are ignored.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateARunAsync(
            global::LangSmith.RunsRun request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a Run<br/>
        /// Updates a run identified by its ID. The body should contain only the fields to be changed; unknown fields are ignored.
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
        global::System.Threading.Tasks.Task<string> UpdateARunAsync(
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