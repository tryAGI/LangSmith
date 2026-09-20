
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesServiceURLGrantListResponse
    {
        /// <summary>
        /// This page of the ports the sandbox is shared on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.SandboxesServiceURLGrantResponse> Items { get; set; }

        /// <summary>
        /// Cursor for the next page, or null on the last page. A non-null value is<br/>
        /// the only signal that more pages exist. Treat it as opaque.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesServiceURLGrantListResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// This page of the ports the sandbox is shared on.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page, or null on the last page. A non-null value is<br/>
        /// the only signal that more pages exist. Treat it as opaque.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesServiceURLGrantListResponse(
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesServiceURLGrantResponse> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesServiceURLGrantListResponse" /> class.
        /// </summary>
        public SandboxesServiceURLGrantListResponse()
        {
        }

    }
}