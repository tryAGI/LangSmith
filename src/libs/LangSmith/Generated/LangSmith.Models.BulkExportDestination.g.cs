
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportDestination
    {
        /// <summary>
        /// Default Value: s3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.BulkExportDestinationTypeJsonConverter))]
        public global::LangSmith.BulkExportDestinationType? DestinationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.BulkExportDestinationS3Config Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<string> CredentialsKeys { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestination" /> class.
        /// </summary>
        /// <param name="destinationType">
        /// Default Value: s3
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="credentialsKeys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkExportDestination(
            string displayName,
            global::LangSmith.BulkExportDestinationS3Config config,
            global::System.Guid id,
            global::System.Guid tenantId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<string> credentialsKeys,
            global::LangSmith.BulkExportDestinationType? destinationType)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Id = id;
            this.TenantId = tenantId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CredentialsKeys = credentialsKeys ?? throw new global::System.ArgumentNullException(nameof(credentialsKeys));
            this.DestinationType = destinationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestination" /> class.
        /// </summary>
        public BulkExportDestination()
        {
        }
    }
}