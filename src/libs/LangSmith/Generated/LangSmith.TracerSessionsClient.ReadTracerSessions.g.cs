
#nullable enable

namespace LangSmith
{
    public partial class TracerSessionsClient
    {

        private static readonly global::LangSmith.AutoSDKServer[] s_ReadTracerSessionsServers = new global::LangSmith.AutoSDKServer[]
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


        private static readonly global::LangSmith.EndPointSecurityRequirement s_ReadTracerSessionsSecurityRequirement0 =
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
        private static readonly global::LangSmith.EndPointSecurityRequirement[] s_ReadTracerSessionsSecurityRequirements =
            new global::LangSmith.EndPointSecurityRequirement[]
            {                s_ReadTracerSessionsSecurityRequirement0,
            };
        partial void PrepareReadTracerSessionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            bool? referenceFree,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceDataset,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            ref string? name,
            ref string? nameContains,
            ref string? datasetVersion,
            ref global::LangSmith.SessionSortableColumns? sortBy,
            ref bool? sortByDesc,
            ref string? metadata,
            ref string? sortByFeedbackKey,
            global::LangSmith.FeedbackSourceParam? sortByFeedbackSource,
            ref int? offset,
            ref int? limit,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId,
            ref bool? facets,
            ref string? filter,
            ref bool? includeStats,
            ref bool? useApproxStats,
            global::System.DateTime? statsStartTime,
            global::System.Collections.Generic.IList<string>? statsSelect,
            ref string? statsFilter,
            ref string? accept);
        partial void PrepareReadTracerSessionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? referenceFree,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceDataset,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            string? name,
            string? nameContains,
            string? datasetVersion,
            global::LangSmith.SessionSortableColumns? sortBy,
            bool? sortByDesc,
            string? metadata,
            string? sortByFeedbackKey,
            global::LangSmith.FeedbackSourceParam? sortByFeedbackSource,
            int? offset,
            int? limit,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId,
            bool? facets,
            string? filter,
            bool? includeStats,
            bool? useApproxStats,
            global::System.DateTime? statsStartTime,
            global::System.Collections.Generic.IList<string>? statsSelect,
            string? statsFilter,
            string? accept);
        partial void ProcessReadTracerSessionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadTracerSessionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Tracer Sessions<br/>
        /// List all projects.
        /// </summary>
        /// <param name="referenceFree"></param>
        /// <param name="referenceDataset"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="sortBy">
        /// Default Value: start_time
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="sortByFeedbackSource"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="facets">
        /// Default Value: false
        /// </param>
        /// <param name="filter"></param>
        /// <param name="includeStats">
        /// Default Value: false
        /// </param>
        /// <param name="useApproxStats">
        /// Default Value: false
        /// </param>
        /// <param name="statsStartTime"></param>
        /// <param name="statsSelect"></param>
        /// <param name="statsFilter"></param>
        /// <param name="accept"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TracerSession>> ReadTracerSessionsAsync(
            bool? referenceFree = default,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceDataset = default,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            string? name = default,
            string? nameContains = default,
            string? datasetVersion = default,
            global::LangSmith.SessionSortableColumns? sortBy = default,
            bool? sortByDesc = default,
            string? metadata = default,
            string? sortByFeedbackKey = default,
            global::LangSmith.FeedbackSourceParam? sortByFeedbackSource = default,
            int? offset = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            bool? facets = default,
            string? filter = default,
            bool? includeStats = default,
            bool? useApproxStats = default,
            global::System.DateTime? statsStartTime = default,
            global::System.Collections.Generic.IList<string>? statsSelect = default,
            string? statsFilter = default,
            string? accept = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ReadTracerSessionsAsResponseAsync(
                referenceFree: referenceFree,
                referenceDataset: referenceDataset,
                id: id,
                name: name,
                nameContains: nameContains,
                datasetVersion: datasetVersion,
                sortBy: sortBy,
                sortByDesc: sortByDesc,
                metadata: metadata,
                sortByFeedbackKey: sortByFeedbackKey,
                sortByFeedbackSource: sortByFeedbackSource,
                offset: offset,
                limit: limit,
                tagValueId: tagValueId,
                facets: facets,
                filter: filter,
                includeStats: includeStats,
                useApproxStats: useApproxStats,
                statsStartTime: statsStartTime,
                statsSelect: statsSelect,
                statsFilter: statsFilter,
                accept: accept,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Read Tracer Sessions<br/>
        /// List all projects.
        /// </summary>
        /// <param name="referenceFree"></param>
        /// <param name="referenceDataset"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="sortBy">
        /// Default Value: start_time
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="sortByFeedbackSource"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="facets">
        /// Default Value: false
        /// </param>
        /// <param name="filter"></param>
        /// <param name="includeStats">
        /// Default Value: false
        /// </param>
        /// <param name="useApproxStats">
        /// Default Value: false
        /// </param>
        /// <param name="statsStartTime"></param>
        /// <param name="statsSelect"></param>
        /// <param name="statsFilter"></param>
        /// <param name="accept"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.TracerSession>>> ReadTracerSessionsAsResponseAsync(
            bool? referenceFree = default,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceDataset = default,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            string? name = default,
            string? nameContains = default,
            string? datasetVersion = default,
            global::LangSmith.SessionSortableColumns? sortBy = default,
            bool? sortByDesc = default,
            string? metadata = default,
            string? sortByFeedbackKey = default,
            global::LangSmith.FeedbackSourceParam? sortByFeedbackSource = default,
            int? offset = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            bool? facets = default,
            string? filter = default,
            bool? includeStats = default,
            bool? useApproxStats = default,
            global::System.DateTime? statsStartTime = default,
            global::System.Collections.Generic.IList<string>? statsSelect = default,
            string? statsFilter = default,
            string? accept = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReadTracerSessionsArguments(
                httpClient: HttpClient,
                referenceFree: referenceFree,
                referenceDataset: referenceDataset,
                id: id,
                name: ref name,
                nameContains: ref nameContains,
                datasetVersion: ref datasetVersion,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc,
                metadata: ref metadata,
                sortByFeedbackKey: ref sortByFeedbackKey,
                sortByFeedbackSource: sortByFeedbackSource,
                offset: ref offset,
                limit: ref limit,
                tagValueId: tagValueId,
                facets: ref facets,
                filter: ref filter,
                includeStats: ref includeStats,
                useApproxStats: ref useApproxStats,
                statsStartTime: statsStartTime,
                statsSelect: statsSelect,
                statsFilter: ref statsFilter,
                accept: ref accept);


            var __authorizations = global::LangSmith.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ReadTracerSessionsSecurityRequirements,
                operationName: "ReadTracerSessionsAsync");

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
                                path: "/api/v1/sessions",
                                baseUri: ResolveBaseUri(
                                servers: s_ReadTracerSessionsServers,
                                defaultBaseUrl: "https://api.smith.langchain.com/"));
                            __pathBuilder
                                .AddOptionalParameter("reference_free", referenceFree?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("reference_dataset", referenceDataset?.ToString())
                                .AddOptionalParameter("id", id?.ToString())
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("name_contains", nameContains)
                                .AddOptionalParameter("dataset_version", datasetVersion)
                                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
                                .AddOptionalParameter("sort_by_desc", sortByDesc?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("metadata", metadata)
                                .AddOptionalParameter("sort_by_feedback_key", sortByFeedbackKey)
                                .AddOptionalParameter("sort_by_feedback_source", sortByFeedbackSource?.ToString())
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("tag_value_id", tagValueId?.ToString())
                                .AddOptionalParameter("facets", facets?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("filter", filter)
                                .AddOptionalParameter("include_stats", includeStats?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("use_approx_stats", useApproxStats?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("stats_start_time", statsStartTime?.ToString())
                                .AddOptionalParameter("stats_select", statsSelect?.ToString())
                                .AddOptionalParameter("stats_filter", statsFilter)
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

            if (accept != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("accept", accept.ToString());
            }

                global::LangSmith.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareReadTracerSessionsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    referenceFree: referenceFree,
                    referenceDataset: referenceDataset,
                    id: id,
                    name: name,
                    nameContains: nameContains,
                    datasetVersion: datasetVersion,
                    sortBy: sortBy,
                    sortByDesc: sortByDesc,
                    metadata: metadata,
                    sortByFeedbackKey: sortByFeedbackKey,
                    sortByFeedbackSource: sortByFeedbackSource,
                    offset: offset,
                    limit: limit,
                    tagValueId: tagValueId,
                    facets: facets,
                    filter: filter,
                    includeStats: includeStats,
                    useApproxStats: useApproxStats,
                    statsStartTime: statsStartTime,
                    statsSelect: statsSelect,
                    statsFilter: statsFilter,
                    accept: accept);

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
                                operationId: "ReadTracerSessions",
                                methodName: "ReadTracerSessionsAsync",
                                pathTemplate: "\"/api/v1/sessions\"",
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
                                operationId: "ReadTracerSessions",
                                methodName: "ReadTracerSessionsAsync",
                                pathTemplate: "\"/api/v1/sessions\"",
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
                                operationId: "ReadTracerSessions",
                                methodName: "ReadTracerSessionsAsync",
                                pathTemplate: "\"/api/v1/sessions\"",
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
                ProcessReadTracerSessionsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LangSmith.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LangSmith.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ReadTracerSessions",
                                methodName: "ReadTracerSessionsAsync",
                                pathTemplate: "\"/api/v1/sessions\"",
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
                                operationId: "ReadTracerSessions",
                                methodName: "ReadTracerSessionsAsync",
                                pathTemplate: "\"/api/v1/sessions\"",
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
                                ProcessReadTracerSessionsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = (global::System.Collections.Generic.IList<global::LangSmith.TracerSession>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.TracerSession>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.TracerSession>>(
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

                                    var __value = (global::System.Collections.Generic.IList<global::LangSmith.TracerSession>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.TracerSession>), JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.TracerSession>>(
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