
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
        /// CSPSandboxFlags loosen the CSP sandbox the file is served under; omit for the most restrictive policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("csp_sandbox_flags")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>? CspSandboxFlags { get; set; }

        /// <summary>
        /// CSPSourceBundles allow the served file to fetch from named third-party origins; omit to send no fetch directive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("csp_source_bundles")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>? CspSourceBundles { get; set; }

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
        /// <param name="cspSandboxFlags">
        /// CSPSandboxFlags loosen the CSP sandbox the file is served under; omit for the most restrictive policy.
        /// </param>
        /// <param name="cspSourceBundles">
        /// CSPSourceBundles allow the served file to fetch from named third-party origins; omit to send no fetch directive.
        /// </param>
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
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>? cspSandboxFlags,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>? cspSourceBundles,
            int? expiresInSeconds)
        {
            this.ContentDisposition = contentDisposition;
            this.ContentType = contentType;
            this.CspSandboxFlags = cspSandboxFlags;
            this.CspSourceBundles = cspSourceBundles;
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