#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update Current User<br/>
        /// Update a user's full_name/password (basic auth only)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateCurrentUserApiV1OrgsMembersBasicPatchResponse> UpdateCurrentUserAsync(
            global::LangSmith.BasicAuthUserPatch request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Current User<br/>
        /// Update a user's full_name/password (basic auth only)
        /// </summary>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateCurrentUserApiV1OrgsMembersBasicPatchResponse> UpdateCurrentUserAsync(
            global::LangSmith.AnyOf<string, object>? password = default,
            global::LangSmith.AnyOf<string, object>? fullName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}