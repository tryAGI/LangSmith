
#nullable enable

namespace LangSmith
{
    public partial class WorkspacesClient
    {
        partial void PrepareBulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.TenantBulkUnshareRequest request);
        partial void PrepareBulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.TenantBulkUnshareRequest request);
        partial void ProcessBulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Bulk Unshare Entities<br/>
        /// Bulk unshare entities by share tokens for the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponse> BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteAsync(
            global::LangSmith.TenantBulkUnshareRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareBulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/workspaces/current/shared", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.TenantBulkUnshareRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareBulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessBulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessBulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Bulk Unshare Entities<br/>
        /// Bulk unshare entities by share tokens for the workspace.
        /// </summary>
        /// <param name="shareTokens"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponse> BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteAsync(
            global::System.Collections.Generic.IList<string>? shareTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.TenantBulkUnshareRequest
            {
                ShareTokens = shareTokens,
            };

            return await BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}