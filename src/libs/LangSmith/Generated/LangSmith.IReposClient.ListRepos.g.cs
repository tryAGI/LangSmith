#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List Repos<br/>
        /// Get all repos.<br/>
        /// Page with page_size and cursor: pass next_cursor from the previous response<br/>
        /// as cursor until next_cursor is null. The limit and offset parameters are<br/>
        /// still accepted but cannot be combined with cursor.
        /// </summary>
        /// <param name="limit">
        /// Deprecated: use page_size and cursor.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Deprecated: use page_size and cursor.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Number of repos per page. Max 100.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Opaque cursor from the previous response's next_cursor. Omit for the first page. Cannot be combined with offset.
        /// </param>
        /// <param name="withLatestManifest">
        /// Default Value: false
        /// </param>
        /// <param name="includeOwners">
        /// Default Value: false
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
        /// <param name="source"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListReposResponse> ListReposAsync(
            int? limit = default,
            int? offset = default,
            int? pageSize = default,
            string? cursor = default,
            bool? withLatestManifest = default,
            bool? includeOwners = default,
            string? tenantHandle = default,
            global::System.Guid? tenantId = default,
            string? query = default,
            bool? hasCommits = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::LangSmith.ListReposApiV1ReposGetIsArchived? isArchived = default,
            global::LangSmith.TrueFalseLiteral? isPublic = default,
            string? upstreamRepoOwner = default,
            string? upstreamRepoHandle = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::LangSmith.ListReposApiV1ReposGetRepoType? repoType = default,
            global::System.Collections.Generic.IList<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>? repoTypes = default,
            global::LangSmith.ListReposApiV1ReposGetSource? source = default,
            global::LangSmith.ListReposApiV1ReposGetSortField? sortField = default,
            string? sortDirection = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Repos<br/>
        /// Get all repos.<br/>
        /// Page with page_size and cursor: pass next_cursor from the previous response<br/>
        /// as cursor until next_cursor is null. The limit and offset parameters are<br/>
        /// still accepted but cannot be combined with cursor.
        /// </summary>
        /// <param name="limit">
        /// Deprecated: use page_size and cursor.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Deprecated: use page_size and cursor.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Number of repos per page. Max 100.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Opaque cursor from the previous response's next_cursor. Omit for the first page. Cannot be combined with offset.
        /// </param>
        /// <param name="withLatestManifest">
        /// Default Value: false
        /// </param>
        /// <param name="includeOwners">
        /// Default Value: false
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
        /// <param name="source"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ListReposResponse>> ListReposAsResponseAsync(
            int? limit = default,
            int? offset = default,
            int? pageSize = default,
            string? cursor = default,
            bool? withLatestManifest = default,
            bool? includeOwners = default,
            string? tenantHandle = default,
            global::System.Guid? tenantId = default,
            string? query = default,
            bool? hasCommits = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::LangSmith.ListReposApiV1ReposGetIsArchived? isArchived = default,
            global::LangSmith.TrueFalseLiteral? isPublic = default,
            string? upstreamRepoOwner = default,
            string? upstreamRepoHandle = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::LangSmith.ListReposApiV1ReposGetRepoType? repoType = default,
            global::System.Collections.Generic.IList<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>? repoTypes = default,
            global::LangSmith.ListReposApiV1ReposGetSource? source = default,
            global::LangSmith.ListReposApiV1ReposGetSortField? sortField = default,
            string? sortDirection = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}