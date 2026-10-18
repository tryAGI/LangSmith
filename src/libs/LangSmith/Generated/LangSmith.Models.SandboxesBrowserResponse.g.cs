
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesBrowserResponse
    {
        /// <summary>
        /// Attachments are listed only while the browser is running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserAttachment>? Attachments { get; set; }

        /// <summary>
        /// HiDPI reports whether pages render at twice the resolution. It is<br/>
        /// reported only while the browser is running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidpi")]
        public bool? Hidpi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBrowserResponse" /> class.
        /// </summary>
        /// <param name="attachments">
        /// Attachments are listed only while the browser is running.
        /// </param>
        /// <param name="hidpi">
        /// HiDPI reports whether pages render at twice the resolution. It is<br/>
        /// reported only while the browser is running.
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesBrowserResponse(
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserAttachment>? attachments,
            bool? hidpi,
            string? id,
            string? name,
            string? status)
        {
            this.Attachments = attachments;
            this.Hidpi = hidpi;
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBrowserResponse" /> class.
        /// </summary>
        public SandboxesBrowserResponse()
        {
        }

    }
}