#nullable enable

namespace LangSmith
{
    public partial interface IFleetTriggerTemplatesClient
    {
        /// <summary>
        /// Get trigger template<br/>
        /// Returns a single trigger template by id.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task GetTriggerTemplateAsync(
            string templateId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get trigger template<br/>
        /// Returns a single trigger template by id.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> GetTriggerTemplateAsResponseAsync(
            string templateId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}