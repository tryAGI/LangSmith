
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkillsSkillOwner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_id")]
        public string? IdentityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public string? LsUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillsSkillOwner" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="email"></param>
        /// <param name="fullName"></param>
        /// <param name="identityId"></param>
        /// <param name="lsUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillsSkillOwner(
            string? createdAt,
            string? email,
            string? fullName,
            string? identityId,
            string? lsUserId)
        {
            this.CreatedAt = createdAt;
            this.Email = email;
            this.FullName = fullName;
            this.IdentityId = identityId;
            this.LsUserId = lsUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillsSkillOwner" /> class.
        /// </summary>
        public SkillsSkillOwner()
        {
        }

    }
}