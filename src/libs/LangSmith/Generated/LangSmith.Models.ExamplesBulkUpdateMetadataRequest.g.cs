
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExamplesBulkUpdateMetadataRequest
    {
        /// <summary>
        /// The IDs of the examples to change; at most 10000. IDs of examples that are not in<br/>
        /// the dataset, or were deleted, are skipped and reported as NOT_FOUND.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExampleIds { get; set; }

        /// <summary>
        /// The metadata changes to apply, in order; at most 50, of which at most 10 are<br/>
        /// array operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.ExamplesMetadataOperation> Operations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesBulkUpdateMetadataRequest" /> class.
        /// </summary>
        /// <param name="exampleIds">
        /// The IDs of the examples to change; at most 10000. IDs of examples that are not in<br/>
        /// the dataset, or were deleted, are skipped and reported as NOT_FOUND.
        /// </param>
        /// <param name="operations">
        /// The metadata changes to apply, in order; at most 50, of which at most 10 are<br/>
        /// array operations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExamplesBulkUpdateMetadataRequest(
            global::System.Collections.Generic.IList<global::System.Guid> exampleIds,
            global::System.Collections.Generic.IList<global::LangSmith.ExamplesMetadataOperation> operations)
        {
            this.ExampleIds = exampleIds ?? throw new global::System.ArgumentNullException(nameof(exampleIds));
            this.Operations = operations ?? throw new global::System.ArgumentNullException(nameof(operations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesBulkUpdateMetadataRequest" /> class.
        /// </summary>
        public ExamplesBulkUpdateMetadataRequest()
        {
        }

    }
}