
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchIngestRunsRequestPostItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.BatchIngestRunsRequestPostItemRunTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.BatchIngestRunsRequestPostItemRunType RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverter<string, double?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OneOf<string, double?> StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::LangSmith.OneOf<string, double?>? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serialized")]
        public object? Serialized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_id")]
        public global::System.Guid? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<object>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dotted_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DottedOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_example_id")]
        public global::System.Guid? ReferenceExampleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_attachments")]
        public object? InputAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_attachments")]
        public object? OutputAttachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchIngestRunsRequestPostItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputs"></param>
        /// <param name="runType"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="error"></param>
        /// <param name="serialized"></param>
        /// <param name="outputs"></param>
        /// <param name="parentRunId"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="referenceExampleId"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="outputAttachments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchIngestRunsRequestPostItem(
            string name,
            global::LangSmith.BatchIngestRunsRequestPostItemRunType runType,
            global::LangSmith.OneOf<string, double?> startTime,
            global::System.Guid traceId,
            string dottedOrder,
            global::System.Guid id,
            object? inputs,
            global::LangSmith.OneOf<string, double?>? endTime,
            object? extra,
            string? error,
            object? serialized,
            object? outputs,
            global::System.Guid? parentRunId,
            global::System.Collections.Generic.IList<object>? events,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Guid? sessionId,
            string? sessionName,
            global::System.Guid? referenceExampleId,
            object? inputAttachments,
            object? outputAttachments)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RunType = runType;
            this.StartTime = startTime;
            this.TraceId = traceId;
            this.DottedOrder = dottedOrder ?? throw new global::System.ArgumentNullException(nameof(dottedOrder));
            this.Id = id;
            this.Inputs = inputs;
            this.EndTime = endTime;
            this.Extra = extra;
            this.Error = error;
            this.Serialized = serialized;
            this.Outputs = outputs;
            this.ParentRunId = parentRunId;
            this.Events = events;
            this.Tags = tags;
            this.SessionId = sessionId;
            this.SessionName = sessionName;
            this.ReferenceExampleId = referenceExampleId;
            this.InputAttachments = inputAttachments;
            this.OutputAttachments = outputAttachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchIngestRunsRequestPostItem" /> class.
        /// </summary>
        public BatchIngestRunsRequestPostItem()
        {
        }
    }
}