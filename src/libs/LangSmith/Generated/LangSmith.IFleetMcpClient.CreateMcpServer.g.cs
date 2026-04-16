#nullable enable

namespace LangSmith
{
    public partial interface IFleetMcpClient
    {
        /// <summary>
        /// Create MCP server<br/>
        /// Registers a new MCP server configuration for the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.LangchainComSmithFleetMcpServersMcpServer> CreateMcpServerAsync(

            global::LangSmith.LangchainComSmithFleetMcpServersCreateMcpServerPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create MCP server<br/>
        /// Registers a new MCP server configuration for the workspace.
        /// </summary>
        /// <param name="authType"></param>
        /// <param name="externalSystemId"></param>
        /// <param name="headers"></param>
        /// <param name="name"></param>
        /// <param name="oauthMode"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="url"></param>
        /// <param name="vendorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.LangchainComSmithFleetMcpServersMcpServer> CreateMcpServerAsync(
            string name,
            string url,
            global::LangSmith.LangchainComSmithFleetMcpServersAuthType? authType = default,
            string? externalSystemId = default,
            global::System.Collections.Generic.IList<object>? headers = default,
            global::LangSmith.LangchainComSmithFleetMcpServersOAuthMode? oauthMode = default,
            string? oauthProviderId = default,
            string? vendorId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}