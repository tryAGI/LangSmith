
#nullable enable

namespace LangSmith
{
    public partial class FeedbackClient
    {


        private static readonly global::LangSmith.EndPointSecurityRequirement s_ReadFeedbacksSecurityRequirement0 =
            new global::LangSmith.EndPointSecurityRequirement
            {
                Authorizations = new global::LangSmith.EndPointAuthorizationRequirement[]
                {                    new global::LangSmith.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "X-API-Key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::LangSmith.EndPointSecurityRequirement[] s_ReadFeedbacksSecurityRequirements =
            new global::LangSmith.EndPointSecurityRequirement[]
            {                s_ReadFeedbacksSecurityRequirement0,
            };
        partial void PrepareReadFeedbacksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>? run,
            global::System.Collections.Generic.IList<string>? key,
            ref global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>? session,
            global::System.Collections.Generic.IList<global::LangSmith.SourceType>? source,
            ref int? limit,
            ref int? offset,
            global::System.Collections.Generic.IList<global::System.Guid>? user,
            bool? hasComment,
            bool? hasScore,
            global::LangSmith.FeedbackLevel? level,
            global::System.DateTime? maxCreatedAt,
            global::System.DateTime? minCreatedAt,
            bool? includeUserNames,
            global::System.Guid? comparativeExperimentId);
        partial void PrepareReadFeedbacksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>? run,
            global::System.Collections.Generic.IList<string>? key,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>? session,
            global::System.Collections.Generic.IList<global::LangSmith.SourceType>? source,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<global::System.Guid>? user,
            bool? hasComment,
            bool? hasScore,
            global::LangSmith.FeedbackLevel? level,
            global::System.DateTime? maxCreatedAt,
            global::System.DateTime? minCreatedAt,
            bool? includeUserNames,
            global::System.Guid? comparativeExperimentId);
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
        /// <param name="includeUserNames"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>> ReadFeedbacksAsync(
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>? run = default,
            global::System.Collections.Generic.IList<string>? key = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>? session = default,
            global::System.Collections.Generic.IList<global::LangSmith.SourceType>? source = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::System.Guid>? user = default,
            bool? hasComment = default,
            bool? hasScore = default,
            global::LangSmith.FeedbackLevel? level = default,
            global::System.DateTime? maxCreatedAt = default,
            global::System.DateTime? minCreatedAt = default,
            bool? includeUserNames = default,
            global::System.Guid? comparativeExperimentId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReadFeedbacksArguments(
                httpClient: HttpClient,
                run: ref run,
                key: key,
                session: ref session,
                source: source,
                limit: ref limit,
                offset: ref offset,
                user: user,
                hasComment: hasComment,
                hasScore: hasScore,
                level: level,
                maxCreatedAt: maxCreatedAt,
                minCreatedAt: minCreatedAt,
                includeUserNames: includeUserNames,
                comparativeExperimentId: comparativeExperimentId);


            var __authorizations = global::LangSmith.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ReadFeedbacksSecurityRequirements,
                operationName: "ReadFeedbacksAsync");

            var __pathBuilder = new global::LangSmith.PathBuilder(
                path: "/api/v1/feedback",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("run", run?.ToString())
                .AddOptionalParameter("key", key?.ToString())
                .AddOptionalParameter("session", session?.ToString())
                .AddOptionalParameter("source", source?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("offset", offset?.ToString())
                .AddOptionalParameter("user", user?.ToString())
                .AddOptionalParameter("has_comment", hasComment?.ToString().ToLowerInvariant())
                .AddOptionalParameter("has_score", hasScore?.ToString().ToLowerInvariant())
                .AddOptionalParameter("level", level?.ToString())
                .AddOptionalParameter("max_created_at", maxCreatedAt?.ToString())
                .AddOptionalParameter("min_created_at", minCreatedAt?.ToString())
                .AddOptionalParameter("include_user_names", includeUserNames?.ToString().ToLowerInvariant())
                .AddOptionalParameter("comparative_experiment_id", comparativeExperimentId?.ToString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
                minCreatedAt: minCreatedAt,
                includeUserNames: includeUserNames,
                comparativeExperimentId: comparativeExperimentId);

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
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::LangSmith.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::LangSmith.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::LangSmith.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::LangSmith.ApiException<global::LangSmith.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

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

                    return
                        (global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>), JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::LangSmith.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        (global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>), JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::LangSmith.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}