
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// API key GET schema.
    /// </summary>
    public sealed partial class APIKeyGetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShortKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_names")]
        public global::System.Collections.Generic.IList<string>? WorkspaceNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyGetResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="shortKey"></param>
        /// <param name="description"></param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        /// <param name="lastUsedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="workspaceNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIKeyGetResponse(
            global::System.Guid id,
            string shortKey,
            string description,
            global::System.DateTime? createdAt,
            bool? readOnly,
            global::System.DateTime? lastUsedAt,
            global::System.DateTime? expiresAt,
            global::System.Collections.Generic.IList<string>? workspaceNames)
        {
            this.Id = id;
            this.ShortKey = shortKey ?? throw new global::System.ArgumentNullException(nameof(shortKey));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CreatedAt = createdAt;
            this.ReadOnly = readOnly;
            this.LastUsedAt = lastUsedAt;
            this.ExpiresAt = expiresAt;
            this.WorkspaceNames = workspaceNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyGetResponse" /> class.
        /// </summary>
        public APIKeyGetResponse()
        {
        }
    }
}