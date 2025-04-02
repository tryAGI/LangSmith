#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Search Runs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListRunsResponse> SearchRunsAsync(
            global::LangSmith.RunSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search Runs
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="query"></param>
        /// <param name="inputsText"></param>
        /// <param name="outputsText"></param>
        /// <param name="error"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="extra"></param>
        /// <param name="isRoot"></param>
        /// <param name="name"></param>
        /// <param name="runType"></param>
        /// <param name="parentRunId"></param>
        /// <param name="tags"></param>
        /// <param name="status"></param>
        /// <param name="traceId"></param>
        /// <param name="threadId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="select">
        /// Default Value: [id, name, run_type, start_time, end_time, status, error, extra, events, inputs, outputs, parent_run_id, manifest_id, manifest_s3_id, manifest, session_id, serialized, reference_example_id, reference_dataset_id, total_tokens, prompt_tokens, completion_tokens, total_cost, prompt_cost, completion_cost, price_model_id, first_token_time, trace_id, dotted_order, last_queued_at, feedback_stats, parent_run_ids, tags, in_dataset, app_path, share_token, trace_tier, trace_first_received_at, ttl_seconds, trace_upgrade, thread_id]
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListRunsResponse> SearchRunsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> sessionId,
            string? query = default,
            string? inputsText = default,
            string? outputsText = default,
            string? error = default,
            global::System.Collections.Generic.Dictionary<string, string>? inputs = default,
            global::System.Collections.Generic.Dictionary<string, string>? outputs = default,
            global::System.Collections.Generic.Dictionary<string, string>? extra = default,
            bool? isRoot = default,
            string? name = default,
            string? runType = default,
            global::System.Guid? parentRunId = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? status = default,
            global::System.Guid? traceId = default,
            global::System.Guid? threadId = default,
            global::LangSmith.RunsSearchCursor? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::LangSmith.RunSelect>? select = default,
            global::LangSmith.RunSearchRequestOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}