
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateOrgDefaultMonthlyTraceLimit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LimitValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_to")]
        public global::LangSmith.OrgDefaultApplyTo? ApplyTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrgDefaultMonthlyTraceLimit" /> class.
        /// </summary>
        /// <param name="limitValue"></param>
        /// <param name="applyTo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrgDefaultMonthlyTraceLimit(
            int limitValue,
            global::LangSmith.OrgDefaultApplyTo? applyTo)
        {
            this.LimitValue = limitValue;
            this.ApplyTo = applyTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrgDefaultMonthlyTraceLimit" /> class.
        /// </summary>
        public UpdateOrgDefaultMonthlyTraceLimit()
        {
        }

    }
}