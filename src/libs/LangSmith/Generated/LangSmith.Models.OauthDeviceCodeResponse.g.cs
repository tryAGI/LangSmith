
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OauthDeviceCodeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_code")]
        public string? DeviceCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_code")]
        public string? UserCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_uri")]
        public string? VerificationUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthDeviceCodeResponse" /> class.
        /// </summary>
        /// <param name="deviceCode"></param>
        /// <param name="expiresIn"></param>
        /// <param name="interval"></param>
        /// <param name="userCode"></param>
        /// <param name="verificationUri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OauthDeviceCodeResponse(
            string? deviceCode,
            int? expiresIn,
            int? interval,
            string? userCode,
            string? verificationUri)
        {
            this.DeviceCode = deviceCode;
            this.ExpiresIn = expiresIn;
            this.Interval = interval;
            this.UserCode = userCode;
            this.VerificationUri = verificationUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthDeviceCodeResponse" /> class.
        /// </summary>
        public OauthDeviceCodeResponse()
        {
        }

    }
}