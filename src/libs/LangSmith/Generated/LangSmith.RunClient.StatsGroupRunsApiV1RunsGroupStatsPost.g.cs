
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareStatsGroupRunsApiV1RunsGroupStatsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.RunGroupRequest request);
        partial void PrepareStatsGroupRunsApiV1RunsGroupStatsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.RunGroupRequest request);
        partial void ProcessStatsGroupRunsApiV1RunsGroupStatsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStatsGroupRunsApiV1RunsGroupStatsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Stats Group Runs<br/>
        /// Get stats for the grouped runs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.RunGroupStats> StatsGroupRunsApiV1RunsGroupStatsPostAsync(
            global::LangSmith.RunGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareStatsGroupRunsApiV1RunsGroupStatsPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/runs/group/stats", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.RunGroupRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareStatsGroupRunsApiV1RunsGroupStatsPostRequest(
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
            ProcessStatsGroupRunsApiV1RunsGroupStatsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessStatsGroupRunsApiV1RunsGroupStatsPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.RunGroupStats) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Stats Group Runs<br/>
        /// Get stats for the grouped runs.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="groupBy"></param>
        /// <param name="filter"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.RunGroupStats> StatsGroupRunsApiV1RunsGroupStatsPostAsync(
            string sessionId,
            global::LangSmith.RunGroupBy groupBy = default,
            global::System.AnyOf<string?, object>? filter = default,
            global::System.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::System.AnyOf<global::System.DateTime?, object>? endTime = default,
            int offset = 0,
            int limit = 10,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.RunGroupRequest
            {
                SessionId = sessionId,
                GroupBy = groupBy,
                Filter = filter,
                StartTime = startTime,
                EndTime = endTime,
                Offset = offset,
                Limit = limit,
            };

            return await StatsGroupRunsApiV1RunsGroupStatsPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}