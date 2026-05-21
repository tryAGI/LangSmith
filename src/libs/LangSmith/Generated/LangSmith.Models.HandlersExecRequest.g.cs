
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HandlersExecRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::LangSmith.SandboxapiCommand? Command { get; set; }

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
        /// Initializes a new instance of the <see cref="HandlersExecRequest" /> class.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cwd"></param>
        /// <param name="env"></param>
        /// <param name="shell"></param>
        /// <param name="timeoutSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HandlersExecRequest(
            global::LangSmith.SandboxapiCommand? command,
            string? cwd,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            string? shell,
            int? timeoutSeconds)
        {
            this.Command = command;
            this.Cwd = cwd;
            this.Env = env;
            this.Shell = shell;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HandlersExecRequest" /> class.
        /// </summary>
        public HandlersExecRequest()
        {
        }

    }
}