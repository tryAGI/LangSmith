
#nullable enable

namespace LangSmith
{
    public partial class TracerSessionsClient
    {
        partial void PrepareUpdateFilterViewApiV1SessionsSessionIdViewsViewIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string sessionId,
            ref string viewId,
            global::LangSmith.FilterViewUpdate request);
        partial void PrepareUpdateFilterViewApiV1SessionsSessionIdViewsViewIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string sessionId,
            string viewId,
            global::LangSmith.FilterViewUpdate request);
        partial void ProcessUpdateFilterViewApiV1SessionsSessionIdViewsViewIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateFilterViewApiV1SessionsSessionIdViewsViewIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Filter View<br/>
        /// Update a filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.FilterView> UpdateFilterViewApiV1SessionsSessionIdViewsViewIdPatchAsync(
            string sessionId,
            string viewId,
            global::LangSmith.FilterViewUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateFilterViewApiV1SessionsSessionIdViewsViewIdPatchArguments(
                httpClient: _httpClient,
                sessionId: ref sessionId,
                viewId: ref viewId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/sessions/{sessionId}/views/{viewId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.FilterViewUpdate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateFilterViewApiV1SessionsSessionIdViewsViewIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                sessionId: sessionId,
                viewId: viewId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateFilterViewApiV1SessionsSessionIdViewsViewIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateFilterViewApiV1SessionsSessionIdViewsViewIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.FilterView) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Filter View<br/>
        /// Update a filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="filterString"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="traceFilterString"></param>
        /// <param name="treeFilterString"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.FilterView> UpdateFilterViewApiV1SessionsSessionIdViewsViewIdPatchAsync(
            string sessionId,
            string viewId,
            global::System.AnyOf<string?, object>? filterString = default,
            global::System.AnyOf<string?, object>? displayName = default,
            global::System.AnyOf<string?, object>? description = default,
            global::System.AnyOf<string?, object>? traceFilterString = default,
            global::System.AnyOf<string?, object>? treeFilterString = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.FilterViewUpdate
            {
                FilterString = filterString,
                DisplayName = displayName,
                Description = description,
                TraceFilterString = traceFilterString,
                TreeFilterString = treeFilterString,
            };

            return await UpdateFilterViewApiV1SessionsSessionIdViewsViewIdPatchAsync(
                sessionId: sessionId,
                viewId: viewId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}