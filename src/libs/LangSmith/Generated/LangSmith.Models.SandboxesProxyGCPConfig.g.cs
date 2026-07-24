
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesProxyGCPConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxesProxySecretValue ServiceAccountJson { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyGCPConfig" /> class.
        /// </summary>
        /// <param name="scopes"></param>
        /// <param name="serviceAccountJson"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyGCPConfig(
            global::System.Collections.Generic.IList<string> scopes,
            global::LangSmith.SandboxesProxySecretValue serviceAccountJson)
        {
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.ServiceAccountJson = serviceAccountJson ?? throw new global::System.ArgumentNullException(nameof(serviceAccountJson));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyGCPConfig" /> class.
        /// </summary>
        public SandboxesProxyGCPConfig()
        {
        }

    }
}