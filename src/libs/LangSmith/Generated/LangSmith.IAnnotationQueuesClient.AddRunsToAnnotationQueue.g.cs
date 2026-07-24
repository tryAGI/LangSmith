#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Add Runs To Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="extendTraceRetention">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>> AddRunsToAnnotationQueueAsync(
            global::System.Guid queueId,

            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>> request,
            bool? extendTraceRetention = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Runs To Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="extendTraceRetention">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>>> AddRunsToAnnotationQueueAsResponseAsync(
            global::System.Guid queueId,

            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>> request,
            bool? extendTraceRetention = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Runs To Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="extendTraceRetention">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>> AddRunsToAnnotationQueueAsync(
            global::System.Guid queueId,
            bool? extendTraceRetention = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}