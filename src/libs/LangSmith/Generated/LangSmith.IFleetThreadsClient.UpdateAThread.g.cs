#nullable enable

namespace LangSmith
{
    public partial interface IFleetThreadsClient
    {
        /// <summary>
        /// Update a thread<br/>
        /// Updates thread fields such as title and metadata. Omitted fields are unchanged; null values clear fields where supported.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsUpdateThreadResponse> UpdateAThreadAsync(
            string threadId,

            global::LangSmith.ThreadsUpdateThreadRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a thread<br/>
        /// Updates thread fields such as title and metadata. Omitted fields are unchanged; null values clear fields where supported.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadsUpdateThreadResponse>> UpdateAThreadAsResponseAsync(
            string threadId,

            global::LangSmith.ThreadsUpdateThreadRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a thread<br/>
        /// Updates thread fields such as title and metadata. Omitted fields are unchanged; null values clear fields where supported.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="metadata"></param>
        /// <param name="title"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsUpdateThreadResponse> UpdateAThreadAsync(
            string threadId,
            global::LangSmith.ThreadsUpdateThreadMetadata? metadata = default,
            global::LangSmith.ThreadsOptionalFieldString? title = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}