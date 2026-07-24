
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {

        private static readonly global::LangSmith.AutoSDKServer[] s_GetGranularUsageServers = new global::LangSmith.AutoSDKServer[]
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


        private static readonly global::LangSmith.EndPointSecurityRequirement s_GetGranularUsageSecurityRequirement0 =
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
        private static readonly global::LangSmith.EndPointSecurityRequirement[] s_GetGranularUsageSecurityRequirements =
            new global::LangSmith.EndPointSecurityRequirement[]
            {                s_GetGranularUsageSecurityRequirement0,
            };
        partial void PrepareGetGranularUsageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime startTime,
            ref global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceIds,
            ref global::LangSmith.GranularUsageGroupBy? groupBy,
            ref global::LangSmith.GranularUsageKind? kind,
            global::LangSmith.TraceTier? traceTier);
        partial void PrepareGetGranularUsageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceIds,
            global::LangSmith.GranularUsageGroupBy? groupBy,
            global::LangSmith.GranularUsageKind? kind,
            global::LangSmith.TraceTier? traceTier);
        partial void ProcessGetGranularUsageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetGranularUsageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Granular Usage<br/>
        /// Get granular usage data with flexible grouping.<br/>
        /// `kind` selects the billable usage domain:<br/>
        /// - `traces` (default): trace counts.<br/>
        /// - `langsmith_deployments`: LangSmith Deployment metrics (nodes<br/>
        ///   executed, agent runs, agent uptime). The three Deployment fields<br/>
        ///   are populated and `traces` is `0`.<br/>
        /// `trace_tier` (only meaningful for `kind=traces`) optionally restricts<br/>
        /// results to a single retention tier (longlived = extended retention,<br/>
        /// shortlived = standard retention). When `group_by=trace_tier`, results<br/>
        /// are split into one record per retention tier per time bucket.<br/>
        /// `workspace_ids` filters results to the specified workspaces. Only<br/>
        /// workspaces the user has read access to are included.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="groupBy">
        /// Dimensions for grouping granular usage data.<br/>
        /// Default Value: workspace
        /// </param>
        /// <param name="kind">
        /// Which billable usage domain a granular-usage query targets.<br/>
        /// - `traces`: trace counts.<br/>
        /// - `langsmith_deployments`: LangSmith Deployment metrics (nodes executed,<br/>
        ///   agent runs, agent uptime).<br/>
        /// Default is `traces` for backward compatibility — existing callers of<br/>
        /// `GET /granular-usage` without a `kind` query param get the same<br/>
        /// response shape they always did.<br/>
        /// Default Value: traces
        /// </param>
        /// <param name="traceTier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.GranularUsageResponse> GetGranularUsageAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceIds,
            global::LangSmith.GranularUsageGroupBy? groupBy = default,
            global::LangSmith.GranularUsageKind? kind = default,
            global::LangSmith.TraceTier? traceTier = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetGranularUsageAsResponseAsync(
                startTime: startTime,
                endTime: endTime,
                workspaceIds: workspaceIds,
                groupBy: groupBy,
                kind: kind,
                traceTier: traceTier,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Granular Usage<br/>
        /// Get granular usage data with flexible grouping.<br/>
        /// `kind` selects the billable usage domain:<br/>
        /// - `traces` (default): trace counts.<br/>
        /// - `langsmith_deployments`: LangSmith Deployment metrics (nodes<br/>
        ///   executed, agent runs, agent uptime). The three Deployment fields<br/>
        ///   are populated and `traces` is `0`.<br/>
        /// `trace_tier` (only meaningful for `kind=traces`) optionally restricts<br/>
        /// results to a single retention tier (longlived = extended retention,<br/>
        /// shortlived = standard retention). When `group_by=trace_tier`, results<br/>
        /// are split into one record per retention tier per time bucket.<br/>
        /// `workspace_ids` filters results to the specified workspaces. Only<br/>
        /// workspaces the user has read access to are included.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="groupBy">
        /// Dimensions for grouping granular usage data.<br/>
        /// Default Value: workspace
        /// </param>
        /// <param name="kind">
        /// Which billable usage domain a granular-usage query targets.<br/>
        /// - `traces`: trace counts.<br/>
        /// - `langsmith_deployments`: LangSmith Deployment metrics (nodes executed,<br/>
        ///   agent runs, agent uptime).<br/>
        /// Default is `traces` for backward compatibility — existing callers of<br/>
        /// `GET /granular-usage` without a `kind` query param get the same<br/>
        /// response shape they always did.<br/>
        /// Default Value: traces
        /// </param>
        /// <param name="traceTier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.GranularUsageResponse>> GetGranularUsageAsResponseAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceIds,
            global::LangSmith.GranularUsageGroupBy? groupBy = default,
            global::LangSmith.GranularUsageKind? kind = default,
            global::LangSmith.TraceTier? traceTier = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetGranularUsageArguments(
                httpClient: HttpClient,
                startTime: ref startTime,
                endTime: ref endTime,
                workspaceIds: workspaceIds,
                groupBy: ref groupBy,
                kind: ref kind,
                traceTier: traceTier);


            var __authorizations = global::LangSmith.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetGranularUsageSecurityRequirements,
                operationName: "GetGranularUsageAsync");

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
                                path: "/api/v1/orgs/current/billing/granular-usage",
                                baseUri: ResolveBaseUri(
                                servers: s_GetGranularUsageServers,
                                defaultBaseUrl: "https://api.smith.langchain.com/"));
                            __pathBuilder
                                .AddRequiredParameter("start_time", startTime.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddRequiredParameter("end_time", endTime.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddRequiredParameter("workspace_ids", workspaceIds, selector: static x => x.ToString()!, delimiter: ",", explode: true)
                                .AddOptionalParameter("group_by", groupBy?.ToValueString())
                                .AddOptionalParameter("kind", kind?.ToValueString())
                                .AddOptionalParameter("trace_tier", traceTier?.ToString())
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
                PrepareGetGranularUsageRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    startTime: startTime!,
                    endTime: endTime!,
                    workspaceIds: workspaceIds!,
                    groupBy: groupBy,
                    kind: kind,
                    traceTier: traceTier);

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
                                operationId: "GetGranularUsage",
                                methodName: "GetGranularUsageAsync",
                                pathTemplate: "\"/api/v1/orgs/current/billing/granular-usage\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::LangSmith.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetGranularUsage",
                                methodName: "GetGranularUsageAsync",
                                pathTemplate: "\"/api/v1/orgs/current/billing/granular-usage\"",
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
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::LangSmith.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::LangSmith.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetGranularUsage",
                                methodName: "GetGranularUsageAsync",
                                pathTemplate: "\"/api/v1/orgs/current/billing/granular-usage\"",
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
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LangSmith.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessGetGranularUsageResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetGranularUsage",
                                methodName: "GetGranularUsageAsync",
                                pathTemplate: "\"/api/v1/orgs/current/billing/granular-usage\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetGranularUsage",
                                methodName: "GetGranularUsageAsync",
                                pathTemplate: "\"/api/v1/orgs/current/billing/granular-usage\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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


                                throw global::LangSmith.ApiException<global::LangSmith.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessGetGranularUsageResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::LangSmith.GranularUsageResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::LangSmith.AutoSDKHttpResponse<global::LangSmith.GranularUsageResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LangSmith.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::LangSmith.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::LangSmith.GranularUsageResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::LangSmith.AutoSDKHttpResponse<global::LangSmith.GranularUsageResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LangSmith.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    throw global::LangSmith.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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