
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartFilterByDataset
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"dataset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public string SourceType { get; set; } = "dataset";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> DatasetIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFilterByDataset" /> class.
        /// </summary>
        /// <param name="datasetIds"></param>
        /// <param name="sourceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartFilterByDataset(
            global::System.Collections.Generic.IList<global::System.Guid> datasetIds,
            string sourceType = "dataset")
        {
            this.SourceType = sourceType;
            this.DatasetIds = datasetIds ?? throw new global::System.ArgumentNullException(nameof(datasetIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFilterByDataset" /> class.
        /// </summary>
        public CustomChartFilterByDataset()
        {
        }

    }
}