
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesExecStreamResumeRequest
    {
        /// <summary>
        /// CommandID names the command to attach to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr_offset")]
        public int? StderrOffset { get; set; }

        /// <summary>
        /// StdoutOffset and StderrOffset are where to continue from, and are also the<br/>
        /// ack for every buffered byte below them. Zero replays from the beginning,<br/>
        /// which is what a retry sends when the stream broke before any output arrived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout_offset")]
        public long? StdoutOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesExecStreamResumeRequest" /> class.
        /// </summary>
        /// <param name="commandId">
        /// CommandID names the command to attach to.
        /// </param>
        /// <param name="stderrOffset"></param>
        /// <param name="stdoutOffset">
        /// StdoutOffset and StderrOffset are where to continue from, and are also the<br/>
        /// ack for every buffered byte below them. Zero replays from the beginning,<br/>
        /// which is what a retry sends when the stream broke before any output arrived.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesExecStreamResumeRequest(
            string? commandId,
            int? stderrOffset,
            long? stdoutOffset)
        {
            this.CommandId = commandId;
            this.StderrOffset = stderrOffset;
            this.StdoutOffset = stdoutOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesExecStreamResumeRequest" /> class.
        /// </summary>
        public SandboxesExecStreamResumeRequest()
        {
        }

    }
}