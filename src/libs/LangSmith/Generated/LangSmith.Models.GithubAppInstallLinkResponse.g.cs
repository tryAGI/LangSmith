
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GithubAppInstallLinkResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("install_url")]
        public string? InstallUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubAppInstallLinkResponse" /> class.
        /// </summary>
        /// <param name="installUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GithubAppInstallLinkResponse(
            string? installUrl)
        {
            this.InstallUrl = installUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubAppInstallLinkResponse" /> class.
        /// </summary>
        public GithubAppInstallLinkResponse()
        {
        }
    }
}