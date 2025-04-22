
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Group by param for run stats.
    /// </summary>
    public sealed partial class RunStatsGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunStatsGroupByAttributeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RunStatsGroupByAttribute Attribute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatsGroupBy" /> class.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="path"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStatsGroupBy(
            global::LangSmith.RunStatsGroupByAttribute attribute,
            string? path)
        {
            this.Attribute = attribute;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatsGroupBy" /> class.
        /// </summary>
        public RunStatsGroupBy()
        {
        }
    }
}