
#nullable enable

namespace LangSmith
{
    public partial class WorkspacesClient
    {
        partial void PrepareCreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string tagKeyId,
            global::LangSmith.TagValueCreate request);
        partial void PrepareCreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string tagKeyId,
            global::LangSmith.TagValueCreate request);
        partial void ProcessCreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Tag Value
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.TagValue> CreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostAsync(
            string tagKeyId,
            global::LangSmith.TagValueCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostArguments(
                httpClient: _httpClient,
                tagKeyId: ref tagKeyId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/workspaces/current/tag-keys/{tagKeyId}/tag-values", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.TagValueCreate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                tagKeyId: tagKeyId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.TagValue) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Tag Value
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.TagValue> CreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostAsync(
            string tagKeyId,
            string value,
            global::System.AnyOf<string?, object>? description = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.TagValueCreate
            {
                Value = value,
                Description = description,
            };

            return await CreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostAsync(
                tagKeyId: tagKeyId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}