
#nullable enable

namespace LangSmith
{
    public partial class TenantClient
    {
        partial void PrepareBulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.TenantBulkUnshareRequest request);
        partial void PrepareBulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.TenantBulkUnshareRequest request);
        partial void ProcessBulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Bulk Unshare Entities<br/>
        /// Deprecated: replaced by /workspaces/current/shared
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::LangSmith.BulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteResponse> BulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteAsync(
            global::LangSmith.TenantBulkUnshareRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareBulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/tenants/current/shared", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.TenantBulkUnshareRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareBulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteRequest(
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
            ProcessBulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessBulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.BulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Bulk Unshare Entities<br/>
        /// Deprecated: replaced by /workspaces/current/shared
        /// </summary>
        /// <param name="shareTokens"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::LangSmith.BulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteResponse> BulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteAsync(
            global::System.Collections.Generic.IList<string>? shareTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.TenantBulkUnshareRequest
            {
                ShareTokens = shareTokens,
            };

            return await BulkUnshareEntitiesApiV1TenantsCurrentSharedDeleteAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}