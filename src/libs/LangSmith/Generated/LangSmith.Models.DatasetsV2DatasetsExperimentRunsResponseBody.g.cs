
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetsV2DatasetsExperimentRunsResponseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetsV2ExampleWithRuns>? Items { get; set; }

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
        /// Initializes a new instance of the <see cref="DatasetsV2DatasetsExperimentRunsResponseBody" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetsV2DatasetsExperimentRunsResponseBody(
            global::System.Collections.Generic.IList<global::LangSmith.DatasetsV2ExampleWithRuns>? items,
            string? nextCursor)
        {
            this.Items = items;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsV2DatasetsExperimentRunsResponseBody" /> class.
        /// </summary>
        public DatasetsV2DatasetsExperimentRunsResponseBody()
        {
        }

    }
}