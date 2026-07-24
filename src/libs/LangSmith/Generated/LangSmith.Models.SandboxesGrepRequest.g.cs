
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesGrepRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glob")]
        public string? Glob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesGrepRequest" /> class.
        /// </summary>
        /// <param name="glob"></param>
        /// <param name="limit"></param>
        /// <param name="path"></param>
        /// <param name="pattern"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesGrepRequest(
            string? glob,
            int? limit,
            string? path,
            string? pattern)
        {
            this.Glob = glob;
            this.Limit = limit;
            this.Path = path;
            this.Pattern = pattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesGrepRequest" /> class.
        /// </summary>
        public SandboxesGrepRequest()
        {
        }

    }
}