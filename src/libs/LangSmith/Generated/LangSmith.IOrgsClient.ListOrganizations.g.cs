#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List Organizations<br/>
        /// List memberships, or all organizations for instance admins opting in or using a PAT.
        /// </summary>
        /// <param name="skipCreate">
        /// Default Value: false
        /// </param>
        /// <param name="includeTier">
        /// Default Value: false
        /// </param>
        /// <param name="includeAll">
        /// List all organizations on the instance. Requires an instance administrator.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>> ListOrganizationsAsync(
            bool? skipCreate = default,
            bool? includeTier = default,
            bool? includeAll = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Organizations<br/>
        /// List memberships, or all organizations for instance admins opting in or using a PAT.
        /// </summary>
        /// <param name="skipCreate">
        /// Default Value: false
        /// </param>
        /// <param name="includeTier">
        /// Default Value: false
        /// </param>
        /// <param name="includeAll">
        /// List all organizations on the instance. Requires an instance administrator.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>>> ListOrganizationsAsResponseAsync(
            bool? skipCreate = default,
            bool? includeTier = default,
            bool? includeAll = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}