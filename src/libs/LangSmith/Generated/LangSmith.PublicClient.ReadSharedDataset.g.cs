
#nullable enable

namespace LangSmith
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedDatasetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            ref int? offset,
            ref int? limit,
            ref global::LangSmith.SortByDatasetColumn? sortBy,
            ref bool? sortByDesc);
        partial void PrepareReadSharedDatasetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            int? offset,
            int? limit,
            global::LangSmith.SortByDatasetColumn? sortBy,
            bool? sortByDesc);
        partial void ProcessReadSharedDatasetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedDatasetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Dataset<br/>
        /// Get dataset by ids or the shared dataset if not specifed.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sortBy">
        /// Enum for available dataset columns to sort by.
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DatasetPublicSchema> ReadSharedDatasetAsync(
            global::System.Guid shareToken,
            int? offset = 0,
            int? limit = 100,
            global::LangSmith.SortByDatasetColumn? sortBy = default,
            bool? sortByDesc = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReadSharedDatasetArguments(
                httpClient: HttpClient,
                shareToken: ref shareToken,
                offset: ref offset,
                limit: ref limit,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/public/{shareToken}/datasets",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("sort_by", sortBy?.ToValueString()) 
                .AddOptionalParameter("sort_by_desc", sortByDesc?.ToString()) 
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
            PrepareReadSharedDatasetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                shareToken: shareToken,
                offset: offset,
                limit: limit,
                sortBy: sortBy,
                sortByDesc: sortByDesc);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReadSharedDatasetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReadSharedDatasetResponseContent(
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
                global::LangSmith.DatasetPublicSchema.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}