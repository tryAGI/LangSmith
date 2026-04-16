#nullable enable

namespace LangSmith
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List Repos<br/>
        /// Get all repos.
        /// </summary>
        /// <param name="withLatestManifest">
        /// Default Value: false
        /// </param>
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
        /// <param name="tagValueId"></param>
        /// <param name="repoType"></param>
        /// <param name="repoTypes"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListReposResponse> ListReposAsync(
            bool? withLatestManifest = default,
            int? limit = default,
            int? offset = default,
            string? tenantHandle = default,
            global::System.Guid? tenantId = default,
            string? query = default,
            bool? hasCommits = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::LangSmith.ListReposApiV1ReposGetIsArchived2? isArchived = default,
            global::LangSmith.TrueFalseLiteral? isPublic = default,
            string? upstreamRepoOwner = default,
            string? upstreamRepoHandle = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::LangSmith.ListReposApiV1ReposGetRepoType2? repoType = default,
            global::System.Collections.Generic.IList<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>? repoTypes = default,
            global::LangSmith.ListReposApiV1ReposGetSortField2? sortField = default,
            global::LangSmith.AnyOf<string, string, object>? sortDirection = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}