
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesBatchActivityResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesActivityResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBatchActivityResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesBatchActivityResponse(
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesActivityResult>? results)
        {
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBatchActivityResponse" /> class.
        /// </summary>
        public SandboxesBatchActivityResponse()
        {
        }
    }
}