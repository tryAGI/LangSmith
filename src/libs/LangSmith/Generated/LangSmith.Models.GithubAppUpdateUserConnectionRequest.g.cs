
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GithubAppUpdateUserConnectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_preference")]
        public string? ActorPreference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubAppUpdateUserConnectionRequest" /> class.
        /// </summary>
        /// <param name="actorPreference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GithubAppUpdateUserConnectionRequest(
            string? actorPreference)
        {
            this.ActorPreference = actorPreference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubAppUpdateUserConnectionRequest" /> class.
        /// </summary>
        public GithubAppUpdateUserConnectionRequest()
        {
        }
    }
}