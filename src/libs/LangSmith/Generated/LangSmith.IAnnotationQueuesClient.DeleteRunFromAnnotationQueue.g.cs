#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Delete Run From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="queueRunId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunFromAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.Guid queueRunId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}