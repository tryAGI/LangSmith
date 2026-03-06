#nullable enable

namespace LangSmith
{
    public partial interface IAccessPoliciesClient
    {
        /// <summary>
        /// Create an access policy<br/>
        /// Creates a new access policy.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthzInternalAccessPolicyCreateResponse> CreateAnAccessPolicyAsync(

            global::LangSmith.AuthzInternalCreateAccessPolicyPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an access policy<br/>
        /// Creates a new access policy.
        /// </summary>
        /// <param name="conditionGroups"></param>
        /// <param name="description"></param>
        /// <param name="effect"></param>
        /// <param name="name"></param>
        /// <param name="roleIds">
        /// if present, attach to the specified roles
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthzInternalAccessPolicyCreateResponse> CreateAnAccessPolicyAsync(
            global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>? conditionGroups = default,
            string? description = default,
            string? effect = default,
            string? name = default,
            global::System.Collections.Generic.IList<string>? roleIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}