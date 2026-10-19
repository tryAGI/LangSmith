
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesBrowserWindowLinks
    {
        /// <summary>
        /// ActURL also lets the person take control of the window, use it, and<br/>
        /// hand it back.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("act_url")]
        public string? ActUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// ViewURL shows the window and takes no input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view_url")]
        public string? ViewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBrowserWindowLinks" /> class.
        /// </summary>
        /// <param name="actUrl">
        /// ActURL also lets the person take control of the window, use it, and<br/>
        /// hand it back.
        /// </param>
        /// <param name="expiresAt"></param>
        /// <param name="viewUrl">
        /// ViewURL shows the window and takes no input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesBrowserWindowLinks(
            string? actUrl,
            global::System.DateTime? expiresAt,
            string? viewUrl)
        {
            this.ActUrl = actUrl;
            this.ExpiresAt = expiresAt;
            this.ViewUrl = viewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBrowserWindowLinks" /> class.
        /// </summary>
        public SandboxesBrowserWindowLinks()
        {
        }

    }
}