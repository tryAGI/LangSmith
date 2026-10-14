
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SSOProviderSlim
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationDisplayName { get; set; }

        /// <summary>
        /// Default Value: saml
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SSOProviderTypeJsonConverter))]
        public global::LangSmith.SSOProviderType? ProviderType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOProviderSlim" /> class.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="organizationId"></param>
        /// <param name="organizationDisplayName"></param>
        /// <param name="providerType">
        /// Default Value: saml
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSOProviderSlim(
            global::System.Guid providerId,
            global::System.Guid organizationId,
            string organizationDisplayName,
            global::LangSmith.SSOProviderType? providerType)
        {
            this.ProviderId = providerId;
            this.OrganizationId = organizationId;
            this.OrganizationDisplayName = organizationDisplayName ?? throw new global::System.ArgumentNullException(nameof(organizationDisplayName));
            this.ProviderType = providerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOProviderSlim" /> class.
        /// </summary>
        public SSOProviderSlim()
        {
        }

    }
}