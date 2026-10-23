
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Update class for Dataset.
    /// </summary>
    public sealed partial class DatasetUpdate
    {
        /// <summary>
        /// New dataset name. Must be unique in the workspace; a name already used by another dataset returns 409. Null returns 400. Omit to keep the current name.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Name { get; set; }

        /// <summary>
        /// New dataset description. Null clears it. Omit to keep the current description.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Description { get; set; }

        /// <summary>
        /// JSON Schema that example inputs must match. Replaces the current inputs schema as a whole; null removes it, which returns 400 while transformations still point into inputs. Only key-value datasets support schemas. Every existing example must match the new schema, otherwise the request returns 400 with the IDs of the examples that do not, and nothing is changed. Omit to keep the current schema.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_schema_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? InputsSchemaDefinition { get; set; }

        /// <summary>
        /// JSON Schema that example outputs must match. Replaces the current outputs schema as a whole; null removes it, which returns 400 while transformations still point into outputs. Only key-value datasets support schemas. Every existing example must match the new schema, otherwise the request returns 400 with the IDs of the examples that do not, and nothing is changed. Omit to keep the current schema.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_schema_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? OutputsSchemaDefinition { get; set; }

        /// <summary>
        /// Example updates keyed by example ID, applied in the same transaction so existing examples can be fixed to match a new schema. Only used when the request also sets inputs_schema_definition, outputs_schema_definition, or transformations and the dataset ends up with at least one schema; otherwise it is ignored. Each update replaces the inputs, outputs, metadata, or split it sets and keeps the rest; attachment operations are ignored. An ID that is not an example in this dataset returns 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_examples")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? PatchExamples { get; set; }

        /// <summary>
        /// Transformations applied to new examples, each a path into inputs or outputs and a transformation type. Replaces the whole current list; null or an empty list removes all of them. Existing examples are not transformed. Requires a schema on the inputs or outputs the path points into, otherwise returns 400. Omit to keep the current list.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>? Transformations { get; set; }

        /// <summary>
        /// Dataset metadata as a JSON object. Replaces the current metadata as a whole; keys are not merged. Send an empty object to clear it. Omit to keep the current metadata.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? Metadata { get; set; }

        /// <summary>
        /// ID of the experiment used as the baseline when comparing experiments on this dataset. Must be an experiment run on this dataset, otherwise returns 400. Null clears it. Omit to keep the current baseline.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_experiment_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? BaselineExperimentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUpdate" /> class.
        /// </summary>
        /// <param name="name">
        /// New dataset name. Must be unique in the workspace; a name already used by another dataset returns 409. Null returns 400. Omit to keep the current name.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// New dataset description. Null clears it. Omit to keep the current description.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="inputsSchemaDefinition">
        /// JSON Schema that example inputs must match. Replaces the current inputs schema as a whole; null removes it, which returns 400 while transformations still point into inputs. Only key-value datasets support schemas. Every existing example must match the new schema, otherwise the request returns 400 with the IDs of the examples that do not, and nothing is changed. Omit to keep the current schema.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="outputsSchemaDefinition">
        /// JSON Schema that example outputs must match. Replaces the current outputs schema as a whole; null removes it, which returns 400 while transformations still point into outputs. Only key-value datasets support schemas. Every existing example must match the new schema, otherwise the request returns 400 with the IDs of the examples that do not, and nothing is changed. Omit to keep the current schema.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="patchExamples">
        /// Example updates keyed by example ID, applied in the same transaction so existing examples can be fixed to match a new schema. Only used when the request also sets inputs_schema_definition, outputs_schema_definition, or transformations and the dataset ends up with at least one schema; otherwise it is ignored. Each update replaces the inputs, outputs, metadata, or split it sets and keeps the rest; attachment operations are ignored. An ID that is not an example in this dataset returns 404.
        /// </param>
        /// <param name="transformations">
        /// Transformations applied to new examples, each a path into inputs or outputs and a transformation type. Replaces the whole current list; null or an empty list removes all of them. Existing examples are not transformed. Requires a schema on the inputs or outputs the path points into, otherwise returns 400. Omit to keep the current list.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="metadata">
        /// Dataset metadata as a JSON object. Replaces the current metadata as a whole; keys are not merged. Send an empty object to clear it. Omit to keep the current metadata.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="baselineExperimentId">
        /// ID of the experiment used as the baseline when comparing experiments on this dataset. Must be an experiment run on this dataset, otherwise returns 400. Null clears it. Omit to keep the current baseline.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetUpdate(
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? name,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? description,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing>? inputsSchemaDefinition,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing>? outputsSchemaDefinition,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? patchExamples,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>? transformations,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing>? metadata,
            global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? baselineExperimentId)
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