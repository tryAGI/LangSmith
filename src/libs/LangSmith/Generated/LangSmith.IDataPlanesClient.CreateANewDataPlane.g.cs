#nullable enable

namespace LangSmith
{
    public partial interface IDataPlanesClient
    {
        /// <summary>
        /// Create a new data plane<br/>
        /// Creates a new data plane object. Persists the rendered data plane spec, and returns 202 with the data plane in status=requested. Requires BYOC enabled org and org admin.<br/>
        /// The cloud of the control plane selects the AWS or the Azure request. For AWS, the control plane uses the organization's assigned external ID to assume the AWS role. Configure that ID in the role's trust policy before creating a data plane. For Azure, the control plane uses the Entra tenant and the resource group in the request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DataPlanesPublicDataPlane> CreateANewDataPlaneAsync(

            global::LangSmith.DataPlanesCreateDataPlaneRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new data plane<br/>
        /// Creates a new data plane object. Persists the rendered data plane spec, and returns 202 with the data plane in status=requested. Requires BYOC enabled org and org admin.<br/>
        /// The cloud of the control plane selects the AWS or the Azure request. For AWS, the control plane uses the organization's assigned external ID to assume the AWS role. Configure that ID in the role's trust policy before creating a data plane. For Azure, the control plane uses the Entra tenant and the resource group in the request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DataPlanesPublicDataPlane>> CreateANewDataPlaneAsResponseAsync(

            global::LangSmith.DataPlanesCreateDataPlaneRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new data plane<br/>
        /// Creates a new data plane object. Persists the rendered data plane spec, and returns 202 with the data plane in status=requested. Requires BYOC enabled org and org admin.<br/>
        /// The cloud of the control plane selects the AWS or the Azure request. For AWS, the control plane uses the organization's assigned external ID to assume the AWS role. Configure that ID in the role's trust policy before creating a data plane. For Azure, the control plane uses the Entra tenant and the resource group in the request.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DataPlanesPublicDataPlane> CreateANewDataPlaneAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}