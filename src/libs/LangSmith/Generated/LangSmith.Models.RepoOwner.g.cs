
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A repo owner with user details.<br/>
    /// Note: identity_id and email may be None when returned to users<br/>
    /// outside the repo's tenant (PII protection).
    /// </summary>
    public sealed partial class RepoOwner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid? IdentityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid LsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoOwner" /> class.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="email"></param>
        /// <param name="fullName"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepoOwner(
            global::System.Guid? identityId,
            global::System.Guid lsUserId,
            string? email,
            string? fullName,
            global::System.DateTime createdAt)
        {
            this.IdentityId = identityId ?? throw new global::System.ArgumentNullException(nameof(identityId));
            this.LsUserId = lsUserId;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FullName = fullName ?? throw new global::System.ArgumentNullException(nameof(fullName));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoOwner" /> class.
        /// </summary>
        public RepoOwner()
        {
        }
    }
}