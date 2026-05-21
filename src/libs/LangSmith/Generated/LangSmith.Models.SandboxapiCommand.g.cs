
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxapiCommand
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isShell")]
        public bool? IsShell { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiCommand" /> class.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="isShell"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiCommand(
            global::System.Collections.Generic.IList<string>? args,
            bool? isShell)
        {
            this.Args = args;
            this.IsShell = isShell;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiCommand" /> class.
        /// </summary>
        public SandboxapiCommand()
        {
        }

    }
}