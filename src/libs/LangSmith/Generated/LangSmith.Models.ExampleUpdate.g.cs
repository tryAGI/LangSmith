
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Update class for Example.
    /// </summary>
    public sealed partial class ExampleUpdate
    {
        /// <summary>
        /// The example's current dataset. An example can't move to another dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// New inputs. Replaces the existing inputs; omit to keep them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// New outputs. Replaces the existing outputs; omit to keep them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// Attachments to rename or keep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments_operations")]
        public global::LangSmith.AttachmentsOperations? AttachmentsOperations { get; set; }

        /// <summary>
        /// New metadata. Replaces the existing metadata; omit to keep it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Split or splits to put the example in. Replaces its current splits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string>? Split { get; set; }

        /// <summary>
        /// Not used.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleUpdate" /> class.
        /// </summary>
        /// <param name="datasetId">
        /// The example's current dataset. An example can't move to another dataset.
        /// </param>
        /// <param name="inputs">
        /// New inputs. Replaces the existing inputs; omit to keep them.
        /// </param>
        /// <param name="outputs">
        /// New outputs. Replaces the existing outputs; omit to keep them.
        /// </param>
        /// <param name="attachmentsOperations">
        /// Attachments to rename or keep.
        /// </param>
        /// <param name="metadata">
        /// New metadata. Replaces the existing metadata; omit to keep it.
        /// </param>
        /// <param name="split">
        /// Split or splits to put the example in. Replaces its current splits.
        /// </param>
        /// <param name="overwrite">
        /// Not used.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExampleUpdate(
            global::System.Guid? datasetId,
            object? inputs,
            object? outputs,
            global::LangSmith.AttachmentsOperations? attachmentsOperations,
            object? metadata,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string>? split,
            bool? overwrite)
        {
            this.DatasetId = datasetId;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.AttachmentsOperations = attachmentsOperations;
            this.Metadata = metadata;
            this.Split = split;
            this.Overwrite = overwrite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleUpdate" /> class.
        /// </summary>
        public ExampleUpdate()
        {
        }

    }
}