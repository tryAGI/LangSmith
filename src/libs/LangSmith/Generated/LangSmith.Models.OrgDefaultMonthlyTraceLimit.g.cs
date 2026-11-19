
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
        /// Alert thresholds copied into workspaces that inherit the default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_thresholds")]
        public global::System.Collections.Generic.IList<global::LangSmith.AlertThreshold>? AlertThresholds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgDefaultMonthlyTraceLimit" /> class.
        /// </summary>
        /// <param name="limitValue"></param>
        /// <param name="alertThresholds">
        /// Alert thresholds copied into workspaces that inherit the default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgDefaultMonthlyTraceLimit(
            int? limitValue,
            global::System.Collections.Generic.IList<global::LangSmith.AlertThreshold>? alertThresholds)
        {
            this.LimitValue = limitValue;
            this.AlertThresholds = alertThresholds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgDefaultMonthlyTraceLimit" /> class.
        /// </summary>
        public OrgDefaultMonthlyTraceLimit()
        {
        }

    }
}