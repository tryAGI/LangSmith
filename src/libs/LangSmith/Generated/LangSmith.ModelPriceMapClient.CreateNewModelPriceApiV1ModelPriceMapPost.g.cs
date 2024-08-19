
#nullable enable

namespace LangSmith
{
    public partial class ModelPriceMapClient
    {
        partial void PrepareCreateNewModelPriceApiV1ModelPriceMapPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.ModelPriceMapCreateSchema request);
        partial void PrepareCreateNewModelPriceApiV1ModelPriceMapPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.ModelPriceMapCreateSchema request);
        partial void ProcessCreateNewModelPriceApiV1ModelPriceMapPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateNewModelPriceApiV1ModelPriceMapPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create New Model Price
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CreateNewModelPriceApiV1ModelPriceMapPostResponse> CreateNewModelPriceApiV1ModelPriceMapPostAsync(
            global::LangSmith.ModelPriceMapCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateNewModelPriceApiV1ModelPriceMapPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/model-price-map", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.ModelPriceMapCreateSchema);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateNewModelPriceApiV1ModelPriceMapPostRequest(
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
            ProcessCreateNewModelPriceApiV1ModelPriceMapPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateNewModelPriceApiV1ModelPriceMapPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.CreateNewModelPriceApiV1ModelPriceMapPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create New Model Price
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startTime"></param>
        /// <param name="matchPath">
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </param>
        /// <param name="matchPattern"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="provider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CreateNewModelPriceApiV1ModelPriceMapPostResponse> CreateNewModelPriceApiV1ModelPriceMapPostAsync(
            string name,
            string matchPattern,
            global::System.AnyOf<double?, string?> promptCost,
            global::System.AnyOf<double?, string?> completionCost,
            global::System.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::System.Collections.Generic.IList<string>? matchPath = default,
            global::System.AnyOf<string?, object>? provider = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.ModelPriceMapCreateSchema
            {
                Name = name,
                StartTime = startTime,
                MatchPath = matchPath,
                MatchPattern = matchPattern,
                PromptCost = promptCost,
                CompletionCost = completionCost,
                Provider = provider,
            };

            return await CreateNewModelPriceApiV1ModelPriceMapPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}