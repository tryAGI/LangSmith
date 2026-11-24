
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Sandbox cluster an instance-admin registration or rotation wrote.
    /// </summary>
    public sealed partial class AuditLogSandboxCluster
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingress_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IngressUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_uuid")]
        public string? VolumeUuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogSandboxCluster" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ingressUrl"></param>
        /// <param name="volumeUuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogSandboxCluster(
            string name,
            string ingressUrl,
            string? volumeUuid)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IngressUrl = ingressUrl ?? throw new global::System.ArgumentNullException(nameof(ingressUrl));
            this.VolumeUuid = volumeUuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogSandboxCluster" /> class.
        /// </summary>
        public AuditLogSandboxCluster()
        {
        }

    }
}