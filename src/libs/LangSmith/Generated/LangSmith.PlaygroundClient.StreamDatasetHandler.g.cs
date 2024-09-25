
#nullable enable

namespace LangSmith
{
    public partial class PlaygroundClient
    {
        partial void PrepareStreamDatasetHandlerArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.PlaygroundRunOverDatasetRequestSchema request);
        partial void PrepareStreamDatasetHandlerRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.PlaygroundRunOverDatasetRequestSchema request);
        partial void ProcessStreamDatasetHandlerResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStreamDatasetHandlerResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Stream Dataset Handler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.StreamDatasetHandlerApiV1PlaygroundStreamDatasetPostResponse> StreamDatasetHandlerAsync(
            global::LangSmith.PlaygroundRunOverDatasetRequestSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareStreamDatasetHandlerArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/playground/stream_dataset",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareStreamDatasetHandlerRequest(
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
            ProcessStreamDatasetHandlerResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessStreamDatasetHandlerResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.StreamDatasetHandlerApiV1PlaygroundStreamDatasetPostResponse), JsonSerializerContext) as global::LangSmith.StreamDatasetHandlerApiV1PlaygroundStreamDatasetPostResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Stream Dataset Handler
        /// </summary>
        /// <param name="manifest"></param>
        /// <param name="secrets"></param>
        /// <param name="runId"></param>
        /// <param name="repoId"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="options">
        /// Configuration for a Runnable.
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="datasetId"></param>
        /// <param name="repetitions">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.StreamDatasetHandlerApiV1PlaygroundStreamDatasetPostResponse> StreamDatasetHandlerAsync(
            global::LangSmith.PlaygroundRunOverDatasetRequestSchemaManifest manifest,
            global::LangSmith.PlaygroundRunOverDatasetRequestSchemaSecrets secrets,
            global::LangSmith.RunnableConfig options,
            global::System.Guid datasetId,
            global::LangSmith.AnyOf<string, object>? runId = default,
            global::LangSmith.AnyOf<string, object>? repoId = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PlaygroundRunOverDatasetRequestSchemaToolsVariant1Item>, object>? tools = default,
            global::LangSmith.AnyOf<string, object>? toolChoice = default,
            global::LangSmith.AnyOf<string, object>? projectName = default,
            int? repetitions = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.PlaygroundRunOverDatasetRequestSchema
            {
                Manifest = manifest,
                Secrets = secrets,
                RunId = runId,
                RepoId = repoId,
                Tools = tools,
                ToolChoice = toolChoice,
                Options = options,
                ProjectName = projectName,
                DatasetId = datasetId,
                Repetitions = repetitions,
            };

            return await StreamDatasetHandlerAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}