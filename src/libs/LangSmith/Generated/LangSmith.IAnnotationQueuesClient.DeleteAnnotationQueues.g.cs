#nullable enable

namespace LangSmith
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Delete Annotation Queues<br/>
        /// Delete multiple annotation queues with partial success support.<br/>
        /// Returns:<br/>
        ///     - 200: All queues deleted successfully<br/>
        ///     - 207: Some queues deleted successfully, some failed
        /// </summary>
        /// <param name="queueIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAnnotationQueuesAsync(
            global::System.Collections.Generic.IList<global::System.Guid> queueIds,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}