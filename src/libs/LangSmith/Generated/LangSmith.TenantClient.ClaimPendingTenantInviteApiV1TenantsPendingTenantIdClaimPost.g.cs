
#nullable enable

namespace LangSmith
{
    public partial class TenantClient
    {
        partial void PrepareClaimPendingTenantInviteApiV1TenantsPendingTenantIdClaimPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string tenantId);
        partial void PrepareClaimPendingTenantInviteApiV1TenantsPendingTenantIdClaimPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string tenantId);
        partial void ProcessClaimPendingTenantInviteApiV1TenantsPendingTenantIdClaimPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessClaimPendingTenantInviteApiV1TenantsPendingTenantIdClaimPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Claim Pending Tenant Invite<br/>
        /// Deprecated: replaced by /orgs/pending/{organization_id}/claim
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::LangSmith.ClaimPendingTenantInviteApiV1TenantsPendingTenantIdClaimPostResponse> ClaimPendingTenantInviteApiV1TenantsPendingTenantIdClaimPostAsync(
            string tenantId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareClaimPendingTenantInviteApiV1TenantsPendingTenantIdClaimPostArguments(
                httpClient: _httpClient,
                tenantId: ref tenantId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/tenants/pending/{tenantId}/claim", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareClaimPendingTenantInviteApiV1TenantsPendingTenantIdClaimPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                tenantId: tenantId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessClaimPendingTenantInviteApiV1TenantsPendingTenantIdClaimPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessClaimPendingTenantInviteApiV1TenantsPendingTenantIdClaimPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.ClaimPendingTenantInviteApiV1TenantsPendingTenantIdClaimPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}