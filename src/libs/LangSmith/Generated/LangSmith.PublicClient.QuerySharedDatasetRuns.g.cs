
#nullable enable

namespace LangSmith
{
    public partial class PublicClient
    {
        partial void PrepareQuerySharedDatasetRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            global::LangSmith.BodyParamsForRunSchema request);
        partial void PrepareQuerySharedDatasetRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            global::LangSmith.BodyParamsForRunSchema request);
        partial void ProcessQuerySharedDatasetRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQuerySharedDatasetRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Query Shared Dataset Runs<br/>
        /// Get runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ListPublicDatasetRunsResponse> QuerySharedDatasetRunsAsync(
            global::System.Guid shareToken,
            global::LangSmith.BodyParamsForRunSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareQuerySharedDatasetRunsArguments(
                httpClient: HttpClient,
                shareToken: ref shareToken,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/public/{shareToken}/datasets/runs/query",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareQuerySharedDatasetRunsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                shareToken: shareToken,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessQuerySharedDatasetRunsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::LangSmith.HTTPValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::LangSmith.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::LangSmith.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::LangSmith.ApiException<global::LangSmith.HTTPValidationError>(
                    message: __response.ReasonPhrase ?? string.Empty,
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
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessQuerySharedDatasetRunsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::LangSmith.ListPublicDatasetRunsResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::LangSmith.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::LangSmith.ListPublicDatasetRunsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Query Shared Dataset Runs<br/>
        /// Get runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="id"></param>
        /// <param name="trace"></param>
        /// <param name="parentRun"></param>
        /// <param name="runType">
        /// Enum for run types.
        /// </param>
        /// <param name="session"></param>
        /// <param name="referenceExample"></param>
        /// <param name="executionOrder"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="query"></param>
        /// <param name="filter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="isRoot"></param>
        /// <param name="dataSourceType">
        /// Enum for run data source types.
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="select">
        /// Default Value: [id, name, run_type, start_time, end_time, status, error, extra, events, inputs, outputs, parent_run_id, manifest_id, manifest_s3_id, manifest, session_id, serialized, reference_example_id, reference_dataset_id, total_tokens, prompt_tokens, completion_tokens, total_cost, prompt_cost, completion_cost, price_model_id, first_token_time, trace_id, dotted_order, last_queued_at, feedback_stats, parent_run_ids, tags, in_dataset, app_path, share_token, trace_tier, trace_first_received_at, ttl_seconds, trace_upgrade]
        /// </param>
        /// <param name="order">
        /// Enum for run start date order.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ListPublicDatasetRunsResponse> QuerySharedDatasetRunsAsync(
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::System.Guid? trace = default,
            global::System.Guid? parentRun = default,
            global::LangSmith.RunTypeEnum? runType = default,
            global::System.Collections.Generic.IList<global::System.Guid>? session = default,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceExample = default,
            int? executionOrder = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            bool? error = default,
            string? query = default,
            string? filter = default,
            string? traceFilter = default,
            string? treeFilter = default,
            bool? isRoot = default,
            global::LangSmith.RunsFilterDataSourceTypeEnum? dataSourceType = default,
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::LangSmith.RunSelect>? select = default,
            global::LangSmith.RunDateOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LangSmith.BodyParamsForRunSchema
            {
                Id = id,
                Trace = trace,
                ParentRun = parentRun,
                RunType = runType,
                Session = session,
                ReferenceExample = referenceExample,
                ExecutionOrder = executionOrder,
                StartTime = startTime,
                EndTime = endTime,
                Error = error,
                Query = query,
                Filter = filter,
                TraceFilter = traceFilter,
                TreeFilter = treeFilter,
                IsRoot = isRoot,
                DataSourceType = dataSourceType,
                Cursor = cursor,
                Limit = limit,
                Select = select,
                Order = order,
            };

            return await QuerySharedDatasetRunsAsync(
                shareToken: shareToken,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}