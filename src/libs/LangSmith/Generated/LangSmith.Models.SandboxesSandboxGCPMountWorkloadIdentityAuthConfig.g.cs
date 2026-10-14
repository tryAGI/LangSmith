
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxGCPMountWorkloadIdentityAuthConfig
    {
        /// <summary>
        /// WorkloadIdentityProvider federates an OIDC token LangSmith signs for this workspace through Workload Identity Federation instead of a service account key: //iam.googleapis.com/projects/&lt;number&gt;/locations/global/workloadIdentityPools/&lt;pool&gt;/providers/&lt;provider&gt;. Mutually exclusive with service_account_json. Cannot be changed after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadIdentityProvider { get; set; }

        /// <summary>
        /// ServiceAccountEmail is the service account to impersonate with the federated token. Omit it to use the federated principal directly. Only valid with workload_identity_provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_email")]
        public string? ServiceAccountEmail { get; set; }

        /// <summary>
        /// SubjectScope picks the token subject the provider trusts: "workspace" (the default) or "tag:&lt;tag value id&gt;", which must be one of the sandbox's tag_value_ids. Only valid with workload_identity_provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_scope")]
        public string? SubjectScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxGCPMountWorkloadIdentityAuthConfig" /> class.
        /// </summary>
        /// <param name="workloadIdentityProvider">
        /// WorkloadIdentityProvider federates an OIDC token LangSmith signs for this workspace through Workload Identity Federation instead of a service account key: //iam.googleapis.com/projects/&lt;number&gt;/locations/global/workloadIdentityPools/&lt;pool&gt;/providers/&lt;provider&gt;. Mutually exclusive with service_account_json. Cannot be changed after creation.
        /// </param>
        /// <param name="serviceAccountEmail">
        /// ServiceAccountEmail is the service account to impersonate with the federated token. Omit it to use the federated principal directly. Only valid with workload_identity_provider.
        /// </param>
        /// <param name="subjectScope">
        /// SubjectScope picks the token subject the provider trusts: "workspace" (the default) or "tag:&lt;tag value id&gt;", which must be one of the sandbox's tag_value_ids. Only valid with workload_identity_provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxGCPMountWorkloadIdentityAuthConfig(
            string workloadIdentityProvider,
            string? serviceAccountEmail,
            string? subjectScope)
        {
            this.WorkloadIdentityProvider = workloadIdentityProvider ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityProvider));
            this.ServiceAccountEmail = serviceAccountEmail;
            this.SubjectScope = subjectScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxGCPMountWorkloadIdentityAuthConfig" /> class.
        /// </summary>
        public SandboxesSandboxGCPMountWorkloadIdentityAuthConfig()
        {
        }

    }
}