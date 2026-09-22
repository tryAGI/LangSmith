
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesDataPlaneFleetOIDCSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audience { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_claim")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailClaim { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups_claim")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupsClaim { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_claim")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectClaim { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_claim")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantClaim { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_mappings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> TenantMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneFleetOIDCSettings" /> class.
        /// </summary>
        /// <param name="audience"></param>
        /// <param name="emailClaim"></param>
        /// <param name="groupsClaim"></param>
        /// <param name="isEnabled"></param>
        /// <param name="issuerUrl"></param>
        /// <param name="provider"></param>
        /// <param name="subjectClaim"></param>
        /// <param name="tenantClaim"></param>
        /// <param name="tenantMappings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesDataPlaneFleetOIDCSettings(
            string audience,
            string emailClaim,
            string groupsClaim,
            bool isEnabled,
            string issuerUrl,
            string provider,
            string subjectClaim,
            string tenantClaim,
            global::System.Collections.Generic.Dictionary<string, string> tenantMappings)
        {
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
            this.EmailClaim = emailClaim ?? throw new global::System.ArgumentNullException(nameof(emailClaim));
            this.GroupsClaim = groupsClaim ?? throw new global::System.ArgumentNullException(nameof(groupsClaim));
            this.IsEnabled = isEnabled;
            this.IssuerUrl = issuerUrl ?? throw new global::System.ArgumentNullException(nameof(issuerUrl));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.SubjectClaim = subjectClaim ?? throw new global::System.ArgumentNullException(nameof(subjectClaim));
            this.TenantClaim = tenantClaim ?? throw new global::System.ArgumentNullException(nameof(tenantClaim));
            this.TenantMappings = tenantMappings ?? throw new global::System.ArgumentNullException(nameof(tenantMappings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneFleetOIDCSettings" /> class.
        /// </summary>
        public DataPlanesDataPlaneFleetOIDCSettings()
        {
        }

    }
}