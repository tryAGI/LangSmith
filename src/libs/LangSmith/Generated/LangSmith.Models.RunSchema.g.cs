
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Run schema.
    /// </summary>
    public sealed partial class RunSchema
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.RunSchemaInputs, object>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_preview")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, object>? InputsPreview { get; set; }

        /// <summary>
        /// Enum for run types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RunTypeEnum RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.DateTime?, object>? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.RunSchemaExtra, object>? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, object>? Error { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_order")]
        public int? ExecutionOrder { get; set; } = 1;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serialized")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.RunSchemaSerialized, object>? Serialized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.RunSchemaOutputs, object>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_preview")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, object>? OutputsPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Guid?, object>? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Guid?, object>? ManifestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_s3_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Guid?, object>? ManifestS3Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.RunSchemaEventsVariant1Item>, object>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_s3_urls")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.RunSchemaInputsS3Urls, object>? InputsS3Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_s3_urls")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.RunSchemaOutputsS3Urls, object>? OutputsS3Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_urls")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.RunSchemaS3Urls, object>? S3Urls { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("child_run_ids")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ChildRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direct_child_run_ids")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? DirectChildRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_ids")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ParentRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_stats")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.RunSchemaFeedbackStats, object>? FeedbackStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_example_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Guid?, object>? ReferenceExampleId { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; } = 0;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; } = 0;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, object>? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, object>? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, object>? CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Guid?, object>? PriceModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_token_time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.DateTime?, object>? FirstTokenTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_queued_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.DateTime?, object>? LastQueuedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_dataset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<bool?, object>? InDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_token")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Guid?, object>? ShareToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.TraceTier3?, object>? TraceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_first_received_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.DateTime?, object>? TraceFirstReceivedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<int?, object>? TtlSeconds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_upgrade")]
        public bool? TraceUpgrade { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}