
#nullable enable

namespace LangSmith
{
    public partial class ReposClient
    {
        partial void PrepareListReposArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? withLatestManifest,
            ref int? limit,
            ref int? offset,
            ref string? tenantHandle,
            ref global::System.Guid? tenantId,
            ref string? query,
            ref bool? hasCommits,
            global::System.Collections.Generic.IList<string>? tags,
            ref global::LangSmith.ListReposApiV1ReposGetIsArchived? isArchived,
            ref global::LangSmith.ListReposApiV1ReposGetIsPublic? isPublic,
            ref string? upstreamRepoOwner,
            ref string? upstreamRepoHandle,
            ref bool? matchPrefix,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId,
            ref string? sortField,
            ref global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1?, global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2?>? sortDirection);
        partial void PrepareListReposRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? withLatestManifest,
            int? limit,
            int? offset,
            string? tenantHandle,
            global::System.Guid? tenantId,
            string? query,
            bool? hasCommits,
            global::System.Collections.Generic.IList<string>? tags,
            global::LangSmith.ListReposApiV1ReposGetIsArchived? isArchived,
            global::LangSmith.ListReposApiV1ReposGetIsPublic? isPublic,
            string? upstreamRepoOwner,
            string? upstreamRepoHandle,
            bool? matchPrefix,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId,
            string? sortField,
            global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1?, global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2?>? sortDirection);
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
        /// <param name="matchPrefix">
        /// Default Value: false
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ListReposResponse> ListReposAsync(
            bool? withLatestManifest = false,
            int? limit = 20,
            int? offset = 0,
            string? tenantHandle = default,
            global::System.Guid? tenantId = default,
            string? query = default,
            bool? hasCommits = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::LangSmith.ListReposApiV1ReposGetIsArchived? isArchived = default,
            global::LangSmith.ListReposApiV1ReposGetIsPublic? isPublic = default,
            string? upstreamRepoOwner = default,
            string? upstreamRepoHandle = default,
            bool? matchPrefix = false,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            string? sortField = default,
            global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1?, global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2?>? sortDirection = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListReposArguments(
                httpClient: HttpClient,
                withLatestManifest: ref withLatestManifest,
                limit: ref limit,
                offset: ref offset,
                tenantHandle: ref tenantHandle,
                tenantId: ref tenantId,
                query: ref query,
                hasCommits: ref hasCommits,
                tags: tags,
                isArchived: ref isArchived,
                isPublic: ref isPublic,
                upstreamRepoOwner: ref upstreamRepoOwner,
                upstreamRepoHandle: ref upstreamRepoHandle,
                matchPrefix: ref matchPrefix,
                tagValueId: tagValueId,
                sortField: ref sortField,
                sortDirection: ref sortDirection);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/repos",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("with_latest_manifest", withLatestManifest?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("tenant_handle", tenantHandle) 
                .AddOptionalParameter("tenant_id", tenantId?.ToString()) 
                .AddOptionalParameter("query", query) 
                .AddOptionalParameter("has_commits", hasCommits?.ToString()) 
                .AddOptionalParameter("tags", tags, delimiter: ",", explode: true) 
                .AddOptionalParameter("is_archived", isArchived?.ToValueString()) 
                .AddOptionalParameter("is_public", isPublic?.ToValueString()) 
                .AddOptionalParameter("upstream_repo_owner", upstreamRepoOwner) 
                .AddOptionalParameter("upstream_repo_handle", upstreamRepoHandle) 
                .AddOptionalParameter("match_prefix", matchPrefix?.ToString()) 
                .AddOptionalParameter("tag_value_id", tagValueId, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("sort_field", sortField) 
                .AddOptionalParameter("sort_direction", sortDirection?.ToString() ?? string.Empty) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListReposRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                withLatestManifest: withLatestManifest,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListReposResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessListReposResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::LangSmith.ListReposResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}