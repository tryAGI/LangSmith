
#nullable enable

namespace LangSmith
{
    public partial class FeedbackClient
    {
        partial void PrepareReadFeedbacksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? key,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.SourceType>, object>? source,
            ref int? limit,
            ref int? offset,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user,
            ref global::LangSmith.AnyOf<bool?, object>? hasComment,
            ref global::LangSmith.AnyOf<bool?, object>? hasScore,
            ref global::LangSmith.AnyOf<global::LangSmith.FeedbackLevel?, object>? level,
            ref global::LangSmith.AnyOf<global::System.DateTime?, object>? maxCreatedAt,
            ref global::LangSmith.AnyOf<global::System.DateTime?, object>? minCreatedAt);
        partial void PrepareReadFeedbacksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? key,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.SourceType>, object>? source,
            int? limit,
            int? offset,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user,
            global::LangSmith.AnyOf<bool?, object>? hasComment,
            global::LangSmith.AnyOf<bool?, object>? hasScore,
            global::LangSmith.AnyOf<global::LangSmith.FeedbackLevel?, object>? level,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? maxCreatedAt,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? minCreatedAt);
        partial void ProcessReadFeedbacksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadFeedbacksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Feedbacks<br/>
        /// List all Feedback by query params.
        /// </summary>
        /// <param name="run"></param>
        /// <param name="key"></param>
        /// <param name="session"></param>
        /// <param name="source"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="user"></param>
        /// <param name="hasComment"></param>
        /// <param name="hasScore"></param>
        /// <param name="level"></param>
        /// <param name="maxCreatedAt"></param>
        /// <param name="minCreatedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>> ReadFeedbacksAsync(
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? key = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.SourceType>, object>? source = default,
            int? limit = 100,
            int? offset = 0,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user = default,
            global::LangSmith.AnyOf<bool?, object>? hasComment = default,
            global::LangSmith.AnyOf<bool?, object>? hasScore = default,
            global::LangSmith.AnyOf<global::LangSmith.FeedbackLevel?, object>? level = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? maxCreatedAt = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? minCreatedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadFeedbacksArguments(
                httpClient: _httpClient,
                run: ref run,
                key: ref key,
                session: ref session,
                source: ref source,
                limit: ref limit,
                offset: ref offset,
                user: ref user,
                hasComment: ref hasComment,
                hasScore: ref hasScore,
                level: ref level,
                maxCreatedAt: ref maxCreatedAt,
                minCreatedAt: ref minCreatedAt);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/feedback",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("run", run?.ToString() ?? string.Empty) 
                .AddOptionalParameter("key", key?.ToString() ?? string.Empty) 
                .AddOptionalParameter("session", session?.ToString() ?? string.Empty) 
                .AddOptionalParameter("source", source?.ToString() ?? string.Empty) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("user", user?.ToString() ?? string.Empty) 
                .AddOptionalParameter("has_comment", hasComment?.ToString() ?? string.Empty) 
                .AddOptionalParameter("has_score", hasScore?.ToString() ?? string.Empty) 
                .AddOptionalParameter("level", level?.ToString() ?? string.Empty) 
                .AddOptionalParameter("max_created_at", maxCreatedAt?.ToString() ?? string.Empty) 
                .AddOptionalParameter("min_created_at", minCreatedAt?.ToString() ?? string.Empty) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadFeedbacksRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                run: run,
                key: key,
                session: session,
                source: source,
                limit: limit,
                offset: offset,
                user: user,
                hasComment: hasComment,
                hasScore: hasScore,
                level: level,
                maxCreatedAt: maxCreatedAt,
                minCreatedAt: minCreatedAt);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadFeedbacksResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadFeedbacksResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}