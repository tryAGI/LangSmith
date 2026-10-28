
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// API key PATCH schema.<br/>
    /// role_id: New workspace-level role to apply to every workspace identity<br/>
    ///     attached to the key. Optional; omit to leave workspace roles unchanged.<br/>
    /// org_role_id: New org-level role to apply to the key's org identity.<br/>
    ///     Workspace-scoped keys accept only the built-in ORGANIZATION_VIEWER<br/>
    ///     or ORGANIZATION_RESTRICTED role.<br/>
    ///     Optional; omit to leave the organization role unchanged.
    /// </summary>
    public sealed partial class APIKeyUpdateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_role_id")]
        public global::System.Guid? OrgRoleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyUpdateRequest" /> class.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="orgRoleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIKeyUpdateRequest(
            global::System.Guid? roleId,
            global::System.Guid? orgRoleId)
        {
            this.RoleId = roleId;
            this.OrgRoleId = orgRoleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyUpdateRequest" /> class.
        /// </summary>
        public APIKeyUpdateRequest()
        {
        }

    }
}