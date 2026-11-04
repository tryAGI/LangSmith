
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Model price map entries, in the order pricing matches them.
    /// </summary>
    public sealed partial class ModelPriceMapListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapSchema> Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapListResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPriceMapListResponse(
            global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapSchema> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapListResponse" /> class.
        /// </summary>
        public ModelPriceMapListResponse()
        {
        }

    }
}