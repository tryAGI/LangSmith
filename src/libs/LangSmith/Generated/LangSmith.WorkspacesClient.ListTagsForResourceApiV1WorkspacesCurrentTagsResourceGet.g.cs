
#nullable enable

namespace LangSmith
{
    public partial class WorkspacesClient
    {
        partial void PrepareListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::LangSmith.ResourceType resourceType,
            ref string resourceId);
        partial void PrepareListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.ResourceType resourceType,
            string resourceId);
        partial void ProcessListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Tags For Resource
        /// </summary>
        /// <param name="resourceType"></param>
        /// <param name="resourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>> ListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetAsync(
            global::LangSmith.ResourceType resourceType,
            string resourceId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetArguments(
                httpClient: _httpClient,
                resourceType: ref resourceType,
                resourceId: ref resourceId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/workspaces/current/tags/resource?resource_type={resourceType}&resource_id={resourceId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                resourceType: resourceType,
                resourceId: resourceId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.IListTagKeyWithValuesAndTaggings) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}