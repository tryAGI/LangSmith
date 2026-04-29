
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsThreadTraceListItem
    {
        /// <summary>
        /// `completion_cost` is the estimated USD cost for the completion. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        public double? CompletionCost { get; set; }

        /// <summary>
        /// `completion_cost_details` is the USD cost breakdown for completion-side categories; per-category values are under `raw`. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost_details")]
        public global::LangSmith.QueryRunCompletionCostDetails? CompletionCostDetails { get; set; }

        /// <summary>
        /// `completion_token_details` is the completion-side token breakdown by category; per-category counts are under `raw`. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token_details")]
        public global::LangSmith.QueryRunCompletionTokenDetails? CompletionTokenDetails { get; set; }

        /// <summary>
        /// `completion_tokens` is the completion-side token count. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// `end_time` is when the root run ended (RFC3339 date-time). JSON null if the run is still in progress. Omitted unless included in `selects`.<br/>
        /// Example: 2025-01-15T12:00:01.500Z
        /// </summary>
        /// <example>2025-01-15T12:00:01.500Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// `error_preview` is a short error summary when the run failed. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_preview")]
        public string? ErrorPreview { get; set; }

        /// <summary>
        /// `first_token_time` is when the first output token was produced (RFC3339 date-time), for streamed runs when that metadata exists. Omitted unless included in `selects`.<br/>
        /// Example: 2024-01-15T10:30:00.312Z
        /// </summary>
        /// <example>2024-01-15T10:30:00.312Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_token_time")]
        public global::System.DateTime? FirstTokenTime { get; set; }

        /// <summary>
        /// `inputs_preview` is a truncated text preview of inputs. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_preview")]
        public string? InputsPreview { get; set; }

        /// <summary>
        /// `latency` is wall-clock duration from start to end in seconds. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// `name` is a human-readable label for the root run (for example the model name, function name, or step name chosen when the run was traced). Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// `op` is a numeric code identifying the root run's `run_type` (for example LLM vs. tool vs. chain). Encoded as a number for compatibility with legacy clients; prefer the string `run_type` on `RunResponse` when available. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        public double? Op { get; set; }

        /// <summary>
        /// `outputs_preview` is a truncated text preview of outputs. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_preview")]
        public string? OutputsPreview { get; set; }

        /// <summary>
        /// `prompt_cost` is the estimated USD cost for the prompt. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        public double? PromptCost { get; set; }

        /// <summary>
        /// `prompt_cost_details` is the USD cost breakdown for prompt-side categories; per-category values are under `raw`. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost_details")]
        public global::LangSmith.QueryRunPromptCostDetails? PromptCostDetails { get; set; }

        /// <summary>
        /// `prompt_token_details` is the prompt-side token breakdown by category; per-category counts are under nested `raw`. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token_details")]
        public global::LangSmith.QueryRunPromptTokenDetails? PromptTokenDetails { get; set; }

        /// <summary>
        /// `prompt_tokens` is the prompt-side token count. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// `start_time` is when the trace started (RFC3339 date-time). Omitted unless included in `selects`.<br/>
        /// Example: 2025-01-15T12:00:00.000Z
        /// </summary>
        /// <example>2025-01-15T12:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// `thread_id` is the conversation thread UUID that contains this trace. Matches the `thread_id` path parameter of the request. Omitted unless included in `selects`.<br/>
        /// Example: d4e5f6a7-b8c9-4d5e-1f2a-3b4c5d6e7f8a
        /// </summary>
        /// <example>d4e5f6a7-b8c9-4d5e-1f2a-3b4c5d6e7f8a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public global::System.Guid? ThreadId { get; set; }

        /// <summary>
        /// `total_cost` is the estimated total USD cost for the root run. Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// `total_tokens` is the total token count (prompt plus completion). Omitted unless included in `selects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// `trace_id` is the UUID of this trace (the root run). Always present.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsThreadTraceListItem" /> class.
        /// </summary>
        /// <param name="completionCost">
        /// `completion_cost` is the estimated USD cost for the completion. Omitted unless included in `selects`.
        /// </param>
        /// <param name="completionCostDetails">
        /// `completion_cost_details` is the USD cost breakdown for completion-side categories; per-category values are under `raw`. Omitted unless included in `selects`.
        /// </param>
        /// <param name="completionTokenDetails">
        /// `completion_token_details` is the completion-side token breakdown by category; per-category counts are under `raw`. Omitted unless included in `selects`.
        /// </param>
        /// <param name="completionTokens">
        /// `completion_tokens` is the completion-side token count. Omitted unless included in `selects`.
        /// </param>
        /// <param name="endTime">
        /// `end_time` is when the root run ended (RFC3339 date-time). JSON null if the run is still in progress. Omitted unless included in `selects`.<br/>
        /// Example: 2025-01-15T12:00:01.500Z
        /// </param>
        /// <param name="errorPreview">
        /// `error_preview` is a short error summary when the run failed. Omitted unless included in `selects`.
        /// </param>
        /// <param name="firstTokenTime">
        /// `first_token_time` is when the first output token was produced (RFC3339 date-time), for streamed runs when that metadata exists. Omitted unless included in `selects`.<br/>
        /// Example: 2024-01-15T10:30:00.312Z
        /// </param>
        /// <param name="inputsPreview">
        /// `inputs_preview` is a truncated text preview of inputs. Omitted unless included in `selects`.
        /// </param>
        /// <param name="latency">
        /// `latency` is wall-clock duration from start to end in seconds. Omitted unless included in `selects`.
        /// </param>
        /// <param name="name">
        /// `name` is a human-readable label for the root run (for example the model name, function name, or step name chosen when the run was traced). Omitted unless included in `selects`.
        /// </param>
        /// <param name="op">
        /// `op` is a numeric code identifying the root run's `run_type` (for example LLM vs. tool vs. chain). Encoded as a number for compatibility with legacy clients; prefer the string `run_type` on `RunResponse` when available. Omitted unless included in `selects`.
        /// </param>
        /// <param name="outputsPreview">
        /// `outputs_preview` is a truncated text preview of outputs. Omitted unless included in `selects`.
        /// </param>
        /// <param name="promptCost">
        /// `prompt_cost` is the estimated USD cost for the prompt. Omitted unless included in `selects`.
        /// </param>
        /// <param name="promptCostDetails">
        /// `prompt_cost_details` is the USD cost breakdown for prompt-side categories; per-category values are under `raw`. Omitted unless included in `selects`.
        /// </param>
        /// <param name="promptTokenDetails">
        /// `prompt_token_details` is the prompt-side token breakdown by category; per-category counts are under nested `raw`. Omitted unless included in `selects`.
        /// </param>
        /// <param name="promptTokens">
        /// `prompt_tokens` is the prompt-side token count. Omitted unless included in `selects`.
        /// </param>
        /// <param name="startTime">
        /// `start_time` is when the trace started (RFC3339 date-time). Omitted unless included in `selects`.<br/>
        /// Example: 2025-01-15T12:00:00.000Z
        /// </param>
        /// <param name="threadId">
        /// `thread_id` is the conversation thread UUID that contains this trace. Matches the `thread_id` path parameter of the request. Omitted unless included in `selects`.<br/>
        /// Example: d4e5f6a7-b8c9-4d5e-1f2a-3b4c5d6e7f8a
        /// </param>
        /// <param name="totalCost">
        /// `total_cost` is the estimated total USD cost for the root run. Omitted unless included in `selects`.
        /// </param>
        /// <param name="totalTokens">
        /// `total_tokens` is the total token count (prompt plus completion). Omitted unless included in `selects`.
        /// </param>
        /// <param name="traceId">
        /// `trace_id` is the UUID of this trace (the root run). Always present.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsThreadTraceListItem(
            double? completionCost,
            global::LangSmith.QueryRunCompletionCostDetails? completionCostDetails,
            global::LangSmith.QueryRunCompletionTokenDetails? completionTokenDetails,
            int? completionTokens,
            global::System.DateTime? endTime,
            string? errorPreview,
            global::System.DateTime? firstTokenTime,
            string? inputsPreview,
            double? latency,
            string? name,
            double? op,
            string? outputsPreview,
            double? promptCost,
            global::LangSmith.QueryRunPromptCostDetails? promptCostDetails,
            global::LangSmith.QueryRunPromptTokenDetails? promptTokenDetails,
            int? promptTokens,
            global::System.DateTime? startTime,
            global::System.Guid? threadId,
            double? totalCost,
            int? totalTokens,
            global::System.Guid? traceId)
        {
            this.CompletionCost = completionCost;
            this.CompletionCostDetails = completionCostDetails;
            this.CompletionTokenDetails = completionTokenDetails;
            this.CompletionTokens = completionTokens;
            this.EndTime = endTime;
            this.ErrorPreview = errorPreview;
            this.FirstTokenTime = firstTokenTime;
            this.InputsPreview = inputsPreview;
            this.Latency = latency;
            this.Name = name;
            this.Op = op;
            this.OutputsPreview = outputsPreview;
            this.PromptCost = promptCost;
            this.PromptCostDetails = promptCostDetails;
            this.PromptTokenDetails = promptTokenDetails;
            this.PromptTokens = promptTokens;
            this.StartTime = startTime;
            this.ThreadId = threadId;
            this.TotalCost = totalCost;
            this.TotalTokens = totalTokens;
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsThreadTraceListItem" /> class.
        /// </summary>
        public ThreadsThreadTraceListItem()
        {
        }
    }
}