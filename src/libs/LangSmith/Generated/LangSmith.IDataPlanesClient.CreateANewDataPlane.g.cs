#nullable enable

namespace LangSmith
{
    public partial interface IDataPlanesClient
    {
        /// <summary>
        /// Create a new data plane<br/>
        /// Creates a new data plane object. Persists the rendered data plane spec, and returns 202 with the data plane in status=requested. Requires BYOC enabled org and org admin.<br/>
        /// Uses the organization's assigned external ID to assume the AWS role. Configure that ID in the role's trust policy before creating a data plane.
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
        /// Creates a new data plane object. Persists the rendered data plane spec, and returns 202 with the data plane in status=requested. Requires BYOC enabled org and org admin.<br/>
        /// Uses the organization's assigned external ID to assume the AWS role. Configure that ID in the role's trust policy before creating a data plane.
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
        /// Creates a new data plane object. Persists the rendered data plane spec, and returns 202 with the data plane in status=requested. Requires BYOC enabled org and org admin.<br/>
        /// Uses the organization's assigned external ID to assume the AWS role. Configure that ID in the role's trust policy before creating a data plane.
        /// </summary>
        /// <param name="byovpcId">
        /// The ID of the customer-managed VPC to deploy into when deploying in BYOVPC mode.
        /// </param>
        /// <param name="byovpcPrivateAppSubnetIds">
        /// The subnet IDs of the private app subnets to deploy into when deploying in BYOVPC mode.
        /// </param>
        /// <param name="byovpcPrivateDbSubnetIds">
        /// The subnet IDs of the private database subnets to deploy into when deploying in BYOVPC mode.
        /// </param>
        /// <param name="byovpcPublicSubnetIds">
        /// The subnet IDs of the optional public subnets to deploy into when deploying in BYOVPC mode.
        /// </param>
        /// <param name="name"></param>
        /// <param name="publicLoadBalancer"></param>
        /// <param name="region"></param>
        /// <param name="roleArn"></param>
        /// <param name="vpcCidr">
        /// VPCCIDR is used only when LangSmith creates the VPC.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DataPlanesPublicDataPlane> CreateANewDataPlaneAsync(
            string? byovpcId = default,
            global::System.Collections.Generic.IList<string>? byovpcPrivateAppSubnetIds = default,
            global::System.Collections.Generic.IList<string>? byovpcPrivateDbSubnetIds = default,
            global::System.Collections.Generic.IList<string>? byovpcPublicSubnetIds = default,
            string? name = default,
            bool? publicLoadBalancer = default,
            string? region = default,
            string? roleArn = default,
            string? vpcCidr = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}