#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Get Run From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="index"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunSchemaWithAnnotationQueueInfo> GetRunFromAnnotationQueueAsync(
            global::System.Guid queueId,
            int index,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}