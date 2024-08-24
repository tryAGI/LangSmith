
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareCreateDatasetApiV1DatasetsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.DatasetCreate request);
        partial void PrepareCreateDatasetApiV1DatasetsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.DatasetCreate request);
        partial void ProcessCreateDatasetApiV1DatasetsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateDatasetApiV1DatasetsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Dataset<br/>
        /// Create a new dataset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Dataset> CreateDatasetApiV1DatasetsPostAsync(
            global::LangSmith.DatasetCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateDatasetApiV1DatasetsPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/datasets", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.DatasetCreate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateDatasetApiV1DatasetsPostRequest(
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
            ProcessCreateDatasetApiV1DatasetsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateDatasetApiV1DatasetsPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.Dataset) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Dataset<br/>
        /// Create a new dataset.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="inputsSchemaDefinition"></param>
        /// <param name="outputsSchemaDefinition"></param>
        /// <param name="externallyManaged">
        /// Default Value: false
        /// </param>
        /// <param name="id"></param>
        /// <param name="extra"></param>
        /// <param name="dataType">
        /// Default Value: kv
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Dataset> CreateDatasetApiV1DatasetsPostAsync(
            string name,
            global::System.AnyOf<string?, object>? description = default,
            global::System.DateTime createdAt = default,
            global::System.AnyOf<global::LangSmith.DatasetCreateInputsSchemaDefinition, object>? inputsSchemaDefinition = default,
            global::System.AnyOf<global::LangSmith.DatasetCreateOutputsSchemaDefinition, object>? outputsSchemaDefinition = default,
            global::System.AnyOf<bool?, object>? externallyManaged = default,
            global::System.AnyOf<string, object>? id = default,
            global::System.AnyOf<global::LangSmith.DatasetCreateExtra, object>? extra = default,
            global::System.AllOf<global::LangSmith.DataType2?>? dataType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.DatasetCreate
            {
                Name = name,
                Description = description,
                CreatedAt = createdAt,
                InputsSchemaDefinition = inputsSchemaDefinition,
                OutputsSchemaDefinition = outputsSchemaDefinition,
                ExternallyManaged = externallyManaged,
                Id = id,
                Extra = extra,
                DataType = dataType,
            };

            return await CreateDatasetApiV1DatasetsPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}