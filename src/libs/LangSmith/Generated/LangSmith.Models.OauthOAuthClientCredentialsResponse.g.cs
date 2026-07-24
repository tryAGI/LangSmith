
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OauthOAuthClientCredentialsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client")]
        public global::LangSmith.OauthOAuthClientView? Client { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthOAuthClientCredentialsResponse" /> class.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="clientSecret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OauthOAuthClientCredentialsResponse(
            global::LangSmith.OauthOAuthClientView? client,
            string? clientSecret)
        {
            this.Client = client;
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthOAuthClientCredentialsResponse" /> class.
        /// </summary>
        public OauthOAuthClientCredentialsResponse()
        {
        }

    }
}