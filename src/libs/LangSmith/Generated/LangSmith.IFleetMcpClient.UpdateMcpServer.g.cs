#nullable enable

namespace LangSmith
{
    public partial interface IFleetMcpClient
    {
        /// <summary>
        /// Update MCP server<br/>
        /// Partially updates an MCP server. Tool list cache is invalidated on success.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.LangchainComSmithFleetMcpServersMcpServer> UpdateMcpServerAsync(

            global::LangSmith.LangchainComSmithFleetMcpServersUpdateMcpServerPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update MCP server<br/>
        /// Partially updates an MCP server. Tool list cache is invalidated on success.
        /// </summary>
        /// <param name="authType"></param>
        /// <param name="headers"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.LangchainComSmithFleetMcpServersMcpServer> UpdateMcpServerAsync(
            global::LangSmith.LangchainComSmithFleetMcpServersAuthType? authType = default,
            global::System.Collections.Generic.IList<object>? headers = default,
            string? oauthProviderId = default,
            string? url = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}