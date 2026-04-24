
#nullable enable

namespace LangSmith
{
    public partial class ReposClient
    {

        private static readonly global::LangSmith.AutoSDKServer[] s_ListRepoTagsServers = new global::LangSmith.AutoSDKServer[]
        {            new global::LangSmith.AutoSDKServer(
                id: "https-api-smith-langchain-com",
                name: "api.smith.langchain.com",
                url: "https://api.smith.langchain.com/",
                description: ""),
            new global::LangSmith.AutoSDKServer(
                id: "file",
                name: "",
                url: "file:///",
                description: ""),
        };


        private static readonly global::LangSmith.EndPointSecurityRequirement s_ListRepoTagsSecurityRequirement0 =
            new global::LangSmith.EndPointSecurityRequirement
            {
                Authorizations = new global::LangSmith.EndPointAuthorizationRequirement[]
                {                    new global::LangSmith.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXApiKey",
                        Location = "Header",
                        Name = "X-API-Key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::LangSmith.EndPointSecurityRequirement[] s_ListRepoTagsSecurityRequirements =
            new global::LangSmith.EndPointSecurityRequirement[]
            {                s_ListRepoTagsSecurityRequirement0,
            };
        partial void PrepareListRepoTagsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref int? offset,
            ref string? tenantHandle,
            global::System.Guid? tenantId,
            ref string? query,
            bool? hasCommits,
            global::System.Collections.Generic.IList<string>? tags,
            global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived2? isArchived,
            global::LangSmith.TrueFalseLiteral? isPublic,
            ref string? upstreamRepoOwner,
            ref string? upstreamRepoHandle,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId,
            global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType2? repoType,
            global::System.Collections.Generic.IList<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>? repoTypes);
        partial void PrepareListRepoTagsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            int? offset,
            string? tenantHandle,
            global::System.Guid? tenantId,
            string? query,
            bool? hasCommits,
            global::System.Collections.Generic.IList<string>? tags,
            global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived2? isArchived,
            global::LangSmith.TrueFalseLiteral? isPublic,
            string? upstreamRepoOwner,
            string? upstreamRepoHandle,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId,
            global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType2? repoType,
            global::System.Collections.Generic.IList<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>? repoTypes);
        partial void ProcessListRepoTagsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListRepoTagsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Repo Tags<br/>
        /// Get all repo tags.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tenantHandle"></param>
        /// <param name="tenantId"></param>
        /// <param name="query"></param>
        /// <param name="hasCommits"></param>
        /// <param name="tags"></param>
        /// <param name="isArchived"></param>
        /// <param name="isPublic"></param>
        /// <param name="upstreamRepoOwner"></param>
        /// <param name="upstreamRepoHandle"></param>
        /// <param name="tagValueId"></param>
        /// <param name="repoType"></param>
        /// <param name="repoTypes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ListTagsResponse> ListRepoTagsAsync(
            int? limit = default,
            int? offset = default,
            string? tenantHandle = default,
            global::System.Guid? tenantId = default,
            string? query = default,
            bool? hasCommits = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived2? isArchived = default,
            global::LangSmith.TrueFalseLiteral? isPublic = default,
            string? upstreamRepoOwner = default,
            string? upstreamRepoHandle = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType2? repoType = default,
            global::System.Collections.Generic.IList<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>? repoTypes = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListRepoTagsArguments(
                httpClient: HttpClient,
                limit: ref limit,
                offset: ref offset,
                tenantHandle: ref tenantHandle,
                tenantId: tenantId,
                query: ref query,
                hasCommits: hasCommits,
                tags: tags,
                isArchived: isArchived,
                isPublic: isPublic,
                upstreamRepoOwner: ref upstreamRepoOwner,
                upstreamRepoHandle: ref upstreamRepoHandle,
                tagValueId: tagValueId,
                repoType: repoType,
                repoTypes: repoTypes);


            var __authorizations = global::LangSmith.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListRepoTagsSecurityRequirements,
                operationName: "ListRepoTagsAsync");

            using var __timeoutCancellationTokenSource = global::LangSmith.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::LangSmith.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::LangSmith.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::LangSmith.PathBuilder(
                                path: "/api/v1/repos/tags",
                                baseUri: ResolveBaseUri(
                                servers: s_ListRepoTagsServers,
                                defaultBaseUrl: "https://api.smith.langchain.com/")); 
                            __pathBuilder
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("tenant_handle", tenantHandle)
                                .AddOptionalParameter("tenant_id", tenantId?.ToString())
                                .AddOptionalParameter("query", query)
                                .AddOptionalParameter("has_commits", hasCommits?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("tags", tags?.ToString())
                                .AddOptionalParameter("is_archived", isArchived?.ToString())
                                .AddOptionalParameter("is_public", isPublic?.ToString())
                                .AddOptionalParameter("upstream_repo_owner", upstreamRepoOwner)
                                .AddOptionalParameter("upstream_repo_handle", upstreamRepoHandle)
                                .AddOptionalParameter("tag_value_id", tagValueId?.ToString())
                                .AddOptionalParameter("repo_type", repoType?.ToString())
                                .AddOptionalParameter("repo_types", repoTypes?.ToString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::LangSmith.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::LangSmith.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListRepoTagsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    limit: limit,
                    offset: offset,
                    tenantHandle: tenantHandle,
                    tenantId: tenantId,
                    query: query,
                    hasCommits: hasCommits,
                    tags: tags,
                    isArchived: isArchived,
                    isPublic: isPublic,
                    upstreamRepoOwner: upstreamRepoOwner,
                    upstreamRepoHandle: upstreamRepoHandle,
                    tagValueId: tagValueId,
                    repoType: repoType,
                    repoTypes: repoTypes);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRepoTags",
                                methodName: "ListRepoTagsAsync",
                                pathTemplate: "\"/api/v1/repos/tags\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRepoTags",
                                methodName: "ListRepoTagsAsync",
                                pathTemplate: "\"/api/v1/repos/tags\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::LangSmith.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRepoTags",
                                methodName: "ListRepoTagsAsync",
                                pathTemplate: "\"/api/v1/repos/tags\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessListRepoTagsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRepoTags",
                                methodName: "ListRepoTagsAsync",
                                pathTemplate: "\"/api/v1/repos/tags\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRepoTags",
                                methodName: "ListRepoTagsAsync",
                                pathTemplate: "\"/api/v1/repos/tags\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::LangSmith.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::LangSmith.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessListRepoTagsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::LangSmith.ListTagsResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::LangSmith.ListTagsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}