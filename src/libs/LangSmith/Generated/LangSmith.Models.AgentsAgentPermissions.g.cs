
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsAgentPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentsAgentPermissionsIdentityJsonConverter))]
        public global::LangSmith.AgentsAgentPermissionsIdentity? Identity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_users")]
        public global::LangSmith.AgentsSharedUsers? SharedUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentsAgentPermissionsTenantAccessLevelJsonConverter))]
        public global::LangSmith.AgentsAgentPermissionsTenantAccessLevel? TenantAccessLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentsAgentPermissionsVisibilityJsonConverter))]
        public global::LangSmith.AgentsAgentPermissionsVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsAgentPermissions" /> class.
        /// </summary>
        /// <param name="identity"></param>
        /// <param name="sharedUsers"></param>
        /// <param name="tenantAccessLevel"></param>
        /// <param name="visibility"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsAgentPermissions(
            global::LangSmith.AgentsAgentPermissionsIdentity? identity,
            global::LangSmith.AgentsSharedUsers? sharedUsers,
            global::LangSmith.AgentsAgentPermissionsTenantAccessLevel? tenantAccessLevel,
            global::LangSmith.AgentsAgentPermissionsVisibility? visibility)
        {
            this.Identity = identity;
            this.SharedUsers = sharedUsers;
            this.TenantAccessLevel = tenantAccessLevel;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsAgentPermissions" /> class.
        /// </summary>
        public AgentsAgentPermissions()
        {
        }

    }
}