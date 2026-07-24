
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxapiFileInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_dir")]
        public bool? IsDir { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public string? ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiFileInfo" /> class.
        /// </summary>
        /// <param name="isDir"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="path"></param>
        /// <param name="sizeBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiFileInfo(
            bool? isDir,
            string? modifiedAt,
            string? path,
            long? sizeBytes)
        {
            this.IsDir = isDir;
            this.ModifiedAt = modifiedAt;
            this.Path = path;
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiFileInfo" /> class.
        /// </summary>
        public SandboxapiFileInfo()
        {
        }

    }
}