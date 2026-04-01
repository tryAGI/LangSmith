
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesSnapshotListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 
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
        /// <param name="offset"></param>
        /// <param name="snapshots"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSnapshotListResponse(
            int? offset,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>? snapshots)
        {
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