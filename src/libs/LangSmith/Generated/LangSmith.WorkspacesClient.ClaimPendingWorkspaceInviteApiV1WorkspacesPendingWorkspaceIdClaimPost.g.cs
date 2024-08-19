
#nullable enable

namespace LangSmith
{
    public partial class WorkspacesClient
    {
        partial void PrepareClaimPendingWorkspaceInviteApiV1WorkspacesPendingWorkspaceIdClaimPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workspaceId);
        partial void PrepareClaimPendingWorkspaceInviteApiV1WorkspacesPendingWorkspaceIdClaimPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workspaceId);
        partial void ProcessClaimPendingWorkspaceInviteApiV1WorkspacesPendingWorkspaceIdClaimPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessClaimPendingWorkspaceInviteApiV1WorkspacesPendingWorkspaceIdClaimPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Claim Pending Workspace Invite
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::LangSmith.ClaimPendingWorkspaceInviteApiV1WorkspacesPendingWorkspaceIdClaimPostResponse> ClaimPendingWorkspaceInviteApiV1WorkspacesPendingWorkspaceIdClaimPostAsync(
            string workspaceId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareClaimPendingWorkspaceInviteApiV1WorkspacesPendingWorkspaceIdClaimPostArguments(
                httpClient: _httpClient,
                workspaceId: ref workspaceId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/workspaces/pending/{workspaceId}/claim", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareClaimPendingWorkspaceInviteApiV1WorkspacesPendingWorkspaceIdClaimPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                workspaceId: workspaceId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessClaimPendingWorkspaceInviteApiV1WorkspacesPendingWorkspaceIdClaimPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessClaimPendingWorkspaceInviteApiV1WorkspacesPendingWorkspaceIdClaimPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.ClaimPendingWorkspaceInviteApiV1WorkspacesPendingWorkspaceIdClaimPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}