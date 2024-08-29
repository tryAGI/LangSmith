
#nullable enable

namespace LangSmith
{
    public partial class ExamplesClient
    {
        partial void PrepareUpdateExampleApiV1ExamplesExampleIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string exampleId,
            global::LangSmith.ExampleUpdate request);
        partial void PrepareUpdateExampleApiV1ExamplesExampleIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string exampleId,
            global::LangSmith.ExampleUpdate request);
        partial void ProcessUpdateExampleApiV1ExamplesExampleIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateExampleApiV1ExamplesExampleIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateExampleApiV1ExamplesExampleIdPatchResponse> UpdateExampleApiV1ExamplesExampleIdPatchAsync(
            string exampleId,
            global::LangSmith.ExampleUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateExampleApiV1ExamplesExampleIdPatchArguments(
                httpClient: _httpClient,
                exampleId: ref exampleId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/examples/{exampleId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.ExampleUpdate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateExampleApiV1ExamplesExampleIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                exampleId: exampleId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateExampleApiV1ExamplesExampleIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateExampleApiV1ExamplesExampleIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.UpdateExampleApiV1ExamplesExampleIdPatchResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="metadata"></param>
        /// <param name="split"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateExampleApiV1ExamplesExampleIdPatchResponse> UpdateExampleApiV1ExamplesExampleIdPatchAsync(
            string exampleId,
            global::System.AnyOf<string, object>? datasetId = default,
            global::System.AnyOf<global::LangSmith.ExampleUpdateInputs, object>? inputs = default,
            global::System.AnyOf<global::LangSmith.ExampleUpdateOutputs, object>? outputs = default,
            global::System.AnyOf<global::LangSmith.ExampleUpdateMetadata, object>? metadata = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? split = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.ExampleUpdate
            {
                DatasetId = datasetId,
                Inputs = inputs,
                Outputs = outputs,
                Metadata = metadata,
                Split = split,
            };

            return await UpdateExampleApiV1ExamplesExampleIdPatchAsync(
                exampleId: exampleId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}