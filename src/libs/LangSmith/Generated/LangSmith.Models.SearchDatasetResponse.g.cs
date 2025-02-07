
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Dataset schema for serving.
    /// </summary>
    public sealed partial class SearchDatasetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.SearchedFewShotExample> Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDatasetResponse" /> class.
        /// </summary>
        /// <param name="examples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchDatasetResponse(
            global::System.Collections.Generic.IList<global::LangSmith.SearchedFewShotExample> examples)
        {
            this.Examples = examples ?? throw new global::System.ArgumentNullException(nameof(examples));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDatasetResponse" /> class.
        /// </summary>
        public SearchDatasetResponse()
        {
        }
    }
}