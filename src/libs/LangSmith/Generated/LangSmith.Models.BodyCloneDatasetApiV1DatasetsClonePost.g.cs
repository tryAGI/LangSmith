
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyCloneDatasetApiV1DatasetsClonePost
    {
        /// <summary>
        /// ID of the dataset in this workspace that receives the copied examples. Its current examples are kept.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TargetDatasetId { get; set; }

        /// <summary>
        /// ID of the dataset in this workspace to copy examples from. It is not modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SourceDatasetId { get; set; }

        /// <summary>
        /// Version of the source dataset to copy. A value that parses as an ISO 8601 date or timestamp copies the examples as they were at that time; latest copies the current examples; any other value is a version tag. Defaults to latest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        public global::LangSmith.AnyOf<global::System.DateTime?, string>? AsOf { get; set; }

        /// <summary>
        /// IDs of source examples to copy. Defaults to every example in the source version. When IDs are given and nothing is copied, because none match or either dataset is not found, the request fails with 404.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Examples { get; set; }

        /// <summary>
        /// Split name, or list of split names, assigned to every copied example in place of its source splits. Defaults to keeping the source splits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>>? Split { get; set; }

        /// <summary>
        /// List of resource tag value IDs to attach to the target dataset, up to 100. Requires the datasets:tag_on_create permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_value_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TagValueIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCloneDatasetApiV1DatasetsClonePost" /> class.
        /// </summary>
        /// <param name="targetDatasetId">
        /// ID of the dataset in this workspace that receives the copied examples. Its current examples are kept.
        /// </param>
        /// <param name="sourceDatasetId">
        /// ID of the dataset in this workspace to copy examples from. It is not modified.
        /// </param>
        /// <param name="asOf">
        /// Version of the source dataset to copy. A value that parses as an ISO 8601 date or timestamp copies the examples as they were at that time; latest copies the current examples; any other value is a version tag. Defaults to latest.
        /// </param>
        /// <param name="examples">
        /// IDs of source examples to copy. Defaults to every example in the source version. When IDs are given and nothing is copied, because none match or either dataset is not found, the request fails with 404.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="split">
        /// Split name, or list of split names, assigned to every copied example in place of its source splits. Defaults to keeping the source splits.
        /// </param>
        /// <param name="tagValueIds">
        /// List of resource tag value IDs to attach to the target dataset, up to 100. Requires the datasets:tag_on_create permission.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCloneDatasetApiV1DatasetsClonePost(
            global::System.Guid targetDatasetId,
            global::System.Guid sourceDatasetId,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf,
            global::System.Collections.Generic.IList<global::System.Guid>? examples,
            global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>>? split,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueIds)
        {
            this.TargetDatasetId = targetDatasetId;
            this.SourceDatasetId = sourceDatasetId;
            this.AsOf = asOf;
            this.Examples = examples;
            this.Split = split;
            this.TagValueIds = tagValueIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCloneDatasetApiV1DatasetsClonePost" /> class.
        /// </summary>
        public BodyCloneDatasetApiV1DatasetsClonePost()
        {
        }

    }
}