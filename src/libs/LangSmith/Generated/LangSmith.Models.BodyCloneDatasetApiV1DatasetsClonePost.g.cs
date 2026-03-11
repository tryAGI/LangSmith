
#pragma warning disable CS0618 // Type or member is obsolete

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
        public global::System.Guid TargetDatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid SourceDatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        public global::LangSmith.AnyOf<global::System.DateTime?, string>? AsOf { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Examples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>))]
        public global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Split { get; set; }

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
        /// <param name="asOf"></param>
        /// <param name="examples">
        /// Default Value: []
        /// </param>
        /// <param name="split"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCloneDatasetApiV1DatasetsClonePost(
            global::System.Guid targetDatasetId,
            global::System.Guid sourceDatasetId,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf,
            global::System.Collections.Generic.IList<global::System.Guid>? examples,
            global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? split)
        {
            this.TargetDatasetId = targetDatasetId;
            this.SourceDatasetId = sourceDatasetId;
            this.AsOf = asOf;
            this.Examples = examples;
            this.Split = split;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCloneDatasetApiV1DatasetsClonePost" /> class.
        /// </summary>
        public BodyCloneDatasetApiV1DatasetsClonePost()
        {
        }
    }
}