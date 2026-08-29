
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesExecStreamRequest
    {
        /// <summary>
        /// Command accepts either a shell command string or an argv string array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::System.Collections.Generic.IList<string>? Command { get; set; }

        /// <summary>
        /// CommandID makes the request idempotent: a known ID attaches to that<br/>
        /// running command instead of starting a second one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        public string? Cwd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// 0 = default, -1 = never idle-kill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_seconds")]
        public int? IdleTimeoutSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shell")]
        public string? Shell { get; set; }

        /// <summary>
        /// Stdin is the process's entire standard input, base64 on the wire. It is<br/>
        /// written once when the command is spawned and then closed, so the process<br/>
        /// reads EOF; there is no stdin streaming on this endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdin")]
        public byte[]? Stdin { get; set; }

        /// <summary>
        /// 0 = no timeout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// 0 = default, -1 = keep forever
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        public int? TtlSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesExecStreamRequest" /> class.
        /// </summary>
        /// <param name="command">
        /// Command accepts either a shell command string or an argv string array.
        /// </param>
        /// <param name="commandId">
        /// CommandID makes the request idempotent: a known ID attaches to that<br/>
        /// running command instead of starting a second one.
        /// </param>
        /// <param name="cwd"></param>
        /// <param name="env"></param>
        /// <param name="idleTimeoutSeconds">
        /// 0 = default, -1 = never idle-kill
        /// </param>
        /// <param name="shell"></param>
        /// <param name="stdin">
        /// Stdin is the process's entire standard input, base64 on the wire. It is<br/>
        /// written once when the command is spawned and then closed, so the process<br/>
        /// reads EOF; there is no stdin streaming on this endpoint.
        /// </param>
        /// <param name="timeoutSeconds">
        /// 0 = no timeout
        /// </param>
        /// <param name="ttlSeconds">
        /// 0 = default, -1 = keep forever
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesExecStreamRequest(
            global::System.Collections.Generic.IList<string>? command,
            string? commandId,
            string? cwd,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            int? idleTimeoutSeconds,
            string? shell,
            byte[]? stdin,
            int? timeoutSeconds,
            int? ttlSeconds)
        {
            this.Command = command;
            this.CommandId = commandId;
            this.Cwd = cwd;
            this.Env = env;
            this.IdleTimeoutSeconds = idleTimeoutSeconds;
            this.Shell = shell;
            this.Stdin = stdin;
            this.TimeoutSeconds = timeoutSeconds;
            this.TtlSeconds = ttlSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesExecStreamRequest" /> class.
        /// </summary>
        public SandboxesExecStreamRequest()
        {
        }

    }
}