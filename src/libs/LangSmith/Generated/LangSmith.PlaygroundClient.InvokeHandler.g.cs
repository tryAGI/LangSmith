
#nullable enable

namespace LangSmith
{
    public partial class PlaygroundClient
    {
        partial void PrepareInvokeHandlerArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.PlaygroundInvokeRequestSchema request);
        partial void PrepareInvokeHandlerRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.PlaygroundInvokeRequestSchema request);
        partial void ProcessInvokeHandlerResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInvokeHandlerResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Invoke Handler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.InvokeHandlerApiV1PlaygroundInvokePostResponse> InvokeHandlerAsync(
            global::LangSmith.PlaygroundInvokeRequestSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareInvokeHandlerArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/playground/invoke",
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
            PrepareInvokeHandlerRequest(
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
            ProcessInvokeHandlerResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessInvokeHandlerResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.InvokeHandlerApiV1PlaygroundInvokePostResponse), JsonSerializerContext) as global::LangSmith.InvokeHandlerApiV1PlaygroundInvokePostResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Invoke Handler
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
        /// <param name="input"></param>
        /// <param name="repetitions">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.InvokeHandlerApiV1PlaygroundInvokePostResponse> InvokeHandlerAsync(
            global::LangSmith.PlaygroundInvokeRequestSchemaManifest manifest,
            global::LangSmith.PlaygroundInvokeRequestSchemaSecrets secrets,
            global::LangSmith.RunnableConfig options,
            global::LangSmith.PlaygroundInvokeRequestSchemaInput input,
            global::LangSmith.AnyOf<string, object>? runId = default,
            global::LangSmith.AnyOf<string, object>? repoId = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PlaygroundInvokeRequestSchemaToolsVariant1Item>, object>? tools = default,
            global::LangSmith.AnyOf<string, object>? toolChoice = default,
            global::LangSmith.AnyOf<string, object>? projectName = default,
            int? repetitions = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.PlaygroundInvokeRequestSchema
            {
                Manifest = manifest,
                Secrets = secrets,
                RunId = runId,
                RepoId = repoId,
                Tools = tools,
                ToolChoice = toolChoice,
                Options = options,
                ProjectName = projectName,
                Input = input,
                Repetitions = repetitions,
            };

            return await InvokeHandlerAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}