
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulk_export_destination_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BulkExportDestinationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.BulkExportFormatJsonConverter))]
        public global::LangSmith.BulkExportFormat? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.BulkExportCompressionJsonConverter))]
        public global::LangSmith.BulkExportCompression? Compression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.BulkExportStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.BulkExportStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExport" /> class.
        /// </summary>
        /// <param name="bulkExportDestinationId"></param>
        /// <param name="sessionId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="format"></param>
        /// <param name="compression"></param>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="finishedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkExport(
            global::System.Guid bulkExportDestinationId,
            global::System.Guid sessionId,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Guid id,
            global::System.Guid tenantId,
            global::LangSmith.BulkExportStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? finishedAt,
            global::LangSmith.BulkExportFormat? format,
            global::LangSmith.BulkExportCompression? compression)
        {
            this.BulkExportDestinationId = bulkExportDestinationId;
            this.SessionId = sessionId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Id = id;
            this.TenantId = tenantId;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FinishedAt = finishedAt;
            this.Format = format;
            this.Compression = compression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExport" /> class.
        /// </summary>
        public BulkExport()
        {
        }
    }
}