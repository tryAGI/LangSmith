
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchIngestRunsRequestPatchItem
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverterFactory2))]
        public global::LangSmith.OneOf<global::System.Guid?, object>? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OneOf<string, double?> EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverterFactory2))]
        public global::LangSmith.OneOf<string, object>? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverterFactory2))]
        public global::LangSmith.OneOf<global::LangSmith.BatchIngestRunsRequestPatchItemInputs, object>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverterFactory2))]
        public global::LangSmith.OneOf<global::LangSmith.BatchIngestRunsRequestPatchItemOutputs, object>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverterFactory2))]
        public global::LangSmith.OneOf<global::System.Collections.Generic.IList<global::LangSmith.BatchIngestRunsRequestPatchItemEventsVariant1Item>, object>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverterFactory2))]
        public global::LangSmith.OneOf<global::System.Collections.Generic.IList<string>, object>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverterFactory2))]
        public global::LangSmith.OneOf<global::LangSmith.BatchIngestRunsRequestPatchItemExtra, object>? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_attachments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverterFactory2))]
        public global::LangSmith.OneOf<global::LangSmith.BatchIngestRunsRequestPatchItemInputAttachments, object>? InputAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_attachments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OneOfJsonConverterFactory2))]
        public global::LangSmith.OneOf<global::LangSmith.BatchIngestRunsRequestPatchItemOutputAttachments, object>? OutputAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}