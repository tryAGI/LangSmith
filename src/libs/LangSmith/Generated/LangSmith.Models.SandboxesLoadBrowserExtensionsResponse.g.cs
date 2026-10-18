
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesLoadBrowserExtensionsResponse
    {
        /// <summary>
        /// Loaded are the ids of the extensions this call loaded; empty when Chrome<br/>
        /// already had every extension in the directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loaded")]
        public global::System.Collections.Generic.IList<string>? Loaded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesLoadBrowserExtensionsResponse" /> class.
        /// </summary>
        /// <param name="loaded">
        /// Loaded are the ids of the extensions this call loaded; empty when Chrome<br/>
        /// already had every extension in the directory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesLoadBrowserExtensionsResponse(
            global::System.Collections.Generic.IList<string>? loaded)
        {
            this.Loaded = loaded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesLoadBrowserExtensionsResponse" /> class.
        /// </summary>
        public SandboxesLoadBrowserExtensionsResponse()
        {
        }

    }
}