
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunSearchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_text")]
        public string? InputsText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_text")]
        public string? OutputsText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.Dictionary<string, string>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.Dictionary<string, string>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public global::System.Collections.Generic.Dictionary<string, string>? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_root")]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        public string? RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_id")]
        public global::System.Guid? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public global::LangSmith.RunsSearchCursor? Cursor { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: [id, name, run_type, start_time, end_time, status, error, extra, events, inputs, outputs, parent_run_id, manifest_id, manifest_s3_id, manifest, session_id, serialized, reference_example_id, reference_dataset_id, total_tokens, prompt_tokens, completion_tokens, total_cost, prompt_cost, completion_cost, price_model_id, first_token_time, trace_id, dotted_order, last_queued_at, feedback_stats, parent_run_ids, tags, in_dataset, app_path, share_token, trace_tier, trace_first_received_at, ttl_seconds, trace_upgrade, thread_id]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("select")]
        public global::System.Collections.Generic.IList<global::LangSmith.RunSelect>? Select { get; set; }

        /// <summary>
        /// Default Value: desc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunSearchRequestOrderJsonConverter))]
        public global::LangSmith.RunSearchRequestOrder? Order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSearchRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunSearchRequest(
            global::System.Collections.Generic.IList<global::System.Guid> sessionId,
            string? query,
            string? inputsText,
            string? outputsText,
            string? error,
            global::System.Collections.Generic.Dictionary<string, string>? inputs,
            global::System.Collections.Generic.Dictionary<string, string>? outputs,
            global::System.Collections.Generic.Dictionary<string, string>? extra,
            bool? isRoot,
            string? name,
            string? runType,
            global::System.Guid? parentRunId,
            global::System.Collections.Generic.IList<string>? tags,
            string? status,
            global::System.Guid? traceId,
            string? threadId,
            global::LangSmith.RunsSearchCursor? cursor,
            int? limit,
            global::System.Collections.Generic.IList<global::LangSmith.RunSelect>? select,
            global::LangSmith.RunSearchRequestOrder? order)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Query = query;
            this.InputsText = inputsText;
            this.OutputsText = outputsText;
            this.Error = error;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.Extra = extra;
            this.IsRoot = isRoot;
            this.Name = name;
            this.RunType = runType;
            this.ParentRunId = parentRunId;
            this.Tags = tags;
            this.Status = status;
            this.TraceId = traceId;
            this.ThreadId = threadId;
            this.Cursor = cursor;
            this.Limit = limit;
            this.Select = select;
            this.Order = order;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSearchRequest" /> class.
        /// </summary>
        public RunSearchRequest()
        {
        }
    }
}