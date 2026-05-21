
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOauthDeviceAuthorizeRequest
    {
        /// <summary>
        /// Organization ID; must match the authenticated org
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Default workspace ID; must belong to organization and be accessible to user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// User code displayed on the device
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOauthDeviceAuthorizeRequest" /> class.
        /// </summary>
        /// <param name="organizationId">
        /// Organization ID; must match the authenticated org
        /// </param>
        /// <param name="userCode">
        /// User code displayed on the device
        /// </param>
        /// <param name="workspaceId">
        /// Default workspace ID; must belong to organization and be accessible to user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOauthDeviceAuthorizeRequest(
            string organizationId,
            string userCode,
            string? workspaceId)
        {
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.WorkspaceId = workspaceId;
            this.UserCode = userCode ?? throw new global::System.ArgumentNullException(nameof(userCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOauthDeviceAuthorizeRequest" /> class.
        /// </summary>
        public CreateOauthDeviceAuthorizeRequest()
        {
        }

    }
}