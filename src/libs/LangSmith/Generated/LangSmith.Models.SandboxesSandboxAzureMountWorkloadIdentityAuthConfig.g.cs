
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxAzureMountWorkloadIdentityAuthConfig
    {
        /// <summary>
        /// TenantID is the Entra tenant (directory) ID, a GUID. Setting it selects workload identity: LangSmith signs an OIDC token for this workspace and exchanges it at Entra ID for storage access tokens of client_id. Cannot be changed after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// ClientID is the application (client) ID, a GUID, of the app registration or user-assigned managed identity whose federated identity credential trusts LangSmith's issuer. Required with tenant_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// SubjectScope picks the token subject the federated credential trusts: "workspace" (the default) or "tag:&lt;tag value id&gt;", which must be one of the sandbox's tag_value_ids. Only valid with tenant_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_scope")]
        public string? SubjectScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxAzureMountWorkloadIdentityAuthConfig" /> class.
        /// </summary>
        /// <param name="tenantId">
        /// TenantID is the Entra tenant (directory) ID, a GUID. Setting it selects workload identity: LangSmith signs an OIDC token for this workspace and exchanges it at Entra ID for storage access tokens of client_id. Cannot be changed after creation.
        /// </param>
        /// <param name="clientId">
        /// ClientID is the application (client) ID, a GUID, of the app registration or user-assigned managed identity whose federated identity credential trusts LangSmith's issuer. Required with tenant_id.
        /// </param>
        /// <param name="subjectScope">
        /// SubjectScope picks the token subject the federated credential trusts: "workspace" (the default) or "tag:&lt;tag value id&gt;", which must be one of the sandbox's tag_value_ids. Only valid with tenant_id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxAzureMountWorkloadIdentityAuthConfig(
            string tenantId,
            string clientId,
            string? subjectScope)
        {
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.SubjectScope = subjectScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxAzureMountWorkloadIdentityAuthConfig" /> class.
        /// </summary>
        public SandboxesSandboxAzureMountWorkloadIdentityAuthConfig()
        {
        }

    }
}