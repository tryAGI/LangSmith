
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamsTeamAccessPolicy
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AttachedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.TeamsTeamAccessPolicyEffectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.TeamsTeamAccessPolicyEffect Effect { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// WorkspaceID is the workspace the policy applies in. It is omitted when the policy applies<br/>
        /// in every workspace an organization-wide team has access to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeamAccessPolicy" /> class.
        /// </summary>
        /// <param name="attachedAt"></param>
        /// <param name="description"></param>
        /// <param name="effect"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="workspaceId">
        /// WorkspaceID is the workspace the policy applies in. It is omitted when the policy applies<br/>
        /// in every workspace an organization-wide team has access to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsTeamAccessPolicy(
            string attachedAt,
            string description,
            global::LangSmith.TeamsTeamAccessPolicyEffect effect,
            global::System.Guid id,
            string name,
            global::System.Guid? workspaceId)
        {
            this.AttachedAt = attachedAt ?? throw new global::System.ArgumentNullException(nameof(attachedAt));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Effect = effect;
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeamAccessPolicy" /> class.
        /// </summary>
        public TeamsTeamAccessPolicy()
        {
        }

    }
}