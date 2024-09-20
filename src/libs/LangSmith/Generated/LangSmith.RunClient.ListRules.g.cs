
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareListRulesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::LangSmith.AnyOf<global::System.Guid?, object>? datasetId,
            ref global::LangSmith.AnyOf<global::System.Guid?, object>? sessionId,
            ref global::LangSmith.AnyOf<global::LangSmith.ListRulesApiV1RunsRulesGetType2?, object>? type,
            ref global::LangSmith.AnyOf<string, object>? nameContains);
        partial void PrepareListRulesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.AnyOf<global::System.Guid?, object>? datasetId,
            global::LangSmith.AnyOf<global::System.Guid?, object>? sessionId,
            global::LangSmith.AnyOf<global::LangSmith.ListRulesApiV1RunsRulesGetType2?, object>? type,
            global::LangSmith.AnyOf<string, object>? nameContains);
        partial void ProcessListRulesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListRulesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Rules<br/>
        /// List all run rules.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="sessionId"></param>
        /// <param name="type"></param>
        /// <param name="nameContains"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>> ListRulesAsync(
            global::LangSmith.AnyOf<global::System.Guid?, object>? datasetId = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? sessionId = default,
            global::LangSmith.AnyOf<global::LangSmith.ListRulesApiV1RunsRulesGetType2?, object>? type = default,
            global::LangSmith.AnyOf<string, object>? nameContains = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListRulesArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                sessionId: ref sessionId,
                type: ref type,
                nameContains: ref nameContains);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/runs/rules",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("dataset_id", datasetId?.ToString() ?? string.Empty) 
                .AddOptionalParameter("session_id", sessionId?.ToString() ?? string.Empty) 
                .AddOptionalParameter("type", type?.ToString() ?? string.Empty) 
                .AddOptionalParameter("name_contains", nameContains?.ToString() ?? string.Empty) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListRulesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                sessionId: sessionId,
                type: type,
                nameContains: nameContains);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListRulesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListRulesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}