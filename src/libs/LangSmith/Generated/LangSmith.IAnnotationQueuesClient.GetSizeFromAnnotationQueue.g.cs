#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get Size From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnnotationQueueSizeSchema> GetSizeFromAnnotationQueueAsync(
            global::System.Guid queueId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}