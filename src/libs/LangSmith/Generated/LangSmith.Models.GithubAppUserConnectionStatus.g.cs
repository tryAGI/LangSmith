
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GithubAppUserConnectionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_preference")]
        public string? ActorPreference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_connected")]
        public bool? IsConnected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::LangSmith.GithubAppUserConnectionMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubAppUserConnectionStatus" /> class.
        /// </summary>
        /// <param name="actorPreference"></param>
        /// <param name="isConnected"></param>
        /// <param name="metadata"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GithubAppUserConnectionStatus(
            string? actorPreference,
            bool? isConnected,
            global::LangSmith.GithubAppUserConnectionMetadata? metadata,
            string? type)
        {
            this.ActorPreference = actorPreference;
            this.IsConnected = isConnected;
            this.Metadata = metadata;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubAppUserConnectionStatus" /> class.
        /// </summary>
        public GithubAppUserConnectionStatus()
        {
        }
    }
}