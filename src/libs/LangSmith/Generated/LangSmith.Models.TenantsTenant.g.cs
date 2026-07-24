
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantsTenant
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_plane_url")]
        public string? DataPlaneUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        public bool? IsPersonal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_handle")]
        public string? TenantHandle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantsTenant" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="dataPlaneUrl"></param>
        /// <param name="id"></param>
        /// <param name="isPersonal"></param>
        /// <param name="name"></param>
        /// <param name="organizationId"></param>
        /// <param name="permissions"></param>
        /// <param name="tenantHandle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TenantsTenant(
            string? createdAt,
            string? dataPlaneUrl,
            string? id,
            bool? isPersonal,
            string? name,
            string? organizationId,
            global::System.Collections.Generic.IList<string>? permissions,
            string? tenantHandle)
        {
            this.CreatedAt = createdAt;
            this.DataPlaneUrl = dataPlaneUrl;
            this.Id = id;
            this.IsPersonal = isPersonal;
            this.Name = name;
            this.OrganizationId = organizationId;
            this.Permissions = permissions;
            this.TenantHandle = tenantHandle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantsTenant" /> class.
        /// </summary>
        public TenantsTenant()
        {
        }

    }
}