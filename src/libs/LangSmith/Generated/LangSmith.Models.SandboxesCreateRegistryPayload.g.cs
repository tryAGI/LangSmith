
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
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesCreateRegistryPayloadAuthTypeJsonConverter))]
        public global::LangSmith.SandboxesCreateRegistryPayloadAuthType? AuthType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_role_arn")]
        public string? AwsRoleArn { get; set; }

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
        public string? Password { get; set; }

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
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateRegistryPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="authType"></param>
        /// <param name="awsRoleArn"></param>
        /// <param name="password"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreateRegistryPayload(
            string name,
            string url,
            global::LangSmith.SandboxesCreateRegistryPayloadAuthType? authType,
            string? awsRoleArn,
            string? password,
            string? username)
        {
            this.AuthType = authType;
            this.AwsRoleArn = awsRoleArn;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Password = password;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateRegistryPayload" /> class.
        /// </summary>
        public SandboxesCreateRegistryPayload()
        {
        }

    }
}