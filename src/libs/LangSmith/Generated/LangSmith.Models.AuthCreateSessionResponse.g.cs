
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthCreateSessionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AuthSessionStatusJsonConverter))]
        public global::LangSmith.AuthSessionStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_url")]
        public string? VerificationUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthCreateSessionResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="metadata"></param>
        /// <param name="providerId"></param>
        /// <param name="status"></param>
        /// <param name="token"></param>
        /// <param name="verificationUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthCreateSessionResponse(
            string? id,
            object? metadata,
            string? providerId,
            global::LangSmith.AuthSessionStatus? status,
            string? token,
            string? verificationUrl)
        {
            this.Id = id;
            this.Metadata = metadata;
            this.ProviderId = providerId;
            this.Status = status;
            this.Token = token;
            this.VerificationUrl = verificationUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthCreateSessionResponse" /> class.
        /// </summary>
        public AuthCreateSessionResponse()
        {
        }

    }
}