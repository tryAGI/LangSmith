
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut
    {
        /// <summary>
        /// Split to add the examples to, or remove them from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SplitName { get; set; }

        /// <summary>
        /// IDs of the examples to change. IDs of examples in other datasets are ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> Examples { get; set; }

        /// <summary>
        /// Remove the examples from the split instead of adding them.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove")]
        public bool? Remove { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut" /> class.
        /// </summary>
        /// <param name="splitName">
        /// Split to add the examples to, or remove them from.
        /// </param>
        /// <param name="examples">
        /// IDs of the examples to change. IDs of examples in other datasets are ignored.
        /// </param>
        /// <param name="remove">
        /// Remove the examples from the split instead of adding them.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut(
            string splitName,
            global::System.Collections.Generic.IList<global::System.Guid> examples,
            bool? remove)
        {
            this.SplitName = splitName ?? throw new global::System.ArgumentNullException(nameof(splitName));
            this.Examples = examples ?? throw new global::System.ArgumentNullException(nameof(examples));
            this.Remove = remove;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut" /> class.
        /// </summary>
        public BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut()
        {
        }

    }
}