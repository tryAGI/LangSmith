#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a warm pool<br/>
        /// Create a new warm pool from a template with a specified replica count
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesPoolResponse> CreateAWarmPoolAsync(

            global::LangSmith.SandboxesCreatePoolPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a warm pool<br/>
        /// Create a new warm pool from a template with a specified replica count
        /// </summary>
        /// <param name="name"></param>
        /// <param name="replicas"></param>
        /// <param name="templateName"></param>
        /// <param name="timeout"></param>
        /// <param name="waitForReady"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesPoolResponse> CreateAWarmPoolAsync(
            string name,
            int replicas,
            string templateName,
            int? timeout = default,
            bool? waitForReady = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}