
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Dataset schema.
    /// </summary>
    public sealed partial class Dataset
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
        /// Default Value: kv
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_count")]
        public int? ExampleCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SessionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_session_start_time")]
        public global::System.DateTime? LastSessionStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_experiment_id")]
        public global::System.Guid? BaselineExperimentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="sessionCount"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="inputsSchemaDefinition"></param>
        /// <param name="outputsSchemaDefinition"></param>
        /// <param name="externallyManaged">
        /// Default Value: false
        /// </param>
        /// <param name="transformations"></param>
        /// <param name="dataType">
        /// Default Value: kv
        /// </param>
        /// <param name="exampleCount"></param>
        /// <param name="lastSessionStartTime"></param>
        /// <param name="metadata"></param>
        /// <param name="baselineExperimentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Dataset(
            string name,
            global::System.Guid id,
            global::System.Guid tenantId,
            int sessionCount,
            global::System.DateTime modifiedAt,
            string? description,
            global::System.DateTime? createdAt,
            object? inputsSchemaDefinition,
            object? outputsSchemaDefinition,
            bool? externallyManaged,
            global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>? transformations,
            global::LangSmith.DataType? dataType,
            int? exampleCount,
            global::System.DateTime? lastSessionStartTime,
            object? metadata,
            global::System.Guid? baselineExperimentId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.CreatedAt = createdAt;
            this.InputsSchemaDefinition = inputsSchemaDefinition;
            this.OutputsSchemaDefinition = outputsSchemaDefinition;
            this.ExternallyManaged = externallyManaged;
            this.Transformations = transformations;
            this.DataType = dataType;
            this.Id = id;
            this.TenantId = tenantId;
            this.ExampleCount = exampleCount;
            this.SessionCount = sessionCount;
            this.ModifiedAt = modifiedAt;
            this.LastSessionStartTime = lastSessionStartTime;
            this.Metadata = metadata;
            this.BaselineExperimentId = baselineExperimentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}