
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertsAlertRuleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertAction>? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        public global::LangSmith.AlertsAlertRule? Rule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsAlertRuleResponse" /> class.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="rule"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertsAlertRuleResponse(
            global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertAction>? actions,
            global::LangSmith.AlertsAlertRule? rule)
        {
            this.Actions = actions;
            this.Rule = rule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsAlertRuleResponse" /> class.
        /// </summary>
        public AlertsAlertRuleResponse()
        {
        }
    }
}