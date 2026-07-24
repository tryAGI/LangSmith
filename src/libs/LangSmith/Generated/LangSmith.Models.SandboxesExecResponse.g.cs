
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesExecResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exit_code")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        public string? Stderr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        public string? Stdout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesExecResponse" /> class.
        /// </summary>
        /// <param name="exitCode"></param>
        /// <param name="stderr"></param>
        /// <param name="stdout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesExecResponse(
            int? exitCode,
            string? stderr,
            string? stdout)
        {
            this.ExitCode = exitCode;
            this.Stderr = stderr;
            this.Stdout = stdout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesExecResponse" /> class.
        /// </summary>
        public SandboxesExecResponse()
        {
        }

    }
}