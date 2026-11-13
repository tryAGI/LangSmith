
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgDefaultMonthlyTraceLimit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_value")]
        public int? LimitValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgDefaultMonthlyTraceLimit" /> class.
        /// </summary>
        /// <param name="limitValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgDefaultMonthlyTraceLimit(
            int? limitValue)
        {
            this.LimitValue = limitValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgDefaultMonthlyTraceLimit" /> class.
        /// </summary>
        public OrgDefaultMonthlyTraceLimit()
        {
        }

    }
}