#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Update a sandbox<br/>
        /// Update a sandbox's display name. The name must be unique within the tenant.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSandboxResponse> UpdateASandboxAsync(
            string name,

            global::LangSmith.SandboxesUpdateSandboxPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a sandbox<br/>
        /// Update a sandbox's display name. The name must be unique within the tenant.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesSandboxResponse>> UpdateASandboxAsResponseAsync(
            string name,

            global::LangSmith.SandboxesUpdateSandboxPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a sandbox<br/>
        /// Update a sandbox's display name. The name must be unique within the tenant.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cpuMillicores"></param>
        /// <param name="deleteAfterStopSeconds"></param>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="memBytes"></param>
        /// <param name="requestName"></param>
        /// <param name="proxyConfig"></param>
        /// <param name="tagValueIds"></param>
        /// <param name="vcpus"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSandboxResponse> UpdateASandboxAsync(
            string name,
            int? cpuMillicores = default,
            int? deleteAfterStopSeconds = default,
            long? fsCapacityBytes = default,
            int? idleTtlSeconds = default,
            long? memBytes = default,
            string? requestName = default,
            global::LangSmith.SandboxesProxyConfig? proxyConfig = default,
            global::System.Collections.Generic.IList<string>? tagValueIds = default,
            int? vcpus = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}