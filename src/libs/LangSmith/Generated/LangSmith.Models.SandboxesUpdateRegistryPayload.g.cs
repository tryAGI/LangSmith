
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesUpdateRegistryPayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesUpdateRegistryPayloadAuthTypeJsonConverter))]
        public global::LangSmith.SandboxesUpdateRegistryPayloadAuthType? AuthType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_role_arn")]
        public string? AwsRoleArn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

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
        /// Initializes a new instance of the <see cref="SandboxesUpdateRegistryPayload" /> class.
        /// </summary>
        /// <param name="authType"></param>
        /// <param name="awsRoleArn"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="url"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesUpdateRegistryPayload(
            global::LangSmith.SandboxesUpdateRegistryPayloadAuthType? authType,
            string? awsRoleArn,
            string? name,
            string? password,
            string? url,
            string? username)
        {
            this.AuthType = authType;
            this.AwsRoleArn = awsRoleArn;
            this.Name = name;
            this.Password = password;
            this.Url = url;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUpdateRegistryPayload" /> class.
        /// </summary>
        public SandboxesUpdateRegistryPayload()
        {
        }

    }
}