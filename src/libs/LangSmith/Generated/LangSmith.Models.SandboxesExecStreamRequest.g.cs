
#pragma warning disable CS0618 // Type or member is obsolete

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
        /// Deprecated: use run_config.work_dir. Rejected when run_config is also set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Cwd { get; set; }

        /// <summary>
        /// Deprecated: use run_config.env_vars. Rejected when run_config is also set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// 0 = default, -1 = never idle-kill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_seconds")]
        public int? IdleTimeoutSeconds { get; set; }

        /// <summary>
        /// RunConfig overrides, for this command only, the user, working directory and env the sandbox's commands run with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_config")]
        public global::LangSmith.SandboxapiRunConfig? RunConfig { get; set; }

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
        /// <param name="idleTimeoutSeconds">
        /// 0 = default, -1 = never idle-kill
        /// </param>
        /// <param name="runConfig">
        /// RunConfig overrides, for this command only, the user, working directory and env the sandbox's commands run with.
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
            int? idleTimeoutSeconds,
            global::LangSmith.SandboxapiRunConfig? runConfig,
            string? shell,
            byte[]? stdin,
            int? timeoutSeconds,
            int? ttlSeconds)
        {
            this.Command = command;
            this.CommandId = commandId;
            this.IdleTimeoutSeconds = idleTimeoutSeconds;
            this.RunConfig = runConfig;
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