
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertsAlertActionBase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_rule_id")]
        public string? AlertRuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AlertsAlertActionBaseTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertsAlertActionBaseTarget Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsAlertActionBase" /> class.
        /// </summary>
        /// <param name="alertRuleId"></param>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <param name="target"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertsAlertActionBase(
            object config,
            global::LangSmith.AlertsAlertActionBaseTarget target,
            string? alertRuleId,
            string? id)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Target = target;
            this.AlertRuleId = alertRuleId;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsAlertActionBase" /> class.
        /// </summary>
        public AlertsAlertActionBase()
        {
        }
    }
}