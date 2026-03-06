
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommitsCommitResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash")]
        public string? CommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<global::LangSmith.CommitsExampleRun>? Examples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        public object? Manifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_config")]
        public object? ModelConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_provider")]
        public string? ModelProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitsCommitResponse" /> class.
        /// </summary>
        /// <param name="commitHash"></param>
        /// <param name="examples"></param>
        /// <param name="manifest"></param>
        /// <param name="modelConfig"></param>
        /// <param name="modelProvider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommitsCommitResponse(
            string? commitHash,
            global::System.Collections.Generic.IList<global::LangSmith.CommitsExampleRun>? examples,
            object? manifest,
            object? modelConfig,
            string? modelProvider)
        {
            this.CommitHash = commitHash;
            this.Examples = examples;
            this.Manifest = manifest;
            this.ModelConfig = modelConfig;
            this.ModelProvider = modelProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitsCommitResponse" /> class.
        /// </summary>
        public CommitsCommitResponse()
        {
        }
    }
}