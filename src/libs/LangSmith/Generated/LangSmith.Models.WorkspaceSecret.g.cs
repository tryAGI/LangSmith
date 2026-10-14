
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A workspace secret's key and the hosts it may be sent to. Never the value.
    /// </summary>
    public sealed partial class WorkspaceSecret
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Hosts the secret may be sent to, with built-in defaults applied. Listed secrets include it only when include_configs is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        public global::System.Collections.Generic.IList<global::LangSmith.SecretConfig>? Configs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSecret" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="configs">
        /// Hosts the secret may be sent to, with built-in defaults applied. Listed secrets include it only when include_configs is true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceSecret(
            string key,
            global::System.Collections.Generic.IList<global::LangSmith.SecretConfig>? configs)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Configs = configs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSecret" /> class.
        /// </summary>
        public WorkspaceSecret()
        {
        }

    }
}