
#nullable enable

namespace LangSmith
{
    public partial class ModelPriceMapClient
    {
        partial void PrepareUpdateModelPriceApiV1ModelPriceMapIdPutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            global::LangSmith.ModelPriceMapUpdateSchema request);
        partial void PrepareUpdateModelPriceApiV1ModelPriceMapIdPutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            global::LangSmith.ModelPriceMapUpdateSchema request);
        partial void ProcessUpdateModelPriceApiV1ModelPriceMapIdPutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateModelPriceApiV1ModelPriceMapIdPutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Model Price
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateModelPriceApiV1ModelPriceMapIdPutResponse> UpdateModelPriceApiV1ModelPriceMapIdPutAsync(
            string id,
            global::LangSmith.ModelPriceMapUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateModelPriceApiV1ModelPriceMapIdPutArguments(
                httpClient: _httpClient,
                id: ref id,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/model-price-map/{id}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.ModelPriceMapUpdateSchema);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateModelPriceApiV1ModelPriceMapIdPutRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateModelPriceApiV1ModelPriceMapIdPutResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateModelPriceApiV1ModelPriceMapIdPutResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.UpdateModelPriceApiV1ModelPriceMapIdPutResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Model Price
        /// </summary>
        /// <param name="id"></param>
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
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateModelPriceApiV1ModelPriceMapIdPutResponse> UpdateModelPriceApiV1ModelPriceMapIdPutAsync(
            string id,
            string name,
            string matchPattern,
            global::System.AnyOf<double?, string?> promptCost,
            global::System.AnyOf<double?, string?> completionCost,
            global::System.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::System.Collections.Generic.IList<string>? matchPath = default,
            global::System.AnyOf<string?, object>? provider = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.ModelPriceMapUpdateSchema
            {
                Name = name,
                StartTime = startTime,
                MatchPath = matchPath,
                MatchPattern = matchPattern,
                PromptCost = promptCost,
                CompletionCost = completionCost,
                Provider = provider,
            };

            return await UpdateModelPriceApiV1ModelPriceMapIdPutAsync(
                id: id,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}