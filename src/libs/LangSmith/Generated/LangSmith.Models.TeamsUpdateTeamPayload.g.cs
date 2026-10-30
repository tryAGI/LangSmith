
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamsUpdateTeamPayload
    {
        /// <summary>
        /// Description is cleared by null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// IdpGroupName is cleared by null. Workspace scoped teams cannot have one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idp_group_name")]
        public string? IdpGroupName { get; set; }

        /// <summary>
        /// IdpSyncEnabled can be true only while the team has an IdpGroupName.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idp_sync_enabled")]
        public bool? IdpSyncEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUpdateTeamPayload" /> class.
        /// </summary>
        /// <param name="description">
        /// Description is cleared by null.
        /// </param>
        /// <param name="idpGroupName">
        /// IdpGroupName is cleared by null. Workspace scoped teams cannot have one.
        /// </param>
        /// <param name="idpSyncEnabled">
        /// IdpSyncEnabled can be true only while the team has an IdpGroupName.
        /// </param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsUpdateTeamPayload(
            string? description,
            string? idpGroupName,
            bool? idpSyncEnabled,
            string? name)
        {
            this.Description = description;
            this.IdpGroupName = idpGroupName;
            this.IdpSyncEnabled = idpSyncEnabled;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUpdateTeamPayload" /> class.
        /// </summary>
        public TeamsUpdateTeamPayload()
        {
        }

    }
}