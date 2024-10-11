
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareCreateDatasetArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.DatasetCreate request);
        partial void PrepareCreateDatasetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.DatasetCreate request);
        partial void ProcessCreateDatasetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateDatasetResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::LangSmith.Dataset> CreateDatasetAsync(
            global::LangSmith.DatasetCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateDatasetArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/datasets",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateDatasetRequest(
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
            ProcessCreateDatasetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateDatasetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.Dataset), JsonSerializerContext) as global::LangSmith.Dataset ??
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
        /// Enum for dataset data types.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Dataset> CreateDatasetAsync(
            string name,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::System.DateTime? createdAt = default,
            global::LangSmith.AnyOf<object, object>? inputsSchemaDefinition = default,
            global::LangSmith.AnyOf<object, object>? outputsSchemaDefinition = default,
            global::LangSmith.AnyOf<bool?, object>? externallyManaged = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? id = default,
            global::LangSmith.AnyOf<object, object>? extra = default,
            global::LangSmith.DataType? dataType = default,
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

            return await CreateDatasetAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}