
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesDownloadURLPayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_disposition")]
        public string? ContentDisposition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// ExpiresInSeconds is optional; a link with no expiry never expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesDownloadURLPayload" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contentDisposition"></param>
        /// <param name="contentType"></param>
        /// <param name="expiresInSeconds">
        /// ExpiresInSeconds is optional; a link with no expiry never expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesDownloadURLPayload(
            string path,
            string? contentDisposition,
            string? contentType,
            int? expiresInSeconds)
        {
            this.ContentDisposition = contentDisposition;
            this.ContentType = contentType;
            this.ExpiresInSeconds = expiresInSeconds;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesDownloadURLPayload" /> class.
        /// </summary>
        public SandboxesDownloadURLPayload()
        {
        }

    }
}