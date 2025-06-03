
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunsRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dotted_order")]
        public string? DottedOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<object>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_attachments")]
        public object? InputAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_attachments")]
        public object? OutputAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_id")]
        public string? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_example_id")]
        public string? ReferenceExampleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunsRunRunTypeJsonConverter))]
        public global::LangSmith.RunsRunRunType? RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serialized")]
        public object? Serialized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsRun" /> class.
        /// </summary>
        /// <param name="dottedOrder"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="events"></param>
        /// <param name="extra"></param>
        /// <param name="id"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="inputs"></param>
        /// <param name="name"></param>
        /// <param name="outputAttachments"></param>
        /// <param name="outputs"></param>
        /// <param name="parentRunId"></param>
        /// <param name="referenceExampleId"></param>
        /// <param name="runType"></param>
        /// <param name="serialized"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="startTime"></param>
        /// <param name="status"></param>
        /// <param name="tags"></param>
        /// <param name="traceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunsRun(
            string? dottedOrder,
            string? endTime,
            string? error,
            global::System.Collections.Generic.IList<object>? events,
            object? extra,
            string? id,
            object? inputAttachments,
            object? inputs,
            string? name,
            object? outputAttachments,
            object? outputs,
            string? parentRunId,
            string? referenceExampleId,
            global::LangSmith.RunsRunRunType? runType,
            object? serialized,
            string? sessionId,
            string? sessionName,
            string? startTime,
            string? status,
            global::System.Collections.Generic.IList<string>? tags,
            string? traceId)
        {
            this.DottedOrder = dottedOrder;
            this.EndTime = endTime;
            this.Error = error;
            this.Events = events;
            this.Extra = extra;
            this.Id = id;
            this.InputAttachments = inputAttachments;
            this.Inputs = inputs;
            this.Name = name;
            this.OutputAttachments = outputAttachments;
            this.Outputs = outputs;
            this.ParentRunId = parentRunId;
            this.ReferenceExampleId = referenceExampleId;
            this.RunType = runType;
            this.Serialized = serialized;
            this.SessionId = sessionId;
            this.SessionName = sessionName;
            this.StartTime = startTime;
            this.Status = status;
            this.Tags = tags;
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsRun" /> class.
        /// </summary>
        public RunsRun()
        {
        }
    }
}