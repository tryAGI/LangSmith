
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesGlobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiFileInfo>? Matches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        public bool? Truncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesGlobResponse" /> class.
        /// </summary>
        /// <param name="matches"></param>
        /// <param name="truncated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesGlobResponse(
            global::System.Collections.Generic.IList<global::LangSmith.SandboxapiFileInfo>? matches,
            bool? truncated)
        {
            this.Matches = matches;
            this.Truncated = truncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesGlobResponse" /> class.
        /// </summary>
        public SandboxesGlobResponse()
        {
        }

    }
}