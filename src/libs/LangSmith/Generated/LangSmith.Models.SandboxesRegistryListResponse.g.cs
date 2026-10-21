
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
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesRegistryResponse>? Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Deprecated: only applies to limit/offset requests. Use next_cursor when paging with a cursor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Deprecated: use items.
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
        /// <param name="items"></param>
        /// <param name="nextCursor"></param>
        /// <param name="offset">
        /// Deprecated: only applies to limit/offset requests. Use next_cursor when paging with a cursor.
        /// </param>
        /// <param name="registries">
        /// Deprecated: use items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesRegistryListResponse(
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesRegistryResponse>? items,
            string? nextCursor,
            int? offset,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesRegistryResponse>? registries)
        {
            this.Items = items;
            this.NextCursor = nextCursor;
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