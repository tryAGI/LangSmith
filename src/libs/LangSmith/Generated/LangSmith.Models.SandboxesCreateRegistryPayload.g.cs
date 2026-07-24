
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesCreateRegistryPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateRegistryPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="url"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreateRegistryPayload(
            string name,
            string password,
            string url,
            string username)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateRegistryPayload" /> class.
        /// </summary>
        public SandboxesCreateRegistryPayload()
        {
        }

    }
}