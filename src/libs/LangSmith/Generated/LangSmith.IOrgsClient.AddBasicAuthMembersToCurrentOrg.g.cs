#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Add Basic Auth Members To Current Org<br/>
        /// Batch add up to 500 users to the org and specified workspaces in basic auth mode.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>> AddBasicAuthMembersToCurrentOrgAsync(
            global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}