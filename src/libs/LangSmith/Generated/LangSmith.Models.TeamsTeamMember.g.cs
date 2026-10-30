
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamsTeamMember
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid IdentityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeamMember" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="identityId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsTeamMember(
            string createdAt,
            global::System.Guid identityId)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.IdentityId = identityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeamMember" /> class.
        /// </summary>
        public TeamsTeamMember()
        {
        }

    }
}