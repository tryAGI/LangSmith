
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InternalSecretsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalSecretsResponse" /> class.
        /// </summary>
        /// <param name="encryptedSecrets"></param>
        /// <param name="tenantId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalSecretsResponse(
            string encryptedSecrets,
            global::System.Guid? tenantId)
        {
            this.EncryptedSecrets = encryptedSecrets ?? throw new global::System.ArgumentNullException(nameof(encryptedSecrets));
            this.TenantId = tenantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalSecretsResponse" /> class.
        /// </summary>
        public InternalSecretsResponse()
        {
        }
    }
}