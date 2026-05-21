
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bindings")]
        public global::System.Collections.Generic.IList<global::LangSmith.CredentialsBindingPayload>? Bindings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope_slug")]
        public string? ScopeSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsResponse" /> class.
        /// </summary>
        /// <param name="authType"></param>
        /// <param name="bindings"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="displayName"></param>
        /// <param name="id"></param>
        /// <param name="scopeSlug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialsResponse(
            string? authType,
            global::System.Collections.Generic.IList<global::LangSmith.CredentialsBindingPayload>? bindings,
            string? createdAt,
            string? description,
            string? displayName,
            string? id,
            string? scopeSlug)
        {
            this.AuthType = authType;
            this.Bindings = bindings;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.DisplayName = displayName;
            this.Id = id;
            this.ScopeSlug = scopeSlug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsResponse" /> class.
        /// </summary>
        public CredentialsResponse()
        {
        }

    }
}