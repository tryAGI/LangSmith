#nullable enable

namespace LangSmith
{
    public partial interface IDataPlanesClient
    {
        /// <summary>
        /// Create a new data plane<br/>
        /// Creates a new data plane object. Persists the rendered data plane spec, and returns 202 with the data plane in status=requested. Requires BYOC enabled org and org admin.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DataPlanesPublicDataPlane> CreateANewDataPlaneAsync(

            global::LangSmith.DataPlanesCreateDataPlaneRequestAws request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new data plane<br/>
        /// Creates a new data plane object. Persists the rendered data plane spec, and returns 202 with the data plane in status=requested. Requires BYOC enabled org and org admin.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DataPlanesPublicDataPlane>> CreateANewDataPlaneAsResponseAsync(

            global::LangSmith.DataPlanesCreateDataPlaneRequestAws request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new data plane<br/>
        /// Creates a new data plane object. Persists the rendered data plane spec, and returns 202 with the data plane in status=requested. Requires BYOC enabled org and org admin.
        /// </summary>
        /// <param name="externalId"></param>
        /// <param name="name"></param>
        /// <param name="publicLoadBalancer"></param>
        /// <param name="region"></param>
        /// <param name="roleArn"></param>
        /// <param name="vpcCidr"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DataPlanesPublicDataPlane> CreateANewDataPlaneAsync(
            string? externalId = default,
            string? name = default,
            bool? publicLoadBalancer = default,
            string? region = default,
            string? roleArn = default,
            string? vpcCidr = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}