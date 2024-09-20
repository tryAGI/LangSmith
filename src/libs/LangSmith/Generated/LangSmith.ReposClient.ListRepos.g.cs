
#nullable enable

namespace LangSmith
{
    public partial class ReposClient
    {
        partial void PrepareListReposArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref int? offset,
            ref global::LangSmith.AnyOf<string, object>? tenantHandle,
            ref global::LangSmith.AnyOf<global::System.Guid?, object>? tenantId,
            ref global::LangSmith.AnyOf<string, object>? query,
            ref global::LangSmith.AnyOf<bool?, object>? hasCommits,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? tags,
            ref global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetIsArchived2?, object>? isArchived,
            ref global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetIsPublic2?, object>? isPublic,
            ref global::LangSmith.AnyOf<string, object>? upstreamRepoOwner,
            ref global::LangSmith.AnyOf<string, object>? upstreamRepoHandle,
            ref global::LangSmith.AnyOf<bool?, object>? matchPrefix,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId,
            ref global::LangSmith.AnyOf<string, object>? sortField,
            ref global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1?, global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2?, object>? sortDirection);
        partial void PrepareListReposRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            int? offset,
            global::LangSmith.AnyOf<string, object>? tenantHandle,
            global::LangSmith.AnyOf<global::System.Guid?, object>? tenantId,
            global::LangSmith.AnyOf<string, object>? query,
            global::LangSmith.AnyOf<bool?, object>? hasCommits,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? tags,
            global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetIsArchived2?, object>? isArchived,
            global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetIsPublic2?, object>? isPublic,
            global::LangSmith.AnyOf<string, object>? upstreamRepoOwner,
            global::LangSmith.AnyOf<string, object>? upstreamRepoHandle,
            global::LangSmith.AnyOf<bool?, object>? matchPrefix,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId,
            global::LangSmith.AnyOf<string, object>? sortField,
            global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1?, global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2?, object>? sortDirection);
        partial void ProcessListReposResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListReposResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::LangSmith.ListReposResponse> ListReposAsync(
            int? limit = 20,
            int? offset = 0,
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListReposArguments(
                httpClient: _httpClient,
                limit: ref limit,
                offset: ref offset,
                tenantHandle: ref tenantHandle,
                tenantId: ref tenantId,
                query: ref query,
                hasCommits: ref hasCommits,
                tags: ref tags,
                isArchived: ref isArchived,
                isPublic: ref isPublic,
                upstreamRepoOwner: ref upstreamRepoOwner,
                upstreamRepoHandle: ref upstreamRepoHandle,
                matchPrefix: ref matchPrefix,
                tagValueId: ref tagValueId,
                sortField: ref sortField,
                sortDirection: ref sortDirection);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/repos",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("tenant_handle", tenantHandle?.ToString() ?? string.Empty) 
                .AddOptionalParameter("tenant_id", tenantId?.ToString() ?? string.Empty) 
                .AddOptionalParameter("query", query?.ToString() ?? string.Empty) 
                .AddOptionalParameter("has_commits", hasCommits?.ToString() ?? string.Empty) 
                .AddOptionalParameter("tags", tags?.ToString() ?? string.Empty) 
                .AddOptionalParameter("is_archived", isArchived?.ToString() ?? string.Empty) 
                .AddOptionalParameter("is_public", isPublic?.ToString() ?? string.Empty) 
                .AddOptionalParameter("upstream_repo_owner", upstreamRepoOwner?.ToString() ?? string.Empty) 
                .AddOptionalParameter("upstream_repo_handle", upstreamRepoHandle?.ToString() ?? string.Empty) 
                .AddOptionalParameter("match_prefix", matchPrefix?.ToString() ?? string.Empty) 
                .AddOptionalParameter("tag_value_id", tagValueId?.ToString() ?? string.Empty) 
                .AddOptionalParameter("sort_field", sortField?.ToString() ?? string.Empty) 
                .AddOptionalParameter("sort_direction", sortDirection?.ToString() ?? string.Empty) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListReposRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                limit: limit,
                offset: offset,
                tenantHandle: tenantHandle,
                tenantId: tenantId,
                query: query,
                hasCommits: hasCommits,
                tags: tags,
                isArchived: isArchived,
                isPublic: isPublic,
                upstreamRepoOwner: upstreamRepoOwner,
                upstreamRepoHandle: upstreamRepoHandle,
                matchPrefix: matchPrefix,
                tagValueId: tagValueId,
                sortField: sortField,
                sortDirection: sortDirection);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListReposResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListReposResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.ListReposResponse), JsonSerializerContext) as global::LangSmith.ListReposResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}