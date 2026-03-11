
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulk_export_destination_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid BulkExportDestinationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Default Value: Parquet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.BulkExportFormatJsonConverter))]
        public global::LangSmith.BulkExportFormat? Format { get; set; }

        /// <summary>
        /// Enum for bulk export format versions.<br/>
        /// Default Value: v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.BulkExportFormatVersionJsonConverter))]
        public global::LangSmith.BulkExportFormatVersion? FormatVersion { get; set; }

        /// <summary>
        /// Default Value: gzip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.BulkExportCompressionJsonConverter))]
        public global::LangSmith.BulkExportCompression? Compression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_hours")]
        public int? IntervalHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_fields")]
        public global::System.Collections.Generic.IList<string>? ExportFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportCreate" /> class.
        /// </summary>
        /// <param name="bulkExportDestinationId"></param>
        /// <param name="sessionId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="filter"></param>
        /// <param name="format">
        /// Default Value: Parquet
        /// </param>
        /// <param name="formatVersion">
        /// Enum for bulk export format versions.<br/>
        /// Default Value: v1
        /// </param>
        /// <param name="compression">
        /// Default Value: gzip
        /// </param>
        /// <param name="intervalHours"></param>
        /// <param name="exportFields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkExportCreate(
            global::System.Guid bulkExportDestinationId,
            global::System.Guid sessionId,
            global::System.DateTime startTime,
            global::System.DateTime? endTime,
            string? filter,
            global::LangSmith.BulkExportFormat? format,
            global::LangSmith.BulkExportFormatVersion? formatVersion,
            global::LangSmith.BulkExportCompression? compression,
            int? intervalHours,
            global::System.Collections.Generic.IList<string>? exportFields)
        {
            this.BulkExportDestinationId = bulkExportDestinationId;
            this.SessionId = sessionId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Filter = filter;
            this.Format = format;
            this.FormatVersion = formatVersion;
            this.Compression = compression;
            this.IntervalHours = intervalHours;
            this.ExportFields = exportFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportCreate" /> class.
        /// </summary>
        public BulkExportCreate()
        {
        }
    }
}