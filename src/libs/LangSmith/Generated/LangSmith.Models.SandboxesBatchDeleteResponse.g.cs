
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesBatchDeleteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public global::System.Collections.Generic.IList<string>? Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBatchDeleteSkipped>? Skipped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBatchDeleteResponse" /> class.
        /// </summary>
        /// <param name="deleted"></param>
        /// <param name="skipped"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesBatchDeleteResponse(
            global::System.Collections.Generic.IList<string>? deleted,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesBatchDeleteSkipped>? skipped)
        {
            this.Deleted = deleted;
            this.Skipped = skipped;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBatchDeleteResponse" /> class.
        /// </summary>
        public SandboxesBatchDeleteResponse()
        {
        }
    }
}