
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareTriggerRulesApiV1RunsRulesTriggerPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.TriggerRulesRequest request);
        partial void PrepareTriggerRulesApiV1RunsRulesTriggerPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.TriggerRulesRequest request);
        partial void ProcessTriggerRulesApiV1RunsRulesTriggerPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTriggerRulesApiV1RunsRulesTriggerPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Trigger Rules<br/>
        /// Trigger an array of run rules manually.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.TriggerRulesApiV1RunsRulesTriggerPostResponse> TriggerRulesApiV1RunsRulesTriggerPostAsync(
            global::LangSmith.TriggerRulesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareTriggerRulesApiV1RunsRulesTriggerPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/runs/rules/trigger", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.TriggerRulesRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTriggerRulesApiV1RunsRulesTriggerPostRequest(
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
            ProcessTriggerRulesApiV1RunsRulesTriggerPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTriggerRulesApiV1RunsRulesTriggerPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.TriggerRulesApiV1RunsRulesTriggerPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Trigger Rules<br/>
        /// Trigger an array of run rules manually.
        /// </summary>
        /// <param name="ruleIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.TriggerRulesApiV1RunsRulesTriggerPostResponse> TriggerRulesApiV1RunsRulesTriggerPostAsync(
            global::System.Collections.Generic.IList<string> ruleIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.TriggerRulesRequest
            {
                RuleIds = ruleIds,
            };

            return await TriggerRulesApiV1RunsRulesTriggerPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}