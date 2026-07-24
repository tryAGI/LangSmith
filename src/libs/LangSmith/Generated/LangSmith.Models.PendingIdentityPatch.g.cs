
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingIdentityPatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingIdentityPatch" /> class.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="roleName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PendingIdentityPatch(
            global::System.Guid? roleId,
            string? roleName)
        {
            this.RoleId = roleId;
            this.RoleName = roleName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingIdentityPatch" /> class.
        /// </summary>
        public PendingIdentityPatch()
        {
        }

    }
}