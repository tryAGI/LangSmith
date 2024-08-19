
#nullable enable

namespace LangSmith
{
    public partial class WorkspacesClient
    {
        partial void PrepareAddMemberToCurrentWorkspaceApiV1WorkspacesCurrentMembersPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.IdentityCreate request);
        partial void PrepareAddMemberToCurrentWorkspaceApiV1WorkspacesCurrentMembersPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.IdentityCreate request);
        partial void ProcessAddMemberToCurrentWorkspaceApiV1WorkspacesCurrentMembersPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddMemberToCurrentWorkspaceApiV1WorkspacesCurrentMembersPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add Member To Current Workspace<br/>
        /// Add an existing organization member to the current workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Identity> AddMemberToCurrentWorkspaceApiV1WorkspacesCurrentMembersPostAsync(
            global::LangSmith.IdentityCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareAddMemberToCurrentWorkspaceApiV1WorkspacesCurrentMembersPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/workspaces/current/members", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.IdentityCreate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAddMemberToCurrentWorkspaceApiV1WorkspacesCurrentMembersPostRequest(
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
            ProcessAddMemberToCurrentWorkspaceApiV1WorkspacesCurrentMembersPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAddMemberToCurrentWorkspaceApiV1WorkspacesCurrentMembersPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.Identity) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add Member To Current Workspace<br/>
        /// Add an existing organization member to the current workspace.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Identity> AddMemberToCurrentWorkspaceApiV1WorkspacesCurrentMembersPostAsync(
            string userId,
            global::System.AnyOf<bool?, object>? readOnly = default,
            global::System.AnyOf<string, object>? roleId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.IdentityCreate
            {
                UserId = userId,
                ReadOnly = readOnly,
                RoleId = roleId,
            };

            return await AddMemberToCurrentWorkspaceApiV1WorkspacesCurrentMembersPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}