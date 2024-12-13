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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PopulateAnnotationQueueAsync(
            global::LangSmith.PopulateAnnotationQueueSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Populate Annotation Queue<br/>
        /// Populate annotation queue with runs from an experiment.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="sessionIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PopulateAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}