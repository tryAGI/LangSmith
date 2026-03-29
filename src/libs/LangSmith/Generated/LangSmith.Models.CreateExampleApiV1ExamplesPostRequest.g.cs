
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Create class for Example.
    /// </summary>
    public sealed partial class CreateExampleApiV1ExamplesPostRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_run_id")]
        public global::System.Guid? SourceRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// Default Value: base
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? Split { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_source_run_io")]
        public bool? UseSourceRunIo { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_source_run_attachments")]
        public global::System.Collections.Generic.IList<string>? UseSourceRunAttachments { get; set; }

        /// <summary>
        /// Use Legacy Message Format for LLM runs<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_legacy_message_format")]
        public bool? UseLegacyMessageFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExampleApiV1ExamplesPostRequest" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="outputs"></param>
        /// <param name="sourceRunId"></param>
        /// <param name="metadata"></param>
        /// <param name="inputs"></param>
        /// <param name="split">
        /// Default Value: base
        /// </param>
        /// <param name="id"></param>
        /// <param name="useSourceRunIo">
        /// Default Value: false
        /// </param>
        /// <param name="useSourceRunAttachments">
        /// Default Value: []
        /// </param>
        /// <param name="useLegacyMessageFormat">
        /// Use Legacy Message Format for LLM runs<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateExampleApiV1ExamplesPostRequest(
            global::System.Guid datasetId,
            object? outputs,
            global::System.Guid? sourceRunId,
            object? metadata,
            object? inputs,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? split,
            global::System.Guid? id,
            bool? useSourceRunIo,
            global::System.Collections.Generic.IList<string>? useSourceRunAttachments,
            bool? useLegacyMessageFormat,
            string? createdAt)
        {
            this.Outputs = outputs;
            this.DatasetId = datasetId;
            this.SourceRunId = sourceRunId;
            this.Metadata = metadata;
            this.Inputs = inputs;
            this.Split = split;
            this.Id = id;
            this.UseSourceRunIo = useSourceRunIo;
            this.UseSourceRunAttachments = useSourceRunAttachments;
            this.UseLegacyMessageFormat = useLegacyMessageFormat;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExampleApiV1ExamplesPostRequest" /> class.
        /// </summary>
        public CreateExampleApiV1ExamplesPostRequest()
        {
        }
    }
}