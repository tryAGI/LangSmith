
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCloneDatasetApiV1DatasetsClonePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TargetDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SourceDatasetId { get; set; }

        /// <summary>
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        public object? AsOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCloneDatasetApiV1DatasetsClonePost" /> class.
        /// </summary>
        /// <param name="targetDatasetId"></param>
        /// <param name="sourceDatasetId"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.
        /// </param>
        /// <param name="examples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCloneDatasetApiV1DatasetsClonePost(
            global::System.Guid targetDatasetId,
            global::System.Guid sourceDatasetId,
            object? asOf,
            global::System.Collections.Generic.IList<global::System.Guid>? examples)
        {
            this.TargetDatasetId = targetDatasetId;
            this.SourceDatasetId = sourceDatasetId;
            this.AsOf = asOf;
            this.Examples = examples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCloneDatasetApiV1DatasetsClonePost" /> class.
        /// </summary>
        public BodyCloneDatasetApiV1DatasetsClonePost()
        {
        }
    }
}