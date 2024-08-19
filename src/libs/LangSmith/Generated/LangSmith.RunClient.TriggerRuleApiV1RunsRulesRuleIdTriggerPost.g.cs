
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareTriggerRuleApiV1RunsRulesRuleIdTriggerPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string ruleId);
        partial void PrepareTriggerRuleApiV1RunsRulesRuleIdTriggerPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string ruleId);
        partial void ProcessTriggerRuleApiV1RunsRulesRuleIdTriggerPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTriggerRuleApiV1RunsRulesRuleIdTriggerPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Trigger Rule<br/>
        /// Trigger a run rule manually.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.RunRulesSchema> TriggerRuleApiV1RunsRulesRuleIdTriggerPostAsync(
            string ruleId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTriggerRuleApiV1RunsRulesRuleIdTriggerPostArguments(
                httpClient: _httpClient,
                ruleId: ref ruleId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/runs/rules/{ruleId}/trigger", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTriggerRuleApiV1RunsRulesRuleIdTriggerPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                ruleId: ruleId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTriggerRuleApiV1RunsRulesRuleIdTriggerPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTriggerRuleApiV1RunsRulesRuleIdTriggerPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.RunRulesSchema) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}