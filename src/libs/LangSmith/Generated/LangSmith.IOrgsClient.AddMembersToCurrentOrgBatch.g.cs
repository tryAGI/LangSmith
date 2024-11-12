#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Add Members To Current Org Batch<br/>
        /// Batch invite up to 500 users to the current org.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>> AddMembersToCurrentOrgBatchAsync(
            global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}