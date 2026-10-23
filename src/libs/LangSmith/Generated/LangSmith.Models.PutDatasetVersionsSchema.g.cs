
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutDatasetVersionsSchema
    {
        /// <summary>
        /// The version to tag: an ISO 8601 timestamp, or the name of an existing tag on this dataset (latest resolves to the most recent example change, and returns 404 for a dataset with no examples). A value that does not parse as a timestamp is treated as a tag name, and an unknown tag name returns 404. Timestamps are not checked against the dataset history: the tag covers every example change made on or before that time, so a future time keeps picking up new changes until it passes. Use the exact as_of of an existing version, since looking up a version by tag returns 404 when the tag's time does not match a version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<global::System.DateTime?, string> AsOf { get; set; }

        /// <summary>
        /// The tag to set. If the dataset already has this tag, it is moved to the new version. The tag latest is reserved and returns 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDatasetVersionsSchema" /> class.
        /// </summary>
        /// <param name="asOf">
        /// The version to tag: an ISO 8601 timestamp, or the name of an existing tag on this dataset (latest resolves to the most recent example change, and returns 404 for a dataset with no examples). A value that does not parse as a timestamp is treated as a tag name, and an unknown tag name returns 404. Timestamps are not checked against the dataset history: the tag covers every example change made on or before that time, so a future time keeps picking up new changes until it passes. Use the exact as_of of an existing version, since looking up a version by tag returns 404 when the tag's time does not match a version.
        /// </param>
        /// <param name="tag">
        /// The tag to set. If the dataset already has this tag, it is moved to the new version. The tag latest is reserved and returns 400.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutDatasetVersionsSchema(
            global::LangSmith.AnyOf<global::System.DateTime?, string> asOf,
            string tag)
        {
            this.AsOf = asOf;
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDatasetVersionsSchema" /> class.
        /// </summary>
        public PutDatasetVersionsSchema()
        {
        }

    }
}