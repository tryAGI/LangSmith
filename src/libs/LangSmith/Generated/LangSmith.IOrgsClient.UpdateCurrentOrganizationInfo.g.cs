#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update Current Organization Info
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrganizationInfo> UpdateCurrentOrganizationInfoAsync(
            global::LangSmith.OrganizationUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Current Organization Info
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrganizationInfo> UpdateCurrentOrganizationInfoAsync(
            global::LangSmith.AnyOf<string, object>? displayName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}