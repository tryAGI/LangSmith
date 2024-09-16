using System.Linq;

#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareUploadCsvDatasetArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost request);
        partial void PrepareUploadCsvDatasetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost request);
        partial void ProcessUploadCsvDatasetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadCsvDatasetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload Csv Dataset<br/>
        /// Create a new dataset from a CSV file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Dataset> UploadCsvDatasetAsync(
            global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUploadCsvDatasetArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/datasets/upload", global::System.UriKind.RelativeOrAbsolute));
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "file",
                fileName: request.Filename ?? string.Empty);
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"[{string.Join(",", request.InputKeys.Select(x => x))}]"),
                name: "input_keys");
            if (request.Name != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.Name?.Value1?.ToString() ?? request.Name?.Value2?.ToString() ?? string.Empty),
                    name: "name");
            } 
            if (request.DataType != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.DataType?.Value1?.ToValueString() ?? string.Empty),
                    name: "data_type");
            } 
            if (request.OutputKeys != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", request.OutputKeys.Select(x => x))}]"),
                    name: "output_keys");
            } 
            if (request.Description != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.Description?.Value1?.ToString() ?? request.Description?.Value2?.ToString() ?? string.Empty),
                    name: "description");
            }
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUploadCsvDatasetRequest(
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
            ProcessUploadCsvDatasetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUploadCsvDatasetResponseContent(
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
        /// Upload Csv Dataset<br/>
        /// Create a new dataset from a CSV file.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="inputKeys"></param>
        /// <param name="name"></param>
        /// <param name="dataType">
        /// Default Value: kv
        /// </param>
        /// <param name="outputKeys"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Dataset> UploadCsvDatasetAsync(
            byte[] file,
            string filename,
            global::System.Collections.Generic.IList<string> inputKeys,
            global::LangSmith.AnyOf<string, object>? name = default,
            global::LangSmith.AllOf<global::LangSmith.DataType2?>? dataType = default,
            global::System.Collections.Generic.IList<string>? outputKeys = default,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost
            {
                File = file,
                Filename = filename,
                InputKeys = inputKeys,
                Name = name,
                DataType = dataType,
                OutputKeys = outputKeys,
                Description = description,
            };

            return await UploadCsvDatasetAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}