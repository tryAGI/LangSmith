
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartGroupByPlain
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Attribute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartGroupByPlain" /> class.
        /// </summary>
        /// <param name="attribute"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartGroupByPlain(
            string attribute)
        {
            this.Attribute = attribute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartGroupByPlain" /> class.
        /// </summary>
        public CustomChartGroupByPlain()
        {
        }

    }
}