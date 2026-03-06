
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesClaimListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxes")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesClaimResponse>? Sandboxes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesClaimListResponse" /> class.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="sandboxes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesClaimListResponse(
            int? offset,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesClaimResponse>? sandboxes)
        {
            this.Offset = offset;
            this.Sandboxes = sandboxes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesClaimListResponse" /> class.
        /// </summary>
        public SandboxesClaimListResponse()
        {
        }
    }
}