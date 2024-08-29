
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareCloneDatasetApiV1DatasetsClonePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost request);
        partial void PrepareCloneDatasetApiV1DatasetsClonePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost request);
        partial void ProcessCloneDatasetApiV1DatasetsClonePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCloneDatasetApiV1DatasetsClonePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Clone Dataset<br/>
        /// Clone a dataset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Example>> CloneDatasetApiV1DatasetsClonePostAsync(
            global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCloneDatasetApiV1DatasetsClonePostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/datasets/clone", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.BodyCloneDatasetApiV1DatasetsClonePost);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCloneDatasetApiV1DatasetsClonePostRequest(
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
            ProcessCloneDatasetApiV1DatasetsClonePostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCloneDatasetApiV1DatasetsClonePostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.IListExample) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Clone Dataset<br/>
        /// Clone a dataset.
        /// </summary>
        /// <param name="targetDatasetId"></param>
        /// <param name="sourceDatasetId"></param>
        /// <param name="asOf"></param>
        /// <param name="examples"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Example>> CloneDatasetApiV1DatasetsClonePostAsync(
            string targetDatasetId,
            string sourceDatasetId,
            global::System.AnyOf<global::System.AnyOf<global::System.DateTime?, string>?, object>? asOf = default,
            global::System.Collections.Generic.IList<string>? examples = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost
            {
                TargetDatasetId = targetDatasetId,
                SourceDatasetId = sourceDatasetId,
                AsOf = asOf,
                Examples = examples,
            };

            return await CloneDatasetApiV1DatasetsClonePostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}