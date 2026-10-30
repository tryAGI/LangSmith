#nullable enable

namespace LangSmith
{
    public partial interface IModelPriceMapClient
    {
        /// <summary>
        /// Replace a model price<br/>
        /// Replace every field of a custom model price in this workspace.<br/>
        /// The request body is the full entry, not a partial update: omitted<br/>
        /// optional fields are reset to their defaults. Only the workspace's own<br/>
        /// entries can be updated; LangSmith default entries cannot. Costs already<br/>
        /// recorded on existing runs are not recomputed.<br/>
        /// Returns 404 if the workspace has no entry with this ID, including<br/>
        /// LangSmith default entries. Returns 409 if the change would duplicate<br/>
        /// another entry's match conditions.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReplaceAModelPriceAsync(
            global::System.Guid id,

            global::LangSmith.ModelPriceMapUpdateSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace a model price<br/>
        /// Replace every field of a custom model price in this workspace.<br/>
        /// The request body is the full entry, not a partial update: omitted<br/>
        /// optional fields are reset to their defaults. Only the workspace's own<br/>
        /// entries can be updated; LangSmith default entries cannot. Costs already<br/>
        /// recorded on existing runs are not recomputed.<br/>
        /// Returns 404 if the workspace has no entry with this ID, including<br/>
        /// LangSmith default entries. Returns 409 if the change would duplicate<br/>
        /// another entry's match conditions.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> ReplaceAModelPriceAsResponseAsync(
            global::System.Guid id,

            global::LangSmith.ModelPriceMapUpdateSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace a model price<br/>
        /// Replace every field of a custom model price in this workspace.<br/>
        /// The request body is the full entry, not a partial update: omitted<br/>
        /// optional fields are reset to their defaults. Only the workspace's own<br/>
        /// entries can be updated; LangSmith default entries cannot. Costs already<br/>
        /// recorded on existing runs are not recomputed.<br/>
        /// Returns 404 if the workspace has no entry with this ID, including<br/>
        /// LangSmith default entries. Returns 409 if the change would duplicate<br/>
        /// another entry's match conditions.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// Display name for the entry, usually the model name.
        /// </param>
        /// <param name="startTime">
        /// Only price runs that started at or after this time. Null applies to runs from any time.
        /// </param>
        /// <param name="matchPath">
        /// Invocation parameter keys checked, in order, for the model name when the run does not report `ls_model_name` metadata.<br/>
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </param>
        /// <param name="matchPattern">
        /// Regular expression matched against the run's model name, for example `^gpt-4o-mini$`.
        /// </param>
        /// <param name="promptCost">
        /// Cost in US dollars per input (prompt) token.
        /// </param>
        /// <param name="completionCost">
        /// Cost in US dollars per output (completion) token.
        /// </param>
        /// <param name="promptCostDetails">
        /// Cost in US dollars per input token for specific token types, keyed by the token detail name the run reports, for example `cache_read`. Input tokens not covered here are priced at `prompt_cost`.
        /// </param>
        /// <param name="completionCostDetails">
        /// Cost in US dollars per output token for specific token types, keyed by the token detail name the run reports, for example `audio`. Output tokens not covered here are priced at `completion_cost`.
        /// </param>
        /// <param name="provider">
        /// Only price runs from this provider (the `ls_provider` metadata, case-insensitive), for example `openai` or `anthropic`. Null matches any provider.
        /// </param>
        /// <param name="promptTokensAbove">
        /// Only price requests with more input tokens than this, for long-context pricing tiers. Null applies to every request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ReplaceAModelPriceAsync(
            global::System.Guid id,
            string name,
            string matchPattern,
            global::LangSmith.AnyOf<double?, string> promptCost,
            global::LangSmith.AnyOf<double?, string> completionCost,
            global::System.DateTime? startTime = default,
            global::System.Collections.Generic.IList<string>? matchPath = default,
            object? promptCostDetails = default,
            object? completionCostDetails = default,
            string? provider = default,
            int? promptTokensAbove = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}