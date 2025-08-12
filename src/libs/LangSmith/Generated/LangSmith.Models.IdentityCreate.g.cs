
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdentityCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_identity_id")]
        public global::System.Guid? OrgIdentityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public global::System.Guid? LsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

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
        /// Initializes a new instance of the <see cref="IdentityCreate" /> class.
        /// </summary>
        /// <param name="orgIdentityId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityCreate(
            global::System.Guid? orgIdentityId,
            global::System.Guid? lsUserId,
            bool? readOnly,
            global::System.Guid? roleId)
        {
            this.OrgIdentityId = orgIdentityId;
            this.LsUserId = lsUserId;
            this.ReadOnly = readOnly;
            this.RoleId = roleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityCreate" /> class.
        /// </summary>
        public IdentityCreate()
        {
        }
    }
}