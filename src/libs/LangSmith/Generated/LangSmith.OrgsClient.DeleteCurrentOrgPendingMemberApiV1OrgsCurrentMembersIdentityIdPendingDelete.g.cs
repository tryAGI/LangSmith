
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareDeleteCurrentOrgPendingMemberApiV1OrgsCurrentMembersIdentityIdPendingDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string identityId);
        partial void PrepareDeleteCurrentOrgPendingMemberApiV1OrgsCurrentMembersIdentityIdPendingDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string identityId);
        partial void ProcessDeleteCurrentOrgPendingMemberApiV1OrgsCurrentMembersIdentityIdPendingDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteCurrentOrgPendingMemberApiV1OrgsCurrentMembersIdentityIdPendingDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Current Org Pending Member<br/>
        /// When an admin deletes a pending member invite.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DeleteCurrentOrgPendingMemberApiV1OrgsCurrentMembersIdentityIdPendingDeleteResponse> DeleteCurrentOrgPendingMemberApiV1OrgsCurrentMembersIdentityIdPendingDeleteAsync(
            string identityId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteCurrentOrgPendingMemberApiV1OrgsCurrentMembersIdentityIdPendingDeleteArguments(
                httpClient: _httpClient,
                identityId: ref identityId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/orgs/current/members/{identityId}/pending", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteCurrentOrgPendingMemberApiV1OrgsCurrentMembersIdentityIdPendingDeleteRequest(
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
            ProcessDeleteCurrentOrgPendingMemberApiV1OrgsCurrentMembersIdentityIdPendingDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteCurrentOrgPendingMemberApiV1OrgsCurrentMembersIdentityIdPendingDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DeleteCurrentOrgPendingMemberApiV1OrgsCurrentMembersIdentityIdPendingDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}