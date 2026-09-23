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
        /// <param name="additionalTags"></param>
        /// <param name="byoiamEnabled">
        /// Use customer-managed IAM roles created by the LangSmith BYOIAM Terraform module.
        /// </param>
        /// <param name="byovpc"></param>
        /// <param name="eksApiPrivatelinkDisabled">
        /// Use a public EKS API endpoint restricted to LangSmith control-plane egress IPs instead of creating a managed PrivateLink endpoint service. Defaults to false.
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
            global::System.Collections.Generic.IList<global::LangSmith.AwsResourceTag>? additionalTags = default,
            bool? byoiamEnabled = default,
            global::LangSmith.DataPlanesDataPlaneBYOVPCSettings? byovpc = default,
            bool? eksApiPrivatelinkDisabled = default,
            string? name = default,
            bool? publicLoadBalancer = default,
            string? region = default,
            string? roleArn = default,
            string? vpcCidr = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}