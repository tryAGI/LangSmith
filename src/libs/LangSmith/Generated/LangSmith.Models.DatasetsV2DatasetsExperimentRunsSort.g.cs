
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetsV2DatasetsExperimentRunsSort
    {
        /// <summary>
        /// `by` is the feedback selector, e.g. `feedback.correctness` (the `feedback.` prefix is optional).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by")]
        public string? By { get; set; }

        /// <summary>
        /// `order` is `ASC` or `DESC` (defaults to `DESC`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public string? Order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsV2DatasetsExperimentRunsSort" /> class.
        /// </summary>
        /// <param name="by">
        /// `by` is the feedback selector, e.g. `feedback.correctness` (the `feedback.` prefix is optional).
        /// </param>
        /// <param name="order">
        /// `order` is `ASC` or `DESC` (defaults to `DESC`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetsV2DatasetsExperimentRunsSort(
            string? by,
            string? order)
        {
            this.By = by;
            this.Order = order;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsV2DatasetsExperimentRunsSort" /> class.
        /// </summary>
        public DatasetsV2DatasetsExperimentRunsSort()
        {
        }

    }
}