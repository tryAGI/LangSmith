
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A trace highlighted in an insights report summary. Up to 10 per insights job.
    /// </summary>
    public sealed partial class HighlightedRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_id")]
        public global::System.Guid? ClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster_name")]
        public string? ClusterName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlight_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HighlightReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HighlightedRun" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="clusterId"></param>
        /// <param name="clusterName"></param>
        /// <param name="rank"></param>
        /// <param name="highlightReason"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HighlightedRun(
            global::System.Guid runId,
            int rank,
            string highlightReason,
            global::System.Guid? clusterId,
            string? clusterName,
            string? summary)
        {
            this.RunId = runId;
            this.Rank = rank;
            this.HighlightReason = highlightReason ?? throw new global::System.ArgumentNullException(nameof(highlightReason));
            this.ClusterId = clusterId;
            this.ClusterName = clusterName;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HighlightedRun" /> class.
        /// </summary>
        public HighlightedRun()
        {
        }
    }
}