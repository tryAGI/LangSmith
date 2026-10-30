
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamsAddTeamMembersPayload
    {
        /// <summary>
        /// IdentityIDs are the organization identities of the users to add.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> IdentityIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddTeamMembersPayload" /> class.
        /// </summary>
        /// <param name="identityIds">
        /// IdentityIDs are the organization identities of the users to add.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsAddTeamMembersPayload(
            global::System.Collections.Generic.IList<global::System.Guid> identityIds)
        {
            this.IdentityIds = identityIds ?? throw new global::System.ArgumentNullException(nameof(identityIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddTeamMembersPayload" /> class.
        /// </summary>
        public TeamsAddTeamMembersPayload()
        {
        }

    }
}