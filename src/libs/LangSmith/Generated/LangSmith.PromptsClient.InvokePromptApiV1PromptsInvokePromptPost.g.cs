
#nullable enable

namespace LangSmith
{
    public partial class PromptsClient
    {
        partial void PrepareInvokePromptApiV1PromptsInvokePromptPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.InvokePromptPayload request);
        partial void PrepareInvokePromptApiV1PromptsInvokePromptPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.InvokePromptPayload request);
        partial void ProcessInvokePromptApiV1PromptsInvokePromptPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInvokePromptApiV1PromptsInvokePromptPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Invoke Prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.InvokePromptApiV1PromptsInvokePromptPostResponse> InvokePromptApiV1PromptsInvokePromptPostAsync(
            global::LangSmith.InvokePromptPayload request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareInvokePromptApiV1PromptsInvokePromptPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/prompts/invoke_prompt", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.InvokePromptPayload);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareInvokePromptApiV1PromptsInvokePromptPostRequest(
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
            ProcessInvokePromptApiV1PromptsInvokePromptPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessInvokePromptApiV1PromptsInvokePromptPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.InvokePromptApiV1PromptsInvokePromptPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Invoke Prompt
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="templateFormat"></param>
        /// <param name="inputs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.InvokePromptApiV1PromptsInvokePromptPostResponse> InvokePromptApiV1PromptsInvokePromptPostAsync(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> messages,
            string templateFormat,
            global::LangSmith.InvokePromptPayloadInputs inputs,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.InvokePromptPayload
            {
                Messages = messages,
                TemplateFormat = templateFormat,
                Inputs = inputs,
            };

            return await InvokePromptApiV1PromptsInvokePromptPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}