
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulk_export_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid BulkExportId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.BulkExportRunMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.BulkExportRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.BulkExportRunStatus Status { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_number")]
        public int? RetryNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public object? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRun" /> class.
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="metadata"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="retryNumber">
        /// Default Value: 0
        /// </param>
        /// <param name="errors"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="finishedAt"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkExportRun(
            global::System.Guid bulkExportId,
            global::LangSmith.BulkExportRunMetadata metadata,
            global::System.Guid id,
            global::LangSmith.BulkExportRunStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int? retryNumber,
            object? errors,
            global::System.DateTime? finishedAt,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime)
        {
            this.BulkExportId = bulkExportId;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Id = id;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.RetryNumber = retryNumber;
            this.Errors = errors;
            this.FinishedAt = finishedAt;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRun" /> class.
        /// </summary>
        public BulkExportRun()
        {
        }
    }
}