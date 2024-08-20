using System.Linq;

#nullable enable

namespace LangSmith
{
    public partial class ExamplesClient
    {
        partial void PrepareReadExamplesApiV1ExamplesGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            ref global::System.AnyOf<global::System.DateTime?, string?>? asOf,
            ref global::System.AnyOf<string?, object>? metadata,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? fullTextContains,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? splits,
            ref global::System.AnyOf<string, object>? dataset,
            ref int offset,
            ref int limit,
            ref global::System.AllOf<global::LangSmith.ExampleListOrder?>? order,
            ref global::System.AnyOf<double?, object>? randomSeed,
            global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? select,
            ref global::System.AnyOf<string?, object>? filter);
        partial void PrepareReadExamplesApiV1ExamplesGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            global::System.AnyOf<global::System.DateTime?, string?>? asOf,
            global::System.AnyOf<string?, object>? metadata,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? fullTextContains,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? splits,
            global::System.AnyOf<string, object>? dataset,
            int offset,
            int limit,
            global::System.AllOf<global::LangSmith.ExampleListOrder?>? order,
            global::System.AnyOf<double?, object>? randomSeed,
            global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? select,
            global::System.AnyOf<string?, object>? filter);
        partial void ProcessReadExamplesApiV1ExamplesGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadExamplesApiV1ExamplesGetResponseContent(
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
        /// <param name="order">
        /// Default Value: recent
        /// </param>
        /// <param name="randomSeed"></param>
        /// <param name="select">
        /// Default Value: [id, created_at, modified_at, name, dataset_id, source_run_id, metadata, inputs, outputs]
        /// </param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Example>> ReadExamplesApiV1ExamplesGetAsync(
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            global::System.AnyOf<global::System.DateTime?, string?>? asOf,
            global::System.AnyOf<string?, object>? metadata,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? fullTextContains,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? splits,
            global::System.AnyOf<string, object>? dataset,
            int offset,
            int limit,
            global::System.AllOf<global::LangSmith.ExampleListOrder?>? order,
            global::System.AnyOf<double?, object>? randomSeed,
            global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? select,
            global::System.AnyOf<string?, object>? filter,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadExamplesApiV1ExamplesGetArguments(
                httpClient: _httpClient,
                id: ref id,
                asOf: ref asOf,
                metadata: ref metadata,
                fullTextContains: ref fullTextContains,
                splits: ref splits,
                dataset: ref dataset,
                offset: ref offset,
                limit: ref limit,
                order: ref order,
                randomSeed: ref randomSeed,
                select: select,
                filter: ref filter);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/examples?id={id}&as_of={asOf}&metadata={metadata}&full_text_contains={fullTextContains}&splits={splits}&dataset={dataset}&offset={offset}&limit={limit}&order={order}&random_seed={randomSeed}&{string.Join("&", select?.Select(static x => $"select={x}") ?? global::System.Array.Empty<string>())}&filter={filter}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadExamplesApiV1ExamplesGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
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
                filter: filter);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadExamplesApiV1ExamplesGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadExamplesApiV1ExamplesGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.IListExample) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}