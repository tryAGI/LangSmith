
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxapiRunConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env_vars")]
        public global::System.Collections.Generic.Dictionary<string, string>? EnvVars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("work_dir")]
        public string? WorkDir { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiRunConfig" /> class.
        /// </summary>
        /// <param name="envVars"></param>
        /// <param name="user"></param>
        /// <param name="workDir"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiRunConfig(
            global::System.Collections.Generic.Dictionary<string, string>? envVars,
            string? user,
            string? workDir)
        {
            this.EnvVars = envVars;
            this.User = user;
            this.WorkDir = workDir;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiRunConfig" /> class.
        /// </summary>
        public SandboxapiRunConfig()
        {
        }

    }
}