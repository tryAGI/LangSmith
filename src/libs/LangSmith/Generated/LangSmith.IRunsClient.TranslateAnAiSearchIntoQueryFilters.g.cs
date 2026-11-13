#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Translate an AI search into query filters<br/>
        /// Translates a natural-language search into the scope, filters, semantic criterion and time bounds for the runs, traces or threads query API, without running the search. No resources are created. Send the returned fields to the query API named by scope, with the same projects.<br/>
        /// When scope is omitted, it is inferred from the search and defaults to traces. A time period in the search sets min_start_time or max_start_time; bounds the search does not mention are omitted so you can keep your own time range.<br/>
        /// Requires AI search to be enabled for the organization and read access to every project. Returns a single JSON response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryAISearchParseResponse> TranslateAnAiSearchIntoQueryFiltersAsync(

            global::LangSmith.QueryAISearchParseRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Translate an AI search into query filters<br/>
        /// Translates a natural-language search into the scope, filters, semantic criterion and time bounds for the runs, traces or threads query API, without running the search. No resources are created. Send the returned fields to the query API named by scope, with the same projects.<br/>
        /// When scope is omitted, it is inferred from the search and defaults to traces. A time period in the search sets min_start_time or max_start_time; bounds the search does not mention are omitted so you can keep your own time range.<br/>
        /// Requires AI search to be enabled for the organization and read access to every project. Returns a single JSON response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.QueryAISearchParseResponse>> TranslateAnAiSearchIntoQueryFiltersAsResponseAsync(

            global::LangSmith.QueryAISearchParseRequestBody request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Translate an AI search into query filters<br/>
        /// Translates a natural-language search into the scope, filters, semantic criterion and time bounds for the runs, traces or threads query API, without running the search. No resources are created. Send the returned fields to the query API named by scope, with the same projects.<br/>
        /// When scope is omitted, it is inferred from the search and defaults to traces. A time period in the search sets min_start_time or max_start_time; bounds the search does not mention are omitted so you can keep your own time range.<br/>
        /// Requires AI search to be enabled for the organization and read access to every project. Returns a single JSON response.
        /// </summary>
        /// <param name="aiSearch">
        /// Natural-language description of the runs, traces or threads to find, at most 2000 UTF-8 bytes.<br/>
        /// Example: threads where the agent did not complete the task and spent more than $1
        /// </param>
        /// <param name="allowClarification">
        /// When true, an ambiguous search returns clarification options instead of a single plan. Defaults to false.
        /// </param>
        /// <param name="projectIds">
        /// Tracing project UUIDs used to interpret the search. Send the same projects to the query API.<br/>
        /// Example: [018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327]
        /// </param>
        /// <param name="scope">
        /// Query API to plan for: runs, traces or threads. When omitted, it is inferred from the search and defaults to traces.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryAISearchParseResponse> TranslateAnAiSearchIntoQueryFiltersAsync(
            string aiSearch,
            global::System.Collections.Generic.IList<global::System.Guid> projectIds,
            bool? allowClarification = default,
            global::LangSmith.QueryAISearchParseRequestBodyScope? scope = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}