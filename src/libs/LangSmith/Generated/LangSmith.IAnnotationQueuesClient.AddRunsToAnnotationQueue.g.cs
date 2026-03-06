#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Add Runs To Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>> AddRunsToAnnotationQueueAsync(
            global::System.Guid queueId,

            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Runs To Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>> AddRunsToAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}