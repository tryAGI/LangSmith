#nullable enable

namespace LangSmith
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List Repos<br/>
        /// Get all repos.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tenantHandle"></param>
        /// <param name="tenantId"></param>
        /// <param name="query"></param>
        /// <param name="hasCommits"></param>
        /// <param name="tags"></param>
        /// <param name="isArchived"></param>
        /// <param name="isPublic"></param>
        /// <param name="upstreamRepoOwner"></param>
        /// <param name="upstreamRepoHandle"></param>
        /// <param name="matchPrefix">
        /// Default Value: false
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListReposResponse> ListReposAsync(
            int limit = 20,
            int offset = 0,
            global::LangSmith.AnyOf<string, object>? tenantHandle = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? tenantId = default,
            global::LangSmith.AnyOf<string, object>? query = default,
            global::LangSmith.AnyOf<bool?, object>? hasCommits = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetIsArchived2?, object>? isArchived = default,
            global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetIsPublic2?, object>? isPublic = default,
            global::LangSmith.AnyOf<string, object>? upstreamRepoOwner = default,
            global::LangSmith.AnyOf<string, object>? upstreamRepoHandle = default,
            global::LangSmith.AnyOf<bool?, object>? matchPrefix = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId = default,
            global::LangSmith.AnyOf<string, object>? sortField = default,
            global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1?, global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2?, object>? sortDirection = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}