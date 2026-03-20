#nullable enable

namespace LangSmith
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Proxy
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyAsync(

            global::LangSmith.ProxyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method">
        /// Default Value: GET
        /// </param>
        /// <param name="headers">
        /// Default Value: {}
        /// </param>
        /// <param name="timeout">
        /// Default Value: 120
        /// </param>
        /// <param name="body"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyAsync(
            string url,
            global::LangSmith.ProxyRequestMethod? method = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            int? timeout = default,
            object? body = default,
            string? oauthProviderId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}