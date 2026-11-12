
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TracerSessionsCreateSessionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_dataset_id")]
        public global::System.Guid? DefaultDatasetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_keys")]
        public global::System.Collections.Generic.IList<string>? EvaluatorKeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kicked_off_by")]
        public string? KickedOffBy { get; set; }

        /// <summary>
        /// LonglivedTTLDays overrides long-lived trace retention. Null restores the workspace default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longlived_ttl_days")]
        public int? LonglivedTtlDays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_examples")]
        public int? NumExamples { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_repetitions")]
        public int? NumRepetitions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_dataset_id")]
        public global::System.Guid? ReferenceDatasetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_value_ids")]
        public global::System.Collections.Generic.IList<string>? TagValueIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.TracerSessionsCreateSessionRequestTraceTierJsonConverter))]
        public global::LangSmith.TracerSessionsCreateSessionRequestTraceTier? TraceTier { get; set; }

        /// <summary>
        /// Type identifies a tracing project, Agent tracing project, or experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.TracerSessionsCreateSessionRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.TracerSessionsCreateSessionRequestType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionsCreateSessionRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Type identifies a tracing project, Agent tracing project, or experiment.
        /// </param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="description"></param>
        /// <param name="endTime"></param>
        /// <param name="evaluatorKeys"></param>
        /// <param name="extra"></param>
        /// <param name="id"></param>
        /// <param name="kickedOffBy"></param>
        /// <param name="longlivedTtlDays">
        /// LonglivedTTLDays overrides long-lived trace retention. Null restores the workspace default.
        /// </param>
        /// <param name="name"></param>
        /// <param name="numExamples"></param>
        /// <param name="numRepetitions"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="startTime"></param>
        /// <param name="tagValueIds"></param>
        /// <param name="traceTier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionsCreateSessionRequest(
            global::LangSmith.TracerSessionsCreateSessionRequestType type,
            global::System.Guid? defaultDatasetId,
            string? description,
            global::System.DateTime? endTime,
            global::System.Collections.Generic.IList<string>? evaluatorKeys,
            object? extra,
            global::System.Guid? id,
            string? kickedOffBy,
            int? longlivedTtlDays,
            string? name,
            int? numExamples,
            int? numRepetitions,
            global::System.Guid? referenceDatasetId,
            global::System.DateTime? startTime,
            global::System.Collections.Generic.IList<string>? tagValueIds,
            global::LangSmith.TracerSessionsCreateSessionRequestTraceTier? traceTier)
        {
            this.DefaultDatasetId = defaultDatasetId;
            this.Description = description;
            this.EndTime = endTime;
            this.EvaluatorKeys = evaluatorKeys;
            this.Extra = extra;
            this.Id = id;
            this.KickedOffBy = kickedOffBy;
            this.LonglivedTtlDays = longlivedTtlDays;
            this.Name = name;
            this.NumExamples = numExamples;
            this.NumRepetitions = numRepetitions;
            this.ReferenceDatasetId = referenceDatasetId;
            this.StartTime = startTime;
            this.TagValueIds = tagValueIds;
            this.TraceTier = traceTier;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionsCreateSessionRequest" /> class.
        /// </summary>
        public TracerSessionsCreateSessionRequest()
        {
        }

    }
}