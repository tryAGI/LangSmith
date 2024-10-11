#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Update Run<br/>
        /// Update a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateRunApiV1RunsRunIdPatchResponse> UpdateRunAsync(
            global::System.Guid runId,
            global::LangSmith.UpdateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Run<br/>
        /// Update a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="parentRunId"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="extra"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="outputAttachments"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateRunApiV1RunsRunIdPatchResponse> UpdateRunAsync(
            global::System.Guid runId,
            global::LangSmith.OneOf<global::System.Guid?, object>? traceId = default,
            global::LangSmith.OneOf<string, object>? dottedOrder = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? parentRunId = default,
            global::LangSmith.OneOf<string, double?, object>? endTime = default,
            global::LangSmith.OneOf<string, object>? error = default,
            global::LangSmith.OneOf<object, object>? inputs = default,
            global::LangSmith.OneOf<object, object>? outputs = default,
            global::LangSmith.OneOf<global::System.Collections.Generic.IList<object>, object>? events = default,
            global::LangSmith.OneOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::LangSmith.OneOf<object, object>? extra = default,
            global::LangSmith.OneOf<object, object>? inputAttachments = default,
            global::LangSmith.OneOf<object, object>? outputAttachments = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? sessionId = default,
            global::LangSmith.OneOf<string, object>? sessionName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}