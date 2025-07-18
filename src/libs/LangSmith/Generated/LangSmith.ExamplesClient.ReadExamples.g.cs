
#nullable enable

namespace LangSmith
{
    public partial class ExamplesClient
    {
        partial void PrepareReadExamplesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            ref global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf,
            ref string? metadata,
            global::System.Collections.Generic.IList<string>? fullTextContains,
            global::System.Collections.Generic.IList<string>? splits,
            ref global::System.Guid? dataset,
            ref int? offset,
            ref int? limit,
            ref global::LangSmith.ExampleListOrder? order,
            ref double? randomSeed,
            global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? select,
            ref bool? descending,
            ref string? filter);
        partial void PrepareReadExamplesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf,
            string? metadata,
            global::System.Collections.Generic.IList<string>? fullTextContains,
            global::System.Collections.Generic.IList<string>? splits,
            global::System.Guid? dataset,
            int? offset,
            int? limit,
            global::LangSmith.ExampleListOrder? order,
            double? randomSeed,
            global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? select,
            bool? descending,
            string? filter);
        partial void ProcessReadExamplesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadExamplesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Examples<br/>
        /// Get all examples by query params
        /// </summary>
        /// <param name="id"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="fullTextContains"></param>
        /// <param name="splits"></param>
        /// <param name="dataset"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="order"></param>
        /// <param name="randomSeed"></param>
        /// <param name="select">
        /// Default Value: [id, created_at, modified_at, name, dataset_id, source_run_id, metadata, inputs, outputs]
        /// </param>
        /// <param name="descending"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Example>> ReadExamplesAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf = default,
            string? metadata = default,
            global::System.Collections.Generic.IList<string>? fullTextContains = default,
            global::System.Collections.Generic.IList<string>? splits = default,
            global::System.Guid? dataset = default,
            int? offset = default,
            int? limit = default,
            global::LangSmith.ExampleListOrder? order = default,
            double? randomSeed = default,
            global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? select = default,
            bool? descending = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReadExamplesArguments(
                httpClient: HttpClient,
                id: id,
                asOf: ref asOf,
                metadata: ref metadata,
                fullTextContains: fullTextContains,
                splits: splits,
                dataset: ref dataset,
                offset: ref offset,
                limit: ref limit,
                order: ref order,
                randomSeed: ref randomSeed,
                select: select,
                descending: ref descending,
                filter: ref filter);

            var __pathBuilder = new global::LangSmith.PathBuilder(
                path: "/api/v1/examples",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("id", id, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("as_of", asOf?.ToString() ?? string.Empty) 
                .AddOptionalParameter("metadata", metadata) 
                .AddOptionalParameter("full_text_contains", fullTextContains, delimiter: ",", explode: true) 
                .AddOptionalParameter("splits", splits, delimiter: ",", explode: true) 
                .AddOptionalParameter("dataset", dataset?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("order", order?.ToValueString()) 
                .AddOptionalParameter("random_seed", randomSeed?.ToString()) 
                .AddOptionalParameter("select", select, selector: static x => x.ToValueString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("descending", descending?.ToString()) 
                .AddOptionalParameter("filter", filter) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReadExamplesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                asOf: asOf,
                metadata: metadata,
                fullTextContains: fullTextContains,
                splits: splits,
                dataset: dataset,
                offset: offset,
                limit: limit,
                order: order,
                randomSeed: randomSeed,
                select: select,
                descending: descending,
                filter: filter);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReadExamplesResponse(
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
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::LangSmith.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
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
                ProcessReadExamplesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.Example>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::LangSmith.Example> ??
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
                        await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::LangSmith.Example>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.IList<global::LangSmith.Example> ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }
    }
}