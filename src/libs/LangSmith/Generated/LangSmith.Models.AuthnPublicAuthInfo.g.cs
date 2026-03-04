
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthnPublicAuthInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public string? LsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthnPublicAuthInfo" /> class.
        /// </summary>
        /// <param name="lsUserId"></param>
        /// <param name="organizationId"></param>
        /// <param name="tenantId"></param>
        /// <param name="userEmail"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthnPublicAuthInfo(
            string? lsUserId,
            string? organizationId,
            string? tenantId,
            string? userEmail,
            string? userId)
        {
            this.LsUserId = lsUserId;
            this.OrganizationId = organizationId;
            this.TenantId = tenantId;
            this.UserEmail = userEmail;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthnPublicAuthInfo" /> class.
        /// </summary>
        public AuthnPublicAuthInfo()
        {
        }
    }
}