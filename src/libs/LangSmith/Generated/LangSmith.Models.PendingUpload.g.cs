
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Tracks a file upload that is in progress or needs to be verified.<br/>
    /// This allows us to handle cases where:<br/>
    /// 1. File upload succeeds but progress update fails<br/>
    /// 2. Job crashes during upload<br/>
    /// 3. Need to verify uploaded files before advancing cursor
    /// </summary>
    public sealed partial class PendingUpload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_cursor")]
        public string? TargetCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingUpload" /> class.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="rowsCount"></param>
        /// <param name="targetCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PendingUpload(
            string filePath,
            int rowsCount,
            string? targetCursor)
        {
            this.TargetCursor = targetCursor;
            this.FilePath = filePath ?? throw new global::System.ArgumentNullException(nameof(filePath));
            this.RowsCount = rowsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingUpload" /> class.
        /// </summary>
        public PendingUpload()
        {
        }
    }
}