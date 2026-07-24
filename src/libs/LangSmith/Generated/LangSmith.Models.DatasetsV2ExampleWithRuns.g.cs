
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetsV2ExampleWithRuns
    {
        /// <summary>
        /// `attachment_urls` maps each attachment name to a pre-signed download URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachment_urls")]
        public object? AttachmentUrls { get; set; }

        /// <summary>
        /// `created_at` is when the example was created (RFC3339 date-time).<br/>
        /// Example: 2024-01-15T10:30:00.000Z
        /// </summary>
        /// <example>2024-01-15T10:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// `dataset_id` is the parent dataset UUID.<br/>
        /// Example: 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328
        /// </summary>
        /// <example>0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// `id` is the dataset example UUID.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// `inputs` is the example input payload (arbitrary JSON object).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// `metadata` is arbitrary user-defined JSON metadata on the example.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// `modified_at` is when the example was last modified (RFC3339 date-time).<br/>
        /// Example: 2024-01-15T10:30:00.000Z
        /// </summary>
        /// <example>2024-01-15T10:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// `name` is the example's optional name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// `outputs` is the example reference-output payload (arbitrary JSON object).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// `runs` is the list of experiment runs produced for this example.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? Runs { get; set; }

        /// <summary>
        /// `source_run_id` is the run UUID the example was created from, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_run_id")]
        public global::System.Guid? SourceRunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsV2ExampleWithRuns" /> class.
        /// </summary>
        /// <param name="attachmentUrls">
        /// `attachment_urls` maps each attachment name to a pre-signed download URL.
        /// </param>
        /// <param name="createdAt">
        /// `created_at` is when the example was created (RFC3339 date-time).<br/>
        /// Example: 2024-01-15T10:30:00.000Z
        /// </param>
        /// <param name="datasetId">
        /// `dataset_id` is the parent dataset UUID.<br/>
        /// Example: 0190a1b2-c3d4-7ef0-a5b6-6ea3a82e9328
        /// </param>
        /// <param name="id">
        /// `id` is the dataset example UUID.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="inputs">
        /// `inputs` is the example input payload (arbitrary JSON object).
        /// </param>
        /// <param name="metadata">
        /// `metadata` is arbitrary user-defined JSON metadata on the example.
        /// </param>
        /// <param name="modifiedAt">
        /// `modified_at` is when the example was last modified (RFC3339 date-time).<br/>
        /// Example: 2024-01-15T10:30:00.000Z
        /// </param>
        /// <param name="name">
        /// `name` is the example's optional name.
        /// </param>
        /// <param name="outputs">
        /// `outputs` is the example reference-output payload (arbitrary JSON object).
        /// </param>
        /// <param name="runs">
        /// `runs` is the list of experiment runs produced for this example.
        /// </param>
        /// <param name="sourceRunId">
        /// `source_run_id` is the run UUID the example was created from, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetsV2ExampleWithRuns(
            object? attachmentUrls,
            global::System.DateTime? createdAt,
            global::System.Guid? datasetId,
            global::System.Guid? id,
            object? inputs,
            object? metadata,
            global::System.DateTime? modifiedAt,
            string? name,
            object? outputs,
            global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? runs,
            global::System.Guid? sourceRunId)
        {
            this.AttachmentUrls = attachmentUrls;
            this.CreatedAt = createdAt;
            this.DatasetId = datasetId;
            this.Id = id;
            this.Inputs = inputs;
            this.Metadata = metadata;
            this.ModifiedAt = modifiedAt;
            this.Name = name;
            this.Outputs = outputs;
            this.Runs = runs;
            this.SourceRunId = sourceRunId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsV2ExampleWithRuns" /> class.
        /// </summary>
        public DatasetsV2ExampleWithRuns()
        {
        }

    }
}