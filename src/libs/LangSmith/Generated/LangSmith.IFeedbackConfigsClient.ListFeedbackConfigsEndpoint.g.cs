#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackConfigsClient
    {
        /// <summary>
        /// List Feedback Configs Endpoint
        /// </summary>
        /// <param name="key"></param>
        /// <param name="nameContains"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit"></param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="readAfterWrite">
        /// Default Value: false
        /// </param>
        /// <param name="includeAllConfigs">
        /// Return every config of each key, deleted ones included, instead of one config per key. Pages of up to 100 configs unless ``limit`` is set; ``X-Pagination-Total`` gives the full count.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>> ListFeedbackConfigsEndpointAsync(
            global::System.Collections.Generic.IList<string>? key = default,
            string? nameContains = default,
            int? offset = default,
            int? limit = default,
            bool? sortByDesc = default,
            bool? readAfterWrite = default,
            bool? includeAllConfigs = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Feedback Configs Endpoint
        /// </summary>
        /// <param name="key"></param>
        /// <param name="nameContains"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit"></param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="readAfterWrite">
        /// Default Value: false
        /// </param>
        /// <param name="includeAllConfigs">
        /// Return every config of each key, deleted ones included, instead of one config per key. Pages of up to 100 configs unless ``limit`` is set; ``X-Pagination-Total`` gives the full count.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>>> ListFeedbackConfigsEndpointAsResponseAsync(
            global::System.Collections.Generic.IList<string>? key = default,
            string? nameContains = default,
            int? offset = default,
            int? limit = default,
            bool? sortByDesc = default,
            bool? readAfterWrite = default,
            bool? includeAllConfigs = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}