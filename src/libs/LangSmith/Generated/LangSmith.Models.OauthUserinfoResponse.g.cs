
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OauthUserinfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_verified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_org_id")]
        public string? LsOrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_org_name")]
        public string? LsOrgName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture")]
        public string? Picture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub")]
        public string? Sub { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthUserinfoResponse" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="lsOrgId"></param>
        /// <param name="lsOrgName"></param>
        /// <param name="name"></param>
        /// <param name="picture"></param>
        /// <param name="sub"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OauthUserinfoResponse(
            string? email,
            bool? emailVerified,
            string? lsOrgId,
            string? lsOrgName,
            string? name,
            string? picture,
            string? sub)
        {
            this.Email = email;
            this.EmailVerified = emailVerified;
            this.LsOrgId = lsOrgId;
            this.LsOrgName = lsOrgName;
            this.Name = name;
            this.Picture = picture;
            this.Sub = sub;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthUserinfoResponse" /> class.
        /// </summary>
        public OauthUserinfoResponse()
        {
        }

    }
}