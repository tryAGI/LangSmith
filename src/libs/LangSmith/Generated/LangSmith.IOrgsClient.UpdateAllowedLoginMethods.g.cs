#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update Allowed Login Methods<br/>
        /// Update allowed login methods for the current organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateAllowedLoginMethodsApiV1OrgsCurrentLoginMethodsPatchResponse> UpdateAllowedLoginMethodsAsync(
            global::LangSmith.AllowedLoginMethodsUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Allowed Login Methods<br/>
        /// Update allowed login methods for the current organization.
        /// </summary>
        /// <param name="ssoOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateAllowedLoginMethodsApiV1OrgsCurrentLoginMethodsPatchResponse> UpdateAllowedLoginMethodsAsync(
            bool ssoOnly,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}