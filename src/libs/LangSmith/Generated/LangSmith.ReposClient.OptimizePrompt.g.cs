
#nullable enable

namespace LangSmith
{
    public partial class ReposClient
    {
        partial void PrepareOptimizePromptArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.OptimizePromptRequest request);
        partial void PrepareOptimizePromptRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.OptimizePromptRequest request);
        partial void ProcessOptimizePromptResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOptimizePromptResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Optimize Prompt<br/>
        /// Optimize prompt tables.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.OptimizePromptResponse> OptimizePromptAsync(
            global::LangSmith.OptimizePromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOptimizePromptArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/repos/optimize", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOptimizePromptRequest(
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
            ProcessOptimizePromptResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOptimizePromptResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.OptimizePromptResponse), JsonSerializerContext) as global::LangSmith.OptimizePromptResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Optimize Prompt<br/>
        /// Optimize prompt tables.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="metapromptName"></param>
        /// <param name="templateFormat"></param>
        /// <param name="examples"></param>
        /// <param name="overallFeedback"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.OptimizePromptResponse> OptimizePromptAsync(
            string prompt,
            global::LangSmith.AnyOf<string, object> metapromptName,
            global::LangSmith.OptimizePromptRequestTemplateFormat templateFormat,
            global::System.Collections.Generic.IList<global::LangSmith.ExampleRunWithFeedback> examples,
            global::LangSmith.AnyOf<string, object> overallFeedback,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.OptimizePromptRequest
            {
                Prompt = prompt,
                MetapromptName = metapromptName,
                TemplateFormat = templateFormat,
                Examples = examples,
                OverallFeedback = overallFeedback,
            };

            return await OptimizePromptAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}