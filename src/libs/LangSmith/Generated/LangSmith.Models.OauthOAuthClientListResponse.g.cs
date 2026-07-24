
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OauthOAuthClientListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clients")]
        public global::System.Collections.Generic.IList<global::LangSmith.OauthOAuthClientView>? Clients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthOAuthClientListResponse" /> class.
        /// </summary>
        /// <param name="clients"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OauthOAuthClientListResponse(
            global::System.Collections.Generic.IList<global::LangSmith.OauthOAuthClientView>? clients)
        {
            this.Clients = clients;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthOAuthClientListResponse" /> class.
        /// </summary>
        public OauthOAuthClientListResponse()
        {
        }

    }
}