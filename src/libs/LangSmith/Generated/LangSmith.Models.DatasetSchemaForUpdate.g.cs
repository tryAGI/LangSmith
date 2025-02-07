
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetSchemaForUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_schema_definition")]
        public object? InputsSchemaDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_schema_definition")]
        public object? OutputsSchemaDefinition { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externally_managed")]
        public bool? ExternallyManaged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformations")]
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>? Transformations { get; set; }

        /// <summary>
        /// Enum for dataset data types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DataTypeJsonConverter))]
        public global::LangSmith.DataType? DataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSchemaForUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="inputsSchemaDefinition"></param>
        /// <param name="outputsSchemaDefinition"></param>
        /// <param name="externallyManaged">
        /// Default Value: false
        /// </param>
        /// <param name="transformations"></param>
        /// <param name="dataType">
        /// Enum for dataset data types.
        /// </param>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetSchemaForUpdate(
            string name,
            global::System.Guid id,
            global::System.Guid tenantId,
            string? description,
            global::System.DateTime? createdAt,
            object? inputsSchemaDefinition,
            object? outputsSchemaDefinition,
            bool? externallyManaged,
            global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>? transformations,
            global::LangSmith.DataType? dataType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id;
            this.TenantId = tenantId;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.InputsSchemaDefinition = inputsSchemaDefinition;
            this.OutputsSchemaDefinition = outputsSchemaDefinition;
            this.ExternallyManaged = externallyManaged;
            this.Transformations = transformations;
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSchemaForUpdate" /> class.
        /// </summary>
        public DatasetSchemaForUpdate()
        {
        }
    }
}