
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSnapshotImageConfig
    {
        /// <summary>
        /// Cmd follows Entrypoint, as CMD: its arguments, or the whole command when Entrypoint is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmd")]
        public global::System.Collections.Generic.IList<string>? Cmd { get; set; }

        /// <summary>
        /// Entrypoint is the program the command starts with, as ENTRYPOINT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint")]
        public global::System.Collections.Generic.IList<string>? Entrypoint { get; set; }

        /// <summary>
        /// ExposedPorts are the TCP ports the command listens on, as EXPOSE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exposed_ports")]
        public global::System.Collections.Generic.IList<int>? ExposedPorts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSnapshotImageConfig" /> class.
        /// </summary>
        /// <param name="cmd">
        /// Cmd follows Entrypoint, as CMD: its arguments, or the whole command when Entrypoint is empty.
        /// </param>
        /// <param name="entrypoint">
        /// Entrypoint is the program the command starts with, as ENTRYPOINT.
        /// </param>
        /// <param name="exposedPorts">
        /// ExposedPorts are the TCP ports the command listens on, as EXPOSE.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSnapshotImageConfig(
            global::System.Collections.Generic.IList<string>? cmd,
            global::System.Collections.Generic.IList<string>? entrypoint,
            global::System.Collections.Generic.IList<int>? exposedPorts)
        {
            this.Cmd = cmd;
            this.Entrypoint = entrypoint;
            this.ExposedPorts = exposedPorts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSnapshotImageConfig" /> class.
        /// </summary>
        public SandboxesSnapshotImageConfig()
        {
        }

    }
}