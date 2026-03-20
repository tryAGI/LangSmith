#nullable enable

namespace LangSmith
{
    public partial interface IAccessPoliciesClient
    {

        /// <summary>
        /// Get an access policy<br/>
        /// Gets a specific access policy by ID.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthzInternalAccessPolicy> GetAnAccessPolicyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}