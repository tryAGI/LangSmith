#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Create Run<br/>
        /// Create a new run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateRunApiV1RunsPostResponse> CreateRunAsync(
            global::LangSmith.CreateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Run<br/>
        /// Create a new run.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputs"></param>
        /// <param name="runType"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="error"></param>
        /// <param name="serialized"></param>
        /// <param name="outputs"></param>
        /// <param name="parentRunId"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="referenceExampleId"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="outputAttachments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateRunApiV1RunsPostResponse> CreateRunAsync(
            string name,
            global::LangSmith.CreateRunRequestRunType runType,
            global::LangSmith.OneOf<object, object>? inputs = default,
            global::LangSmith.OneOf<string, double?, object>? startTime = default,
            global::LangSmith.OneOf<string, double?, object>? endTime = default,
            global::LangSmith.OneOf<object, object>? extra = default,
            global::LangSmith.OneOf<string, object>? error = default,
            global::LangSmith.OneOf<object, object>? serialized = default,
            global::LangSmith.OneOf<object, object>? outputs = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? parentRunId = default,
            global::LangSmith.OneOf<global::System.Collections.Generic.IList<object>, object>? events = default,
            global::LangSmith.OneOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? traceId = default,
            global::LangSmith.OneOf<string, object>? dottedOrder = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? id = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? sessionId = default,
            global::LangSmith.OneOf<string, object>? sessionName = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? referenceExampleId = default,
            global::LangSmith.OneOf<object, object>? inputAttachments = default,
            global::LangSmith.OneOf<object, object>? outputAttachments = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}