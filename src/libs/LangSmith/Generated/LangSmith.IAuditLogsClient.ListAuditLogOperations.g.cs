#nullable enable

namespace LangSmith
{
    public partial interface IAuditLogsClient
    {
        /// <summary>
        /// List Audit Log Operations<br/>
        /// List all possible audit log operation names, for populating filter UI.<br/>
        /// Independent of any operations actually recorded so far for the organization.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListAuditLogOperationsResponse> ListAuditLogOperationsAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Audit Log Operations<br/>
        /// List all possible audit log operation names, for populating filter UI.<br/>
        /// Independent of any operations actually recorded so far for the organization.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ListAuditLogOperationsResponse>> ListAuditLogOperationsAsResponseAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}