#nullable enable

namespace LangSmith
{
    public partial interface IProductfeedbackClient
    {
        /// <summary>
        /// [Alpha] Submit product feedback<br/>
        /// **Alpha:** This endpoint is in active development and may change without notice.<br/>
        /// Submits concise product feedback with optional non-sensitive client details.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.ProductfeedbackProductFeedback> SubmitProductFeedbackAsync(

            global::LangSmith.ProductfeedbackCreateRequest request,
            string? idempotencyKey = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Alpha] Submit product feedback<br/>
        /// **Alpha:** This endpoint is in active development and may change without notice.<br/>
        /// Submits concise product feedback with optional non-sensitive client details.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ProductfeedbackProductFeedback>> SubmitProductFeedbackAsResponseAsync(

            global::LangSmith.ProductfeedbackCreateRequest request,
            string? idempotencyKey = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Alpha] Submit product feedback<br/>
        /// **Alpha:** This endpoint is in active development and may change without notice.<br/>
        /// Submits concise product feedback with optional non-sensitive client details.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="category"></param>
        /// <param name="client"></param>
        /// <param name="message"></param>
        /// <param name="source"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.ProductfeedbackProductFeedback> SubmitProductFeedbackAsync(
            global::LangSmith.ProductfeedbackCategory category,
            string message,
            string? idempotencyKey = default,
            global::LangSmith.ProductfeedbackClientContext? client = default,
            global::LangSmith.ProductfeedbackSource source = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}