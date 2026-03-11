
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportRunProgress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_written")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int RowsWritten { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exported_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<string> ExportedFiles { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ExportPath { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_cursor")]
        public string? LatestCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_upload")]
        public global::LangSmith.PendingUpload? PendingUpload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRunProgress" /> class.
        /// </summary>
        /// <param name="rowsWritten"></param>
        /// <param name="exportedFiles"></param>
        /// <param name="exportPath"></param>
        /// <param name="latestCursor"></param>
        /// <param name="pendingUpload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkExportRunProgress(
            int rowsWritten,
            global::System.Collections.Generic.IList<string> exportedFiles,
            string exportPath,
            string? latestCursor,
            global::LangSmith.PendingUpload? pendingUpload)
        {
            this.RowsWritten = rowsWritten;
            this.ExportedFiles = exportedFiles ?? throw new global::System.ArgumentNullException(nameof(exportedFiles));
            this.ExportPath = exportPath ?? throw new global::System.ArgumentNullException(nameof(exportPath));
            this.LatestCursor = latestCursor;
            this.PendingUpload = pendingUpload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRunProgress" /> class.
        /// </summary>
        public BulkExportRunProgress()
        {
        }
    }
}