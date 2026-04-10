#nullable enable

namespace LangSmith
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Proxy Get
        /// </summary>
        /// <param name="url"></param>
        /// <param name="acceptStream">
        /// Default Value: true
        /// </param>
        /// <param name="timeout">
        /// Default Value: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyGetAsync(
            string url,
            bool? acceptStream = default,
            int? timeout = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}