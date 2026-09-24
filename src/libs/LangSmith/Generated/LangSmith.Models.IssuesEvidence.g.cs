
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesEvidence
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        public global::LangSmith.IssuesSeriesEvidence? Series { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.IssuesEvidenceTypeJsonConverter))]
        public global::LangSmith.IssuesEvidenceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesEvidence" /> class.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesEvidence(
            global::LangSmith.IssuesSeriesEvidence? series,
            global::LangSmith.IssuesEvidenceType type)
        {
            this.Series = series;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesEvidence" /> class.
        /// </summary>
        public IssuesEvidence()
        {
        }

    }
}