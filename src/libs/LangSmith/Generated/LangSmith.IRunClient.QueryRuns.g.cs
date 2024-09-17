#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Query Runs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListRunsResponse> QueryRunsAsync(
            global::LangSmith.BodyParamsForRunSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Query Runs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trace"></param>
        /// <param name="parentRun"></param>
        /// <param name="runType"></param>
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
        /// <param name="dataSourceType"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="select">
        /// Default Value: [id, name, run_type, start_time, end_time, status, error, extra, events, inputs, outputs, parent_run_id, manifest_id, manifest_s3_id, session_id, serialized, reference_example_id, total_tokens, prompt_tokens, completion_tokens, total_cost, prompt_cost, completion_cost, price_model_id, first_token_time, trace_id, dotted_order, last_queued_at, feedback_stats, child_run_ids, parent_run_ids, tags, in_dataset, app_path, share_token, trace_tier, trace_first_received_at, ttl_seconds, trace_upgrade]
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListRunsResponse> QueryRunsAsync(
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? trace = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? parentRun = default,
            global::LangSmith.AnyOf<global::LangSmith.RunTypeEnum?, object>? runType = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? referenceExample = default,
            global::LangSmith.AnyOf<int?, object>? executionOrder = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::LangSmith.AnyOf<bool?, object>? error = default,
            global::LangSmith.AnyOf<string, object>? query = default,
            global::LangSmith.AnyOf<string, object>? filter = default,
            global::LangSmith.AnyOf<string, object>? traceFilter = default,
            global::LangSmith.AnyOf<string, object>? treeFilter = default,
            global::LangSmith.AnyOf<bool?, object>? isRoot = default,
            global::LangSmith.AnyOf<global::LangSmith.RunsFilterDataSourceTypeEnum?, object>? dataSourceType = default,
            global::LangSmith.AnyOf<string, object>? cursor = default,
            int? limit = 100,
            global::System.Collections.Generic.IList<global::LangSmith.RunSelect>? select = default,
            global::LangSmith.AllOf<global::LangSmith.RunDateOrder?>? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}