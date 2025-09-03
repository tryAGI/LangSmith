
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Update class for Dataset.
    /// </summary>
    public sealed partial class DatasetUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_schema_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? InputsSchemaDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_schema_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? OutputsSchemaDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_examples")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? PatchExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>? Transformations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="inputsSchemaDefinition"></param>
        /// <param name="outputsSchemaDefinition"></param>
        /// <param name="patchExamples"></param>
        /// <param name="transformations"></param>
        /// <param name="metadata"></param>
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
            global::LangSmith.AnyOf<object, global::LangSmith.Missing>? metadata)
        {
            this.Name = name;
            this.Description = description;
            this.InputsSchemaDefinition = inputsSchemaDefinition;
            this.OutputsSchemaDefinition = outputsSchemaDefinition;
            this.PatchExamples = patchExamples;
            this.Transformations = transformations;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUpdate" /> class.
        /// </summary>
        public DatasetUpdate()
        {
        }
    }
}