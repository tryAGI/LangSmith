
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantShareDatasetToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.TenantShareDatasetTokenTypeJsonConverter))]
        public global::LangSmith.TenantShareDatasetTokenType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShareToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareDatasetToken" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="shareToken"></param>
        /// <param name="createdAt"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TenantShareDatasetToken(
            string shareToken,
            global::System.DateTime createdAt,
            global::System.Guid datasetId,
            global::LangSmith.TenantShareDatasetTokenType type,
            string? datasetName)
        {
            this.ShareToken = shareToken ?? throw new global::System.ArgumentNullException(nameof(shareToken));
            this.CreatedAt = createdAt;
            this.DatasetId = datasetId;
            this.Type = type;
            this.DatasetName = datasetName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareDatasetToken" /> class.
        /// </summary>
        public TenantShareDatasetToken()
        {
        }
    }
}