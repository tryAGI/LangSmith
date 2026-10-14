
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesProxyGCPServiceAccountConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxesProxySecretValue ServiceAccountJson { get; set; }

        /// <summary>
        /// Scopes are the OAuth scopes requested for the access token. Omit them to use https://www.googleapis.com/auth/cloud-platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyGCPServiceAccountConfig" /> class.
        /// </summary>
        /// <param name="serviceAccountJson"></param>
        /// <param name="scopes">
        /// Scopes are the OAuth scopes requested for the access token. Omit them to use https://www.googleapis.com/auth/cloud-platform.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyGCPServiceAccountConfig(
            global::LangSmith.SandboxesProxySecretValue serviceAccountJson,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.ServiceAccountJson = serviceAccountJson ?? throw new global::System.ArgumentNullException(nameof(serviceAccountJson));
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyGCPServiceAccountConfig" /> class.
        /// </summary>
        public SandboxesProxyGCPServiceAccountConfig()
        {
        }

    }
}