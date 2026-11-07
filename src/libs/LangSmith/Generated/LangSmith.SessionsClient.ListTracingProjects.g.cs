
#nullable enable

namespace LangSmith
{
    public partial class SessionsClient
    {

        private static readonly global::LangSmith.AutoSDKServer[] s_ListTracingProjectsServers = new global::LangSmith.AutoSDKServer[]
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


        private static readonly global::LangSmith.EndPointSecurityRequirement s_ListTracingProjectsSecurityRequirement0 =
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
        private static readonly global::LangSmith.EndPointSecurityRequirement[] s_ListTracingProjectsSecurityRequirements =
            new global::LangSmith.EndPointSecurityRequirement[]
            {                s_ListTracingProjectsSecurityRequirement0,
            };
        partial void PrepareListTracingProjectsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? id,
            ref string? name,
            ref string? nameContains,
            global::System.Collections.Generic.IList<string>? referenceDatasetId,
            global::System.Collections.Generic.IList<global::LangSmith.ListSessionsV2TypeItem>? type,
            global::System.Collections.Generic.IList<string>? tagValueId,
            ref string? metadata,
            ref string? filter,
            ref global::LangSmith.ListSessionsV2SortBy? sortBy,
            ref global::LangSmith.ListSessionsV2SortOrder? sortOrder,
            ref string? sortByFeedbackKey,
            ref global::LangSmith.ListSessionsV2SortByFeedbackSource? sortByFeedbackSource,
            ref global::System.DateTime? datasetVersion,
            ref bool? includeStats,
            ref bool? includeFacets,
            ref bool? useApproxStats,
            ref global::System.DateTime? statsStartTime,
            global::System.Collections.Generic.IList<string>? statsSelect,
            ref string? statsFilter,
            ref string? cursor,
            ref int? pageSize);
        partial void PrepareListTracingProjectsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? id,
            string? name,
            string? nameContains,
            global::System.Collections.Generic.IList<string>? referenceDatasetId,
            global::System.Collections.Generic.IList<global::LangSmith.ListSessionsV2TypeItem>? type,
            global::System.Collections.Generic.IList<string>? tagValueId,
            string? metadata,
            string? filter,
            global::LangSmith.ListSessionsV2SortBy? sortBy,
            global::LangSmith.ListSessionsV2SortOrder? sortOrder,
            string? sortByFeedbackKey,
            global::LangSmith.ListSessionsV2SortByFeedbackSource? sortByFeedbackSource,
            global::System.DateTime? datasetVersion,
            bool? includeStats,
            bool? includeFacets,
            bool? useApproxStats,
            global::System.DateTime? statsStartTime,
            global::System.Collections.Generic.IList<string>? statsSelect,
            string? statsFilter,
            string? cursor,
            int? pageSize);
        partial void ProcessListTracingProjectsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTracingProjectsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List tracing projects<br/>
        /// Returns a page of the workspace's tracing projects and experiments. Pass the response's next_cursor as cursor to fetch the next page; next_cursor is null on the last page. A cursor is valid only with the same query parameters as the request that returned it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="type"></param>
        /// <param name="tagValueId"></param>
        /// <param name="metadata"></param>
        /// <param name="filter"></param>
        /// <param name="sortBy">
        /// Default Value: START_TIME
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="sortByFeedbackSource"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="includeStats">
        /// Default Value: false
        /// </param>
        /// <param name="includeFacets">
        /// Default Value: false
        /// </param>
        /// <param name="useApproxStats">
        /// Default Value: false
        /// </param>
        /// <param name="statsStartTime"></param>
        /// <param name="statsSelect"></param>
        /// <param name="statsFilter"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionsListSessionsV2Response> ListTracingProjectsAsync(
            global::System.Collections.Generic.IList<string>? id = default,
            string? name = default,
            string? nameContains = default,
            global::System.Collections.Generic.IList<string>? referenceDatasetId = default,
            global::System.Collections.Generic.IList<global::LangSmith.ListSessionsV2TypeItem>? type = default,
            global::System.Collections.Generic.IList<string>? tagValueId = default,
            string? metadata = default,
            string? filter = default,
            global::LangSmith.ListSessionsV2SortBy? sortBy = default,
            global::LangSmith.ListSessionsV2SortOrder? sortOrder = default,
            string? sortByFeedbackKey = default,
            global::LangSmith.ListSessionsV2SortByFeedbackSource? sortByFeedbackSource = default,
            global::System.DateTime? datasetVersion = default,
            bool? includeStats = default,
            bool? includeFacets = default,
            bool? useApproxStats = default,
            global::System.DateTime? statsStartTime = default,
            global::System.Collections.Generic.IList<string>? statsSelect = default,
            string? statsFilter = default,
            string? cursor = default,
            int? pageSize = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListTracingProjectsAsResponseAsync(
                id: id,
                name: name,
                nameContains: nameContains,
                referenceDatasetId: referenceDatasetId,
                type: type,
                tagValueId: tagValueId,
                metadata: metadata,
                filter: filter,
                sortBy: sortBy,
                sortOrder: sortOrder,
                sortByFeedbackKey: sortByFeedbackKey,
                sortByFeedbackSource: sortByFeedbackSource,
                datasetVersion: datasetVersion,
                includeStats: includeStats,
                includeFacets: includeFacets,
                useApproxStats: useApproxStats,
                statsStartTime: statsStartTime,
                statsSelect: statsSelect,
                statsFilter: statsFilter,
                cursor: cursor,
                pageSize: pageSize,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List tracing projects<br/>
        /// Returns a page of the workspace's tracing projects and experiments. Pass the response's next_cursor as cursor to fetch the next page; next_cursor is null on the last page. A cursor is valid only with the same query parameters as the request that returned it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="type"></param>
        /// <param name="tagValueId"></param>
        /// <param name="metadata"></param>
        /// <param name="filter"></param>
        /// <param name="sortBy">
        /// Default Value: START_TIME
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="sortByFeedbackSource"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="includeStats">
        /// Default Value: false
        /// </param>
        /// <param name="includeFacets">
        /// Default Value: false
        /// </param>
        /// <param name="useApproxStats">
        /// Default Value: false
        /// </param>
        /// <param name="statsStartTime"></param>
        /// <param name="statsSelect"></param>
        /// <param name="statsFilter"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionsListSessionsV2Response>> ListTracingProjectsAsResponseAsync(
            global::System.Collections.Generic.IList<string>? id = default,
            string? name = default,
            string? nameContains = default,
            global::System.Collections.Generic.IList<string>? referenceDatasetId = default,
            global::System.Collections.Generic.IList<global::LangSmith.ListSessionsV2TypeItem>? type = default,
            global::System.Collections.Generic.IList<string>? tagValueId = default,
            string? metadata = default,
            string? filter = default,
            global::LangSmith.ListSessionsV2SortBy? sortBy = default,
            global::LangSmith.ListSessionsV2SortOrder? sortOrder = default,
            string? sortByFeedbackKey = default,
            global::LangSmith.ListSessionsV2SortByFeedbackSource? sortByFeedbackSource = default,
            global::System.DateTime? datasetVersion = default,
            bool? includeStats = default,
            bool? includeFacets = default,
            bool? useApproxStats = default,
            global::System.DateTime? statsStartTime = default,
            global::System.Collections.Generic.IList<string>? statsSelect = default,
            string? statsFilter = default,
            string? cursor = default,
            int? pageSize = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListTracingProjectsArguments(
                httpClient: HttpClient,
                id: id,
                name: ref name,
                nameContains: ref nameContains,
                referenceDatasetId: referenceDatasetId,
                type: type,
                tagValueId: tagValueId,
                metadata: ref metadata,
                filter: ref filter,
                sortBy: ref sortBy,
                sortOrder: ref sortOrder,
                sortByFeedbackKey: ref sortByFeedbackKey,
                sortByFeedbackSource: ref sortByFeedbackSource,
                datasetVersion: ref datasetVersion,
                includeStats: ref includeStats,
                includeFacets: ref includeFacets,
                useApproxStats: ref useApproxStats,
                statsStartTime: ref statsStartTime,
                statsSelect: statsSelect,
                statsFilter: ref statsFilter,
                cursor: ref cursor,
                pageSize: ref pageSize);


            var __authorizations = global::LangSmith.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListTracingProjectsSecurityRequirements,
                operationName: "ListTracingProjectsAsync");

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
                                path: "/api/v2/sessions",
                                baseUri: ResolveBaseUri(
                                servers: s_ListTracingProjectsServers,
                                defaultBaseUrl: "https://api.smith.langchain.com/"));
                            __pathBuilder
                                .AddOptionalParameter("id", id, delimiter: ",", explode: true)
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("name_contains", nameContains)
                                .AddOptionalParameter("reference_dataset_id", referenceDatasetId, delimiter: ",", explode: true)
                                .AddOptionalParameter("type", type, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("tag_value_id", tagValueId, delimiter: ",", explode: true)
                                .AddOptionalParameter("metadata", metadata)
                                .AddOptionalParameter("filter", filter)
                                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
                                .AddOptionalParameter("sort_order", sortOrder?.ToValueString())
                                .AddOptionalParameter("sort_by_feedback_key", sortByFeedbackKey)
                                .AddOptionalParameter("sort_by_feedback_source", sortByFeedbackSource?.ToValueString())
                                .AddOptionalParameter("dataset_version", datasetVersion?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("include_stats", includeStats?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("include_facets", includeFacets?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("use_approx_stats", useApproxStats?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("stats_start_time", statsStartTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("stats_select", statsSelect, delimiter: ",", explode: true)
                                .AddOptionalParameter("stats_filter", statsFilter)
                                .AddOptionalParameter("cursor", cursor)
                                .AddOptionalParameter("page_size", pageSize?.ToString())
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
                PrepareListTracingProjectsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    id: id,
                    name: name,
                    nameContains: nameContains,
                    referenceDatasetId: referenceDatasetId,
                    type: type,
                    tagValueId: tagValueId,
                    metadata: metadata,
                    filter: filter,
                    sortBy: sortBy,
                    sortOrder: sortOrder,
                    sortByFeedbackKey: sortByFeedbackKey,
                    sortByFeedbackSource: sortByFeedbackSource,
                    datasetVersion: datasetVersion,
                    includeStats: includeStats,
                    includeFacets: includeFacets,
                    useApproxStats: useApproxStats,
                    statsStartTime: statsStartTime,
                    statsSelect: statsSelect,
                    statsFilter: statsFilter,
                    cursor: cursor,
                    pageSize: pageSize);

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
                                operationId: "ListTracingProjects",
                                methodName: "ListTracingProjectsAsync",
                                pathTemplate: "\"/api/v2/sessions\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "ListTracingProjects",
                                methodName: "ListTracingProjectsAsync",
                                pathTemplate: "\"/api/v2/sessions\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "ListTracingProjects",
                                methodName: "ListTracingProjectsAsync",
                                pathTemplate: "\"/api/v2/sessions\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                ProcessListTracingProjectsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListTracingProjects",
                                methodName: "ListTracingProjectsAsync",
                                pathTemplate: "\"/api/v2/sessions\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "ListTracingProjects",
                                methodName: "ListTracingProjectsAsync",
                                pathTemplate: "\"/api/v2/sessions\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                            // Invalid query parameters or cursor
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::LangSmith.SharedProblemDetails? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::LangSmith.SharedProblemDetails.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::LangSmith.SharedProblemDetails.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::LangSmith.ApiException<global::LangSmith.SharedProblemDetails>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The caller may not read one or more of the requested projects
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::LangSmith.SharedProblemDetails? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::LangSmith.SharedProblemDetails.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::LangSmith.SharedProblemDetails.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::LangSmith.ApiException<global::LangSmith.SharedProblemDetails>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
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
                                ProcessListTracingProjectsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::LangSmith.TracerSessionsListSessionsV2Response.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionsListSessionsV2Response>(
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

                                    var __value = await global::LangSmith.TracerSessionsListSessionsV2Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionsListSessionsV2Response>(
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