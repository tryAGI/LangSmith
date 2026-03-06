
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesPoolListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pools")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesPoolResponse>? Pools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesPoolListResponse" /> class.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="pools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesPoolListResponse(
            int? offset,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesPoolResponse>? pools)
        {
            this.Offset = offset;
            this.Pools = pools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesPoolListResponse" /> class.
        /// </summary>
        public SandboxesPoolListResponse()
        {
        }
    }
}