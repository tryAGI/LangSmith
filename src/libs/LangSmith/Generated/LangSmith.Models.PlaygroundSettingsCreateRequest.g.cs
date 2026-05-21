
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundSettingsCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::LangSmith.PlaygroundSavedOptions? Options { get; set; }

        /// <summary>
        /// Default Value: complex
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestSettingsTypeJsonConverter))]
        public global::LangSmith.PlaygroundSettingsCreateRequestSettingsType? SettingsType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_enabled")]
        public bool? OauthEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_token_url")]
        public string? OauthTokenUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_client_id")]
        public string? OauthClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_client_secret")]
        public string? OauthClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_token_endpoint_auth_method")]
        public global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2? OauthTokenEndpointAuthMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_params")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? OauthParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_headers")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? OauthHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsCreateRequest" /> class.
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="options"></param>
        /// <param name="settingsType">
        /// Default Value: complex
        /// </param>
        /// <param name="oauthEnabled"></param>
        /// <param name="oauthTokenUrl"></param>
        /// <param name="oauthClientId"></param>
        /// <param name="oauthClientSecret"></param>
        /// <param name="oauthTokenEndpointAuthMethod"></param>
        /// <param name="oauthParams"></param>
        /// <param name="oauthHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundSettingsCreateRequest(
            object settings,
            string? name,
            string? description,
            global::LangSmith.PlaygroundSavedOptions? options,
            global::LangSmith.PlaygroundSettingsCreateRequestSettingsType? settingsType,
            bool? oauthEnabled,
            string? oauthTokenUrl,
            string? oauthClientId,
            string? oauthClientSecret,
            global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2? oauthTokenEndpointAuthMethod,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? oauthParams,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? oauthHeaders)
        {
            this.Name = name;
            this.Description = description;
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.Options = options;
            this.SettingsType = settingsType;
            this.OauthEnabled = oauthEnabled;
            this.OauthTokenUrl = oauthTokenUrl;
            this.OauthClientId = oauthClientId;
            this.OauthClientSecret = oauthClientSecret;
            this.OauthTokenEndpointAuthMethod = oauthTokenEndpointAuthMethod;
            this.OauthParams = oauthParams;
            this.OauthHeaders = oauthHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsCreateRequest" /> class.
        /// </summary>
        public PlaygroundSettingsCreateRequest()
        {
        }

    }
}