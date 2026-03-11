
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceAccountWorkspaceAssignment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAccountWorkspaceAssignment" /> class.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="roleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceAccountWorkspaceAssignment(
            global::System.Guid workspaceId,
            global::System.Guid? roleId)
        {
            this.WorkspaceId = workspaceId;
            this.RoleId = roleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAccountWorkspaceAssignment" /> class.
        /// </summary>
        public ServiceAccountWorkspaceAssignment()
        {
        }
    }
}