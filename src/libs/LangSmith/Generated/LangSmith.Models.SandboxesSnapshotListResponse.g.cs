
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSnapshotListResponse
    {
        /// <summary>
        /// This page of snapshots.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>? Items { get; set; }

        /// <summary>
        /// Cursor for the next page, or null on the last page. A non-null value is<br/>
        /// the only signal that more pages exist. Treat it as opaque.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Deprecated: use next_cursor. Offset to request for the next page, or 0<br/>
        /// when no pages remain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Deprecated: use items. Duplicates items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshots")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>? Snapshots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSnapshotListResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// This page of snapshots.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page, or null on the last page. A non-null value is<br/>
        /// the only signal that more pages exist. Treat it as opaque.
        /// </param>
        /// <param name="offset">
        /// Deprecated: use next_cursor. Offset to request for the next page, or 0<br/>
        /// when no pages remain.
        /// </param>
        /// <param name="snapshots">
        /// Deprecated: use items. Duplicates items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSnapshotListResponse(
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>? items,
            string? nextCursor,
            int? offset,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>? snapshots)
        {
            this.Items = items;
            this.NextCursor = nextCursor;
            this.Offset = offset;
            this.Snapshots = snapshots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSnapshotListResponse" /> class.
        /// </summary>
        public SandboxesSnapshotListResponse()
        {
        }

    }
}