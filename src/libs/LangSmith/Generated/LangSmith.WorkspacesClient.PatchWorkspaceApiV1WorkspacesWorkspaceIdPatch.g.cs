
#nullable enable

namespace LangSmith
{
    public partial class WorkspacesClient
    {
        partial void PreparePatchWorkspaceApiV1WorkspacesWorkspaceIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workspaceId,
            global::LangSmith.WorkspacePatch request);
        partial void PreparePatchWorkspaceApiV1WorkspacesWorkspaceIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workspaceId,
            global::LangSmith.WorkspacePatch request);
        partial void ProcessPatchWorkspaceApiV1WorkspacesWorkspaceIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPatchWorkspaceApiV1WorkspacesWorkspaceIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Patch Workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AppSchemasTenant> PatchWorkspaceApiV1WorkspacesWorkspaceIdPatchAsync(
            string workspaceId,
            global::LangSmith.WorkspacePatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePatchWorkspaceApiV1WorkspacesWorkspaceIdPatchArguments(
                httpClient: _httpClient,
                workspaceId: ref workspaceId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/workspaces/{workspaceId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.WorkspacePatch);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePatchWorkspaceApiV1WorkspacesWorkspaceIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                workspaceId: workspaceId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPatchWorkspaceApiV1WorkspacesWorkspaceIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPatchWorkspaceApiV1WorkspacesWorkspaceIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.AppSchemasTenant) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Patch Workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="displayName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AppSchemasTenant> PatchWorkspaceApiV1WorkspacesWorkspaceIdPatchAsync(
            string workspaceId,
            string displayName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.WorkspacePatch
            {
                DisplayName = displayName,
            };

            return await PatchWorkspaceApiV1WorkspacesWorkspaceIdPatchAsync(
                workspaceId: workspaceId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}