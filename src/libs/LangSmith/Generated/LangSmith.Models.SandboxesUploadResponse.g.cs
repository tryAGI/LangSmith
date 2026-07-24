
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesUploadResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("written")]
        public int? Written { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUploadResponse" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="written"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesUploadResponse(
            string? path,
            int? written)
        {
            this.Path = path;
            this.Written = written;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUploadResponse" /> class.
        /// </summary>
        public SandboxesUploadResponse()
        {
        }

    }
}