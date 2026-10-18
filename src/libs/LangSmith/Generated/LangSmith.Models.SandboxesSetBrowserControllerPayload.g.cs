
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSetBrowserControllerPayload
    {
        /// <summary>
        /// Controller is "user" to give the window to a person, or "agent" to give<br/>
        /// it back to the attached sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controller")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesSetBrowserControllerPayloadControllerJsonConverter))]
        public global::LangSmith.SandboxesSetBrowserControllerPayloadController? Controller { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSetBrowserControllerPayload" /> class.
        /// </summary>
        /// <param name="controller">
        /// Controller is "user" to give the window to a person, or "agent" to give<br/>
        /// it back to the attached sandbox.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSetBrowserControllerPayload(
            global::LangSmith.SandboxesSetBrowserControllerPayloadController? controller)
        {
            this.Controller = controller;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSetBrowserControllerPayload" /> class.
        /// </summary>
        public SandboxesSetBrowserControllerPayload()
        {
        }

    }
}