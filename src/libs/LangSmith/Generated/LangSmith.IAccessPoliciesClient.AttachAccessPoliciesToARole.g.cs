#nullable enable

namespace LangSmith
{
    public partial interface IAccessPoliciesClient
    {

        /// <summary>
        /// Attach access policies to a role<br/>
        /// Attaches one or more access policies to a specific role. The request body must contain an array of access policy IDs.
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task AttachAccessPoliciesToARoleAsync(

            global::LangSmith.AuthzInternalAttachAccessPoliciesPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Attach access policies to a role<br/>
        /// Attaches one or more access policies to a specific role. The request body must contain an array of access policy IDs.
        /// </summary>
        /// <param name="accessPolicyIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AttachAccessPoliciesToARoleAsync(
            global::System.Collections.Generic.IList<string>? accessPolicyIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}