
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Update class for Dataset.
    /// </summary>
    public sealed partial class DatasetUpdate
    {
        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? Name { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? Description { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_schema_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>? InputsSchemaDefinition { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_schema_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>? OutputsSchemaDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_examples")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? PatchExamples { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>? Transformations { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>? Metadata { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_experiment_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing, object>))]
        public global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing, object>? BaselineExperimentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUpdate" /> class.
        /// </summary>
        /// <param name="name">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="inputsSchemaDefinition">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="outputsSchemaDefinition">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="patchExamples"></param>
        /// <param name="transformations">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="metadata">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="baselineExperimentId">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetUpdate(
            global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? name,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? description,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>? inputsSchemaDefinition,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>? outputsSchemaDefinition,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? patchExamples,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>? transformations,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>? metadata,
            global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing, object>? baselineExperimentId)
        {
            this.Name = name;
            this.Description = description;
            this.InputsSchemaDefinition = inputsSchemaDefinition;
            this.OutputsSchemaDefinition = outputsSchemaDefinition;
            this.PatchExamples = patchExamples;
            this.Transformations = transformations;
            this.Metadata = metadata;
            this.BaselineExperimentId = baselineExperimentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUpdate" /> class.
        /// </summary>
        public DatasetUpdate()
        {
        }
    }
}