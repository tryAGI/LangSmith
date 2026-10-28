#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Populate Annotation Queue<br/>
        /// Populate annotation queue with runs from an experiment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PopulateAnnotationQueueAsync(

            global::LangSmith.PopulateAnnotationQueueSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Populate Annotation Queue<br/>
        /// Populate annotation queue with runs from an experiment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> PopulateAnnotationQueueAsResponseAsync(

            global::LangSmith.PopulateAnnotationQueueSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Populate Annotation Queue<br/>
        /// Populate annotation queue with runs from an experiment.
        /// </summary>
        /// <param name="queueId">
        /// ID of the annotation queue to add runs to.
        /// </param>
        /// <param name="sessionIds">
        /// Experiments whose runs are added to the queue. Each must be an experiment on a dataset.
        /// </param>
        /// <param name="extendTraceRetention">
        /// Upgrade the added traces from short-lived to extended retention.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PopulateAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            bool? extendTraceRetention = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}