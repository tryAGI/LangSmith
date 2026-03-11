
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertsUpdateAlertRuleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase> Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertsAlertRuleBase Rule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsUpdateAlertRuleRequest" /> class.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="rule"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertsUpdateAlertRuleRequest(
            global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase> actions,
            global::LangSmith.AlertsAlertRuleBase rule)
        {
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
            this.Rule = rule ?? throw new global::System.ArgumentNullException(nameof(rule));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsUpdateAlertRuleRequest" /> class.
        /// </summary>
        public AlertsUpdateAlertRuleRequest()
        {
        }
    }
}