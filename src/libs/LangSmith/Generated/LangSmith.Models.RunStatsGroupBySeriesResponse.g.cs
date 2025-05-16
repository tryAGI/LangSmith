
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Include additional information about where the group_by param was set.
    /// </summary>
    public sealed partial class RunStatsGroupBySeriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseAttributeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RunStatsGroupBySeriesResponseAttribute Attribute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_groups")]
        public int? MaxGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseSetByJsonConverter))]
        public global::LangSmith.RunStatsGroupBySeriesResponseSetBy? SetBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatsGroupBySeriesResponse" /> class.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="path"></param>
        /// <param name="maxGroups">
        /// Default Value: 5
        /// </param>
        /// <param name="setBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStatsGroupBySeriesResponse(
            global::LangSmith.RunStatsGroupBySeriesResponseAttribute attribute,
            string? path,
            int? maxGroups,
            global::LangSmith.RunStatsGroupBySeriesResponseSetBy? setBy)
        {
            this.Attribute = attribute;
            this.Path = path;
            this.MaxGroups = maxGroups;
            this.SetBy = setBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatsGroupBySeriesResponse" /> class.
        /// </summary>
        public RunStatsGroupBySeriesResponse()
        {
        }
    }
}