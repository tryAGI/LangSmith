
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertsAlertRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AlertsAlertRuleAggregationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertsAlertRuleAggregation Aggregation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AlertsAlertRuleAttributeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertsAlertRuleAttribute Attribute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denominator_filter")]
        public string? DenominatorFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AlertsAlertRuleOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertsAlertRuleOperator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_multiplier")]
        public double? ThresholdMultiplier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_window_minutes")]
        public int? ThresholdWindowMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AlertsAlertRuleTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertsAlertRuleType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// max 15 minutes for alert rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsAlertRule" /> class.
        /// </summary>
        /// <param name="aggregation"></param>
        /// <param name="attribute"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="operator"></param>
        /// <param name="type"></param>
        /// <param name="windowMinutes">
        /// max 15 minutes for alert rule
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="denominatorFilter"></param>
        /// <param name="filter"></param>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="threshold"></param>
        /// <param name="thresholdMultiplier"></param>
        /// <param name="thresholdWindowMinutes"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertsAlertRule(
            global::LangSmith.AlertsAlertRuleAggregation aggregation,
            global::LangSmith.AlertsAlertRuleAttribute attribute,
            string description,
            string name,
            global::LangSmith.AlertsAlertRuleOperator @operator,
            global::LangSmith.AlertsAlertRuleType type,
            int windowMinutes,
            string? createdAt,
            string? denominatorFilter,
            string? filter,
            string? id,
            string? sessionId,
            string? sessionName,
            double? threshold,
            double? thresholdMultiplier,
            int? thresholdWindowMinutes,
            string? updatedAt)
        {
            this.Aggregation = aggregation;
            this.Attribute = attribute;
            this.CreatedAt = createdAt;
            this.DenominatorFilter = denominatorFilter;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Filter = filter;
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Operator = @operator;
            this.SessionId = sessionId;
            this.SessionName = sessionName;
            this.Threshold = threshold;
            this.ThresholdMultiplier = thresholdMultiplier;
            this.ThresholdWindowMinutes = thresholdWindowMinutes;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.WindowMinutes = windowMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsAlertRule" /> class.
        /// </summary>
        public AlertsAlertRule()
        {
        }
    }
}