
#nullable enable

namespace LangSmith
{
    public partial class FeedbackClient
    {
        partial void PrepareReadFeedbacksArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<global::System.Guid>? run,
            global::System.Collections.Generic.IList<string>? key,
            global::System.Collections.Generic.IList<global::System.Guid>? session,
            global::System.Collections.Generic.IList<global::LangSmith.SourceType>? source,
            ref int? limit,
            ref int? offset,
            global::System.Collections.Generic.IList<global::System.Guid>? user,
            ref bool? hasComment,
            ref bool? hasScore,
            ref global::LangSmith.FeedbackLevel? level,
            ref global::System.DateTime? maxCreatedAt,
            ref global::System.DateTime? minCreatedAt);
        partial void PrepareReadFeedbacksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<global::System.Guid>? run,
            global::System.Collections.Generic.IList<string>? key,
            global::System.Collections.Generic.IList<global::System.Guid>? session,
            global::System.Collections.Generic.IList<global::LangSmith.SourceType>? source,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<global::System.Guid>? user,
            bool? hasComment,
            bool? hasScore,
            global::LangSmith.FeedbackLevel? level,
            global::System.DateTime? maxCreatedAt,
            global::System.DateTime? minCreatedAt);
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
        /// <param name="level">
        /// Enum for feedback levels.
        /// </param>
        /// <param name="maxCreatedAt"></param>
        /// <param name="minCreatedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>> ReadFeedbacksAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? run = default,
            global::System.Collections.Generic.IList<string>? key = default,
            global::System.Collections.Generic.IList<global::System.Guid>? session = default,
            global::System.Collections.Generic.IList<global::LangSmith.SourceType>? source = default,
            int? limit = 100,
            int? offset = 0,
            global::System.Collections.Generic.IList<global::System.Guid>? user = default,
            bool? hasComment = default,
            bool? hasScore = default,
            global::LangSmith.FeedbackLevel? level = default,
            global::System.DateTime? maxCreatedAt = default,
            global::System.DateTime? minCreatedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReadFeedbacksArguments(
                httpClient: HttpClient,
                run: run,
                key: key,
                session: session,
                source: source,
                limit: ref limit,
                offset: ref offset,
                user: user,
                hasComment: ref hasComment,
                hasScore: ref hasScore,
                level: ref level,
                maxCreatedAt: ref maxCreatedAt,
                minCreatedAt: ref minCreatedAt);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/feedback",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("run", run, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("key", key, delimiter: ",", explode: true) 
                .AddOptionalParameter("session", session, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("user", user, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("has_comment", hasComment?.ToString()) 
                .AddOptionalParameter("has_score", hasScore?.ToString()) 
                .AddOptionalParameter("level", level?.ToValueString()) 
                .AddOptionalParameter("max_created_at", maxCreatedAt?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("min_created_at", minCreatedAt?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReadFeedbacksRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReadFeedbacksResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReadFeedbacksResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}