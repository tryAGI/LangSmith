
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// High level summary of an insights job that pulls out patterns and specific traces.
    /// </summary>
    public sealed partial class InsightsSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_points")]
        public global::System.Collections.Generic.IList<string>? KeyPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlighted_traces")]
        public global::System.Collections.Generic.IList<global::LangSmith.HighlightedRun>? HighlightedTraces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsSummary" /> class.
        /// </summary>
        /// <param name="keyPoints"></param>
        /// <param name="title"></param>
        /// <param name="highlightedTraces"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsightsSummary(
            global::System.Collections.Generic.IList<string>? keyPoints,
            string? title,
            global::System.Collections.Generic.IList<global::LangSmith.HighlightedRun>? highlightedTraces,
            global::System.DateTime? createdAt)
        {
            this.KeyPoints = keyPoints;
            this.Title = title;
            this.HighlightedTraces = highlightedTraces;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsSummary" /> class.
        /// </summary>
        public InsightsSummary()
        {
        }
    }
}