#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Query public shared trace runs<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Returns all runs within the trace identified by the share token. The share token supplies the tenant, project, and trace scope.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryQueryTraceResponseBody> QueryPublicSharedTraceRunsAsync(
            global::System.Guid shareToken,

            global::LangSmith.QueryPublicSharedTraceRunsRequestBody request,
            string? accept = default,
            string? contentType = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query public shared trace runs<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Returns all runs within the trace identified by the share token. The share token supplies the tenant, project, and trace scope.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.QueryQueryTraceResponseBody>> QueryPublicSharedTraceRunsAsResponseAsync(
            global::System.Guid shareToken,

            global::LangSmith.QueryPublicSharedTraceRunsRequestBody request,
            string? accept = default,
            string? contentType = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query public shared trace runs<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Returns all runs within the trace identified by the share token. The share token supplies the tenant, project, and trace scope.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="shareToken"></param>
        /// <param name="selects">
        /// `selects` lists which public run properties to include on each returned run.<br/>
        /// Example: [ID, NAME, PROJECT_ID, START_TIME, RUN_TYPE, STATUS, INPUTS_PREVIEW, OUTPUTS_PREVIEW, METADATA]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryQueryTraceResponseBody> QueryPublicSharedTraceRunsAsync(
            global::System.Guid shareToken,
            string? accept = default,
            string? contentType = default,
            global::System.Collections.Generic.IList<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>? selects = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}