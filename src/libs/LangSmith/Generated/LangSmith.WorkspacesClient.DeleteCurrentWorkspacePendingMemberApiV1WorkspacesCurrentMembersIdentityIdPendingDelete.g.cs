
#nullable enable

namespace LangSmith
{
    public partial class WorkspacesClient
    {
        partial void PrepareDeleteCurrentWorkspacePendingMemberApiV1WorkspacesCurrentMembersIdentityIdPendingDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string identityId);
        partial void PrepareDeleteCurrentWorkspacePendingMemberApiV1WorkspacesCurrentMembersIdentityIdPendingDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string identityId);
        partial void ProcessDeleteCurrentWorkspacePendingMemberApiV1WorkspacesCurrentMembersIdentityIdPendingDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteCurrentWorkspacePendingMemberApiV1WorkspacesCurrentMembersIdentityIdPendingDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Current Workspace Pending Member
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DeleteCurrentWorkspacePendingMemberApiV1WorkspacesCurrentMembersIdentityIdPendingDeleteResponse> DeleteCurrentWorkspacePendingMemberApiV1WorkspacesCurrentMembersIdentityIdPendingDeleteAsync(
            string identityId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteCurrentWorkspacePendingMemberApiV1WorkspacesCurrentMembersIdentityIdPendingDeleteArguments(
                httpClient: _httpClient,
                identityId: ref identityId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/workspaces/current/members/{identityId}/pending", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteCurrentWorkspacePendingMemberApiV1WorkspacesCurrentMembersIdentityIdPendingDeleteRequest(
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
            ProcessDeleteCurrentWorkspacePendingMemberApiV1WorkspacesCurrentMembersIdentityIdPendingDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteCurrentWorkspacePendingMemberApiV1WorkspacesCurrentMembersIdentityIdPendingDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DeleteCurrentWorkspacePendingMemberApiV1WorkspacesCurrentMembersIdentityIdPendingDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}