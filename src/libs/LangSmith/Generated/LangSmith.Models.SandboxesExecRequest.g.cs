
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesExecRequest
    {
        /// <summary>
        /// Command accepts either a shell command string or an argv string array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::System.Collections.Generic.IList<string>? Command { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesExecRequest" /> class.
        /// </summary>
        /// <param name="command">
        /// Command accepts either a shell command string or an argv string array.
        /// </param>
        /// <param name="runConfig">
        /// RunConfig overrides, for this command only, the user, working directory and env the sandbox's commands run with.
        /// </param>
        /// <param name="shell"></param>
        /// <param name="timeoutSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesExecRequest(
            global::System.Collections.Generic.IList<string>? command,
            global::LangSmith.SandboxapiRunConfig? runConfig,
            string? shell,
            int? timeoutSeconds)
        {
            this.Command = command;
            this.RunConfig = runConfig;
            this.Shell = shell;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesExecRequest" /> class.
        /// </summary>
        public SandboxesExecRequest()
        {
        }

    }
}