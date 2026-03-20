#nullable enable

namespace LangSmith
{
    public partial interface IMetricsClient
    {

        /// <summary>
        /// Get Queue Metrics<br/>
        /// Return cached SAQ queue counts for the requested queue.
        /// </summary>
        /// <param name="queueName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueueInfoResponse> GetQueueMetricsAsync(
            string queueName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}