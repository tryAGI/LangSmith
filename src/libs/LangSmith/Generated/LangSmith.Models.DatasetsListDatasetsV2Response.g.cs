
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetsListDatasetsV2Response
    {
        /// <summary>
        /// Datasets on this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.Dataset> Items { get; set; }

        /// <summary>
        /// Cursor for the next page. Null when this is the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsListDatasetsV2Response" /> class.
        /// </summary>
        /// <param name="items">
        /// Datasets on this page.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page. Null when this is the last page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetsListDatasetsV2Response(
            global::System.Collections.Generic.IList<global::LangSmith.Dataset> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsListDatasetsV2Response" /> class.
        /// </summary>
        public DatasetsListDatasetsV2Response()
        {
        }

    }
}