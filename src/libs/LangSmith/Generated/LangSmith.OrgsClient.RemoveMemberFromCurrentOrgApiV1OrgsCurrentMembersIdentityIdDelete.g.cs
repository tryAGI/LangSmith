
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareRemoveMemberFromCurrentOrgApiV1OrgsCurrentMembersIdentityIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string identityId);
        partial void PrepareRemoveMemberFromCurrentOrgApiV1OrgsCurrentMembersIdentityIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string identityId);
        partial void ProcessRemoveMemberFromCurrentOrgApiV1OrgsCurrentMembersIdentityIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRemoveMemberFromCurrentOrgApiV1OrgsCurrentMembersIdentityIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove Member From Current Org<br/>
        /// Remove a user from the current organization.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.RemoveMemberFromCurrentOrgApiV1OrgsCurrentMembersIdentityIdDeleteResponse> RemoveMemberFromCurrentOrgApiV1OrgsCurrentMembersIdentityIdDeleteAsync(
            string identityId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareRemoveMemberFromCurrentOrgApiV1OrgsCurrentMembersIdentityIdDeleteArguments(
                httpClient: _httpClient,
                identityId: ref identityId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/orgs/current/members/{identityId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareRemoveMemberFromCurrentOrgApiV1OrgsCurrentMembersIdentityIdDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                identityId: identityId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessRemoveMemberFromCurrentOrgApiV1OrgsCurrentMembersIdentityIdDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessRemoveMemberFromCurrentOrgApiV1OrgsCurrentMembersIdentityIdDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.RemoveMemberFromCurrentOrgApiV1OrgsCurrentMembersIdentityIdDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}