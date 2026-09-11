#nullable enable

namespace LangSmith
{
    public partial interface IProductfeedbackClient
    {
        /// <summary>
        /// [Alpha] Get product feedback<br/>
        /// **Alpha:** This endpoint is in active development and may change without notice.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.ProductfeedbackProductFeedback> GetProductFeedbackAsync(
            global::System.Guid id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Alpha] Get product feedback<br/>
        /// **Alpha:** This endpoint is in active development and may change without notice.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ProductfeedbackProductFeedback>> GetProductFeedbackAsResponseAsync(
            global::System.Guid id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}