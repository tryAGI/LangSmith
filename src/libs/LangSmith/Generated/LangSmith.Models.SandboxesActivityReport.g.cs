
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesActivityReport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k8s_sandbox_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string K8sSandboxName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesActivityReport" /> class.
        /// </summary>
        /// <param name="k8sSandboxName"></param>
        /// <param name="tenantId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesActivityReport(
            string k8sSandboxName,
            string tenantId)
        {
            this.K8sSandboxName = k8sSandboxName ?? throw new global::System.ArgumentNullException(nameof(k8sSandboxName));
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesActivityReport" /> class.
        /// </summary>
        public SandboxesActivityReport()
        {
        }
    }
}