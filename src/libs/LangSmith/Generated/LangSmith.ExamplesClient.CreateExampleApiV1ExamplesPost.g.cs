
#nullable enable

namespace LangSmith
{
    public partial class ExamplesClient
    {
        partial void PrepareCreateExampleApiV1ExamplesPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.ExampleCreate request);
        partial void PrepareCreateExampleApiV1ExamplesPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.ExampleCreate request);
        partial void ProcessCreateExampleApiV1ExamplesPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateExampleApiV1ExamplesPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Example<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Example> CreateExampleApiV1ExamplesPostAsync(
            global::LangSmith.ExampleCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateExampleApiV1ExamplesPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/examples", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.ExampleCreate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateExampleApiV1ExamplesPostRequest(
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
            ProcessCreateExampleApiV1ExamplesPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateExampleApiV1ExamplesPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.Example) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Example<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="datasetId"></param>
        /// <param name="sourceRunId"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="split">
        /// Default Value: base
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Example> CreateExampleApiV1ExamplesPostAsync(
            global::LangSmith.ExampleCreateInputs inputs,
            string datasetId,
            global::System.AnyOf<global::LangSmith.ExampleCreateOutputs, object>? outputs = default,
            global::System.AnyOf<string, object>? sourceRunId = default,
            global::System.AnyOf<global::LangSmith.ExampleCreateMetadata, object>? metadata = default,
            global::System.DateTime createdAt = default,
            global::System.AnyOf<string, object>? id = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, string?, object>? split = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.ExampleCreate
            {
                Inputs = inputs,
                Outputs = outputs,
                DatasetId = datasetId,
                SourceRunId = sourceRunId,
                Metadata = metadata,
                CreatedAt = createdAt,
                Id = id,
                Split = split,
            };

            return await CreateExampleApiV1ExamplesPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}