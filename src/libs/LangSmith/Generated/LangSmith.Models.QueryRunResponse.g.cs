
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryRunResponse
    {
        /// <summary>
        /// `app_path` identifies the application code location that produced this run, if recorded.<br/>
        /// Example: /app/chains/chat.py:invoke
        /// </summary>
        /// <example>/app/chains/chat.py:invoke</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_path")]
        public string? AppPath { get; set; }

        /// <summary>
        /// `attachments` maps each attachment file name to a pre-signed HTTPS download URL.<br/>
        /// Example: {"{\u0022output.png\u0022":"\u0022https://storage.example.com/bucket/key?X-Amz-Signature=abc\u0022}"}
        /// </summary>
        /// <example>{"{\u0022output.png\u0022":"\u0022https://storage.example.com/bucket/key?X-Amz-Signature=abc\u0022}"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attachments { get; set; }

        /// <summary>
        /// `completion_cost` is estimated USD cost for the completion.<br/>
        /// Example: 0.0003F
        /// </summary>
        /// <example>0.0003F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        public double? CompletionCost { get; set; }

        /// <summary>
        /// `completion_cost_details` is the per-category USD breakdown of `completion_cost`. Categories mirror `completion_token_details`. Returned only when the `COMPLETION_COST_DETAILS` field is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost_details")]
        public global::LangSmith.QueryRunCompletionCostDetails? CompletionCostDetails { get; set; }

        /// <summary>
        /// `completion_token_details` is the per-category breakdown of `completion_tokens`. Category names are model-specific (for example `reasoning`, `audio`). Returned only when the `COMPLETION_TOKEN_DETAILS` field is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token_details")]
        public global::LangSmith.QueryRunCompletionTokenDetails? CompletionTokenDetails { get; set; }

        /// <summary>
        /// `completion_tokens` is the completion-side token count.<br/>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// `dotted_order` is the hierarchical ordering key for trace trees.<br/>
        /// Example: 20240115T103000000000Z018e4c7ea9fb7ef0a5b66ea3a82e9327.
        /// </summary>
        /// <example>20240115T103000000000Z018e4c7ea9fb7ef0a5b66ea3a82e9327.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dotted_order")]
        public string? DottedOrder { get; set; }

        /// <summary>
        /// `end_time` is when the run ended (RFC3339 date-time). JSON null if the run has not finished yet.<br/>
        /// Example: 2024-01-15T10:30:01.500Z
        /// </summary>
        /// <example>2024-01-15T10:30:01.500Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// `error` is the error message when `status` indicates failure.<br/>
        /// Example: context deadline exceeded
        /// </summary>
        /// <example>context deadline exceeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// `error_preview` is a truncated plain-text error snippet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_preview")]
        public string? ErrorPreview { get; set; }

        /// <summary>
        /// `events` is the ordered list of run events (for example streaming tokens).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunEvent>? Events { get; set; }

        /// <summary>
        /// `extra` is additional runtime JSON attached to the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// `feedback_stats` aggregates feedback scores keyed by feedback key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_stats")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>? FeedbackStats { get; set; }

        /// <summary>
        /// `first_token_time` is when the first output token was produced (RFC3339 date-time), when recorded for streamed runs.<br/>
        /// Example: 2024-01-15T10:30:00.312Z
        /// </summary>
        /// <example>2024-01-15T10:30:00.312Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_token_time")]
        public global::System.DateTime? FirstTokenTime { get; set; }

        /// <summary>
        /// `id` is this run's UUID.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// `inputs` is the run input payload (arbitrary JSON object).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// `inputs_preview` is a truncated plain-text preview of inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_preview")]
        public string? InputsPreview { get; set; }

        /// <summary>
        /// `is_in_dataset` is true when this run is linked to a dataset example.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_in_dataset")]
        public bool? IsInDataset { get; set; }

        /// <summary>
        /// `is_root` is true when this run has no parent (it is the trace root).<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_root")]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// `last_queued_at` is the most recent time this run was added to an annotation queue.<br/>
        /// Example: 2024-01-15T10:31:00Z
        /// </summary>
        /// <example>2024-01-15T10:31:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_queued_at")]
        public global::System.DateTime? LastQueuedAt { get; set; }

        /// <summary>
        /// `latency_seconds` is wall-clock duration from start to end in seconds.<br/>
        /// Example: 1.523F
        /// </summary>
        /// <example>1.523F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_seconds")]
        public double? LatencySeconds { get; set; }

        /// <summary>
        /// `manifest` is the serialized configuration of the traced component (for example the model parameters, prompt template, or pipeline definition), when recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        public object? Manifest { get; set; }

        /// <summary>
        /// `metadata` is arbitrary user-defined JSON metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// `name` is a human-readable label for the run (for example the model name, function name, or step name chosen when the run was traced).<br/>
        /// Example: ChatOpenAI
        /// </summary>
        /// <example>ChatOpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// `outputs` is the run output payload (arbitrary JSON object).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// `outputs_preview` is a truncated plain-text preview of outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_preview")]
        public string? OutputsPreview { get; set; }

        /// <summary>
        /// `parent_run_ids` lists ancestor run UUIDs from the trace root down to the direct parent.<br/>
        /// Example: [018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327, a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d]
        /// </summary>
        /// <example>[018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327, a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ParentRunIds { get; set; }

        /// <summary>
        /// `price_model_id` identifies the pricing model UUID used for cost estimates, when recorded.<br/>
        /// Example: e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b
        /// </summary>
        /// <example>e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_model_id")]
        public global::System.Guid? PriceModelId { get; set; }

        /// <summary>
        /// `project_id` is the tracing project UUID this run was logged to.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// `prompt_cost` is estimated USD cost for the prompt.<br/>
        /// Example: 0.0002F
        /// </summary>
        /// <example>0.0002F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        public double? PromptCost { get; set; }

        /// <summary>
        /// `prompt_cost_details` is the per-category USD breakdown of `prompt_cost`. Categories mirror `prompt_token_details`. Returned only when the `PROMPT_COST_DETAILS` field is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost_details")]
        public global::LangSmith.QueryRunPromptCostDetails? PromptCostDetails { get; set; }

        /// <summary>
        /// `prompt_token_details` is the per-category breakdown of `prompt_tokens`. Category names are model-specific (for example `cache_read`, `cache_write`). Returned only when the `PROMPT_TOKEN_DETAILS` field is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token_details")]
        public global::LangSmith.QueryRunPromptTokenDetails? PromptTokenDetails { get; set; }

        /// <summary>
        /// `prompt_tokens` is the prompt-side token count.<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// `reference_dataset_id` is the dataset UUID for the reference example, if any.<br/>
        /// Example: c3d4e5f6-a7b8-4c5d-0e1f-2a3b4c5d6e7f
        /// </summary>
        /// <example>c3d4e5f6-a7b8-4c5d-0e1f-2a3b4c5d6e7f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_dataset_id")]
        public global::System.Guid? ReferenceDatasetId { get; set; }

        /// <summary>
        /// `reference_example_id` is the dataset example UUID this run was compared against, if any.<br/>
        /// Example: b2c3d4e5-f6a7-4b5c-9d0e-1f2a3b4c5d6e
        /// </summary>
        /// <example>b2c3d4e5-f6a7-4b5c-9d0e-1f2a3b4c5d6e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_example_id")]
        public global::System.Guid? ReferenceExampleId { get; set; }

        /// <summary>
        /// `run_type` identifies what kind of operation this run represents (for example an LLM call, a tool invocation, or a chain step). See the `RunType` enum for allowed values.<br/>
        /// Example: LLM
        /// </summary>
        /// <example>LLM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.QueryRunTypeJsonConverter))]
        public global::LangSmith.QueryRunType? RunType { get; set; }

        /// <summary>
        /// `share_url` is the fully-qualified URL of this run's public view, rooted at the deployment's LangSmith app origin (for example `https://smith.langchain.com/public/4f7a1b2c-8d9e-4a0b-9c1d-2e3f4a5b6c7d/r`). It is returned only when `SHARE_URL` is included in `selects`, and only when the run has been explicitly shared; the URL remains stable until the run is unshared. Anyone with this URL can view the run anonymously, so treat it as a secret and do not log it.<br/>
        /// Example: https://smith.langchain.com/public/4f7a1b2c-8d9e-4a0b-9c1d-2e3f4a5b6c7d/r
        /// </summary>
        /// <example>https://smith.langchain.com/public/4f7a1b2c-8d9e-4a0b-9c1d-2e3f4a5b6c7d/r</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_url")]
        public string? ShareUrl { get; set; }

        /// <summary>
        /// `start_time` is when the run started (RFC3339 date-time).<br/>
        /// Example: 2024-01-15T10:30:00.000Z
        /// </summary>
        /// <example>2024-01-15T10:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// `status` is the completion status of the run.<br/>
        /// Example: SUCCESS
        /// </summary>
        /// <example>SUCCESS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.QueryRunStatusJsonConverter))]
        public global::LangSmith.QueryRunStatus? Status { get; set; }

        /// <summary>
        /// `tags` lists user-defined tags on this run.<br/>
        /// Example: [production, gpt-4]
        /// </summary>
        /// <example>[production, gpt-4]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// `thread_evaluation_time` is thread-level evaluation timing (RFC3339 date-time), when recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_evaluation_time")]
        public global::System.DateTime? ThreadEvaluationTime { get; set; }

        /// <summary>
        /// `thread_id` is the conversation thread UUID this run belongs to, if any.<br/>
        /// Example: d4e5f6a7-b8c9-4d5e-1f2a-3b4c5d6e7f8a
        /// </summary>
        /// <example>d4e5f6a7-b8c9-4d5e-1f2a-3b4c5d6e7f8a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public global::System.Guid? ThreadId { get; set; }

        /// <summary>
        /// `total_cost` is total estimated USD cost (prompt plus completion).<br/>
        /// Example: 0.000525F
        /// </summary>
        /// <example>0.000525F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// `total_tokens` is prompt plus completion tokens.<br/>
        /// Example: 350
        /// </summary>
        /// <example>350</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// `trace_id` is the root trace UUID; for a root run it matches `id`.<br/>
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
        /// Initializes a new instance of the <see cref="QueryRunResponse" /> class.
        /// </summary>
        /// <param name="appPath">
        /// `app_path` identifies the application code location that produced this run, if recorded.<br/>
        /// Example: /app/chains/chat.py:invoke
        /// </param>
        /// <param name="attachments">
        /// `attachments` maps each attachment file name to a pre-signed HTTPS download URL.<br/>
        /// Example: {"{\u0022output.png\u0022":"\u0022https://storage.example.com/bucket/key?X-Amz-Signature=abc\u0022}"}
        /// </param>
        /// <param name="completionCost">
        /// `completion_cost` is estimated USD cost for the completion.<br/>
        /// Example: 0.0003F
        /// </param>
        /// <param name="completionCostDetails">
        /// `completion_cost_details` is the per-category USD breakdown of `completion_cost`. Categories mirror `completion_token_details`. Returned only when the `COMPLETION_COST_DETAILS` field is requested.
        /// </param>
        /// <param name="completionTokenDetails">
        /// `completion_token_details` is the per-category breakdown of `completion_tokens`. Category names are model-specific (for example `reasoning`, `audio`). Returned only when the `COMPLETION_TOKEN_DETAILS` field is requested.
        /// </param>
        /// <param name="completionTokens">
        /// `completion_tokens` is the completion-side token count.<br/>
        /// Example: 150
        /// </param>
        /// <param name="dottedOrder">
        /// `dotted_order` is the hierarchical ordering key for trace trees.<br/>
        /// Example: 20240115T103000000000Z018e4c7ea9fb7ef0a5b66ea3a82e9327.
        /// </param>
        /// <param name="endTime">
        /// `end_time` is when the run ended (RFC3339 date-time). JSON null if the run has not finished yet.<br/>
        /// Example: 2024-01-15T10:30:01.500Z
        /// </param>
        /// <param name="error">
        /// `error` is the error message when `status` indicates failure.<br/>
        /// Example: context deadline exceeded
        /// </param>
        /// <param name="errorPreview">
        /// `error_preview` is a truncated plain-text error snippet.
        /// </param>
        /// <param name="events">
        /// `events` is the ordered list of run events (for example streaming tokens).
        /// </param>
        /// <param name="extra">
        /// `extra` is additional runtime JSON attached to the run.
        /// </param>
        /// <param name="feedbackStats">
        /// `feedback_stats` aggregates feedback scores keyed by feedback key.
        /// </param>
        /// <param name="firstTokenTime">
        /// `first_token_time` is when the first output token was produced (RFC3339 date-time), when recorded for streamed runs.<br/>
        /// Example: 2024-01-15T10:30:00.312Z
        /// </param>
        /// <param name="id">
        /// `id` is this run's UUID.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="inputs">
        /// `inputs` is the run input payload (arbitrary JSON object).
        /// </param>
        /// <param name="inputsPreview">
        /// `inputs_preview` is a truncated plain-text preview of inputs.
        /// </param>
        /// <param name="isInDataset">
        /// `is_in_dataset` is true when this run is linked to a dataset example.<br/>
        /// Example: true
        /// </param>
        /// <param name="isRoot">
        /// `is_root` is true when this run has no parent (it is the trace root).<br/>
        /// Example: true
        /// </param>
        /// <param name="lastQueuedAt">
        /// `last_queued_at` is the most recent time this run was added to an annotation queue.<br/>
        /// Example: 2024-01-15T10:31:00Z
        /// </param>
        /// <param name="latencySeconds">
        /// `latency_seconds` is wall-clock duration from start to end in seconds.<br/>
        /// Example: 1.523F
        /// </param>
        /// <param name="manifest">
        /// `manifest` is the serialized configuration of the traced component (for example the model parameters, prompt template, or pipeline definition), when recorded.
        /// </param>
        /// <param name="metadata">
        /// `metadata` is arbitrary user-defined JSON metadata.
        /// </param>
        /// <param name="name">
        /// `name` is a human-readable label for the run (for example the model name, function name, or step name chosen when the run was traced).<br/>
        /// Example: ChatOpenAI
        /// </param>
        /// <param name="outputs">
        /// `outputs` is the run output payload (arbitrary JSON object).
        /// </param>
        /// <param name="outputsPreview">
        /// `outputs_preview` is a truncated plain-text preview of outputs.
        /// </param>
        /// <param name="parentRunIds">
        /// `parent_run_ids` lists ancestor run UUIDs from the trace root down to the direct parent.<br/>
        /// Example: [018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327, a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d]
        /// </param>
        /// <param name="priceModelId">
        /// `price_model_id` identifies the pricing model UUID used for cost estimates, when recorded.<br/>
        /// Example: e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b
        /// </param>
        /// <param name="projectId">
        /// `project_id` is the tracing project UUID this run was logged to.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="promptCost">
        /// `prompt_cost` is estimated USD cost for the prompt.<br/>
        /// Example: 0.0002F
        /// </param>
        /// <param name="promptCostDetails">
        /// `prompt_cost_details` is the per-category USD breakdown of `prompt_cost`. Categories mirror `prompt_token_details`. Returned only when the `PROMPT_COST_DETAILS` field is requested.
        /// </param>
        /// <param name="promptTokenDetails">
        /// `prompt_token_details` is the per-category breakdown of `prompt_tokens`. Category names are model-specific (for example `cache_read`, `cache_write`). Returned only when the `PROMPT_TOKEN_DETAILS` field is requested.
        /// </param>
        /// <param name="promptTokens">
        /// `prompt_tokens` is the prompt-side token count.<br/>
        /// Example: 200
        /// </param>
        /// <param name="referenceDatasetId">
        /// `reference_dataset_id` is the dataset UUID for the reference example, if any.<br/>
        /// Example: c3d4e5f6-a7b8-4c5d-0e1f-2a3b4c5d6e7f
        /// </param>
        /// <param name="referenceExampleId">
        /// `reference_example_id` is the dataset example UUID this run was compared against, if any.<br/>
        /// Example: b2c3d4e5-f6a7-4b5c-9d0e-1f2a3b4c5d6e
        /// </param>
        /// <param name="runType">
        /// `run_type` identifies what kind of operation this run represents (for example an LLM call, a tool invocation, or a chain step). See the `RunType` enum for allowed values.<br/>
        /// Example: LLM
        /// </param>
        /// <param name="shareUrl">
        /// `share_url` is the fully-qualified URL of this run's public view, rooted at the deployment's LangSmith app origin (for example `https://smith.langchain.com/public/4f7a1b2c-8d9e-4a0b-9c1d-2e3f4a5b6c7d/r`). It is returned only when `SHARE_URL` is included in `selects`, and only when the run has been explicitly shared; the URL remains stable until the run is unshared. Anyone with this URL can view the run anonymously, so treat it as a secret and do not log it.<br/>
        /// Example: https://smith.langchain.com/public/4f7a1b2c-8d9e-4a0b-9c1d-2e3f4a5b6c7d/r
        /// </param>
        /// <param name="startTime">
        /// `start_time` is when the run started (RFC3339 date-time).<br/>
        /// Example: 2024-01-15T10:30:00.000Z
        /// </param>
        /// <param name="status">
        /// `status` is the completion status of the run.<br/>
        /// Example: SUCCESS
        /// </param>
        /// <param name="tags">
        /// `tags` lists user-defined tags on this run.<br/>
        /// Example: [production, gpt-4]
        /// </param>
        /// <param name="threadEvaluationTime">
        /// `thread_evaluation_time` is thread-level evaluation timing (RFC3339 date-time), when recorded.
        /// </param>
        /// <param name="threadId">
        /// `thread_id` is the conversation thread UUID this run belongs to, if any.<br/>
        /// Example: d4e5f6a7-b8c9-4d5e-1f2a-3b4c5d6e7f8a
        /// </param>
        /// <param name="totalCost">
        /// `total_cost` is total estimated USD cost (prompt plus completion).<br/>
        /// Example: 0.000525F
        /// </param>
        /// <param name="totalTokens">
        /// `total_tokens` is prompt plus completion tokens.<br/>
        /// Example: 350
        /// </param>
        /// <param name="traceId">
        /// `trace_id` is the root trace UUID; for a root run it matches `id`.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryRunResponse(
            string? appPath,
            global::System.Collections.Generic.Dictionary<string, string>? attachments,
            double? completionCost,
            global::LangSmith.QueryRunCompletionCostDetails? completionCostDetails,
            global::LangSmith.QueryRunCompletionTokenDetails? completionTokenDetails,
            int? completionTokens,
            string? dottedOrder,
            global::System.DateTime? endTime,
            string? error,
            string? errorPreview,
            global::System.Collections.Generic.IList<global::LangSmith.QueryRunEvent>? events,
            object? extra,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>? feedbackStats,
            global::System.DateTime? firstTokenTime,
            global::System.Guid? id,
            object? inputs,
            string? inputsPreview,
            bool? isInDataset,
            bool? isRoot,
            global::System.DateTime? lastQueuedAt,
            double? latencySeconds,
            object? manifest,
            object? metadata,
            string? name,
            object? outputs,
            string? outputsPreview,
            global::System.Collections.Generic.IList<global::System.Guid>? parentRunIds,
            global::System.Guid? priceModelId,
            global::System.Guid? projectId,
            double? promptCost,
            global::LangSmith.QueryRunPromptCostDetails? promptCostDetails,
            global::LangSmith.QueryRunPromptTokenDetails? promptTokenDetails,
            int? promptTokens,
            global::System.Guid? referenceDatasetId,
            global::System.Guid? referenceExampleId,
            global::LangSmith.QueryRunType? runType,
            string? shareUrl,
            global::System.DateTime? startTime,
            global::LangSmith.QueryRunStatus? status,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.DateTime? threadEvaluationTime,
            global::System.Guid? threadId,
            double? totalCost,
            int? totalTokens,
            global::System.Guid? traceId)
        {
            this.AppPath = appPath;
            this.Attachments = attachments;
            this.CompletionCost = completionCost;
            this.CompletionCostDetails = completionCostDetails;
            this.CompletionTokenDetails = completionTokenDetails;
            this.CompletionTokens = completionTokens;
            this.DottedOrder = dottedOrder;
            this.EndTime = endTime;
            this.Error = error;
            this.ErrorPreview = errorPreview;
            this.Events = events;
            this.Extra = extra;
            this.FeedbackStats = feedbackStats;
            this.FirstTokenTime = firstTokenTime;
            this.Id = id;
            this.Inputs = inputs;
            this.InputsPreview = inputsPreview;
            this.IsInDataset = isInDataset;
            this.IsRoot = isRoot;
            this.LastQueuedAt = lastQueuedAt;
            this.LatencySeconds = latencySeconds;
            this.Manifest = manifest;
            this.Metadata = metadata;
            this.Name = name;
            this.Outputs = outputs;
            this.OutputsPreview = outputsPreview;
            this.ParentRunIds = parentRunIds;
            this.PriceModelId = priceModelId;
            this.ProjectId = projectId;
            this.PromptCost = promptCost;
            this.PromptCostDetails = promptCostDetails;
            this.PromptTokenDetails = promptTokenDetails;
            this.PromptTokens = promptTokens;
            this.ReferenceDatasetId = referenceDatasetId;
            this.ReferenceExampleId = referenceExampleId;
            this.RunType = runType;
            this.ShareUrl = shareUrl;
            this.StartTime = startTime;
            this.Status = status;
            this.Tags = tags;
            this.ThreadEvaluationTime = threadEvaluationTime;
            this.ThreadId = threadId;
            this.TotalCost = totalCost;
            this.TotalTokens = totalTokens;
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRunResponse" /> class.
        /// </summary>
        public QueryRunResponse()
        {
        }

    }
}