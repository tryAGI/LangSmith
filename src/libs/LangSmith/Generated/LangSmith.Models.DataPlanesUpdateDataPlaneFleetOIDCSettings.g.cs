
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesUpdateDataPlaneFleetOIDCSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_claim")]
        public string? EmailClaim { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups_claim")]
        public string? GroupsClaim { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        public string? IssuerUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_claim")]
        public string? SubjectClaim { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_claim")]
        public string? TenantClaim { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_mappings")]
        public global::System.Collections.Generic.Dictionary<string, string>? TenantMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesUpdateDataPlaneFleetOIDCSettings" /> class.
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
        public DataPlanesUpdateDataPlaneFleetOIDCSettings(
            string? audience,
            string? emailClaim,
            string? groupsClaim,
            bool? isEnabled,
            string? issuerUrl,
            string? provider,
            string? subjectClaim,
            string? tenantClaim,
            global::System.Collections.Generic.Dictionary<string, string>? tenantMappings)
        {
            this.Audience = audience;
            this.EmailClaim = emailClaim;
            this.GroupsClaim = groupsClaim;
            this.IsEnabled = isEnabled;
            this.IssuerUrl = issuerUrl;
            this.Provider = provider;
            this.SubjectClaim = subjectClaim;
            this.TenantClaim = tenantClaim;
            this.TenantMappings = tenantMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesUpdateDataPlaneFleetOIDCSettings" /> class.
        /// </summary>
        public DataPlanesUpdateDataPlaneFleetOIDCSettings()
        {
        }

    }
}