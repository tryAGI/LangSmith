
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesRegistryListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registries")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesRegistryResponse>? Registries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesRegistryListResponse" /> class.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="registries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesRegistryListResponse(
            int? offset,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesRegistryResponse>? registries)
        {
            this.Offset = offset;
            this.Registries = registries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesRegistryListResponse" /> class.
        /// </summary>
        public SandboxesRegistryListResponse()
        {
        }

    }
}