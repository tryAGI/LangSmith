#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {

        /// <summary>
        /// Resolve Annotation Queue Run<br/>
        /// Resolve a queue run ID to its section and run data for deep linking.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="queueRunId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ResolvedAnnotationQueueRunSchema> ResolveAnnotationQueueRunAsync(
            global::System.Guid queueId,
            global::System.Guid queueRunId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}