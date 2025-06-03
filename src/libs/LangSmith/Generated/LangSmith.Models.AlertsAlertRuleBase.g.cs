
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertsAlertRuleBase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseAggregationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertsAlertRuleBaseAggregation Aggregation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseAttributeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertsAlertRuleBaseAttribute Attribute { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertsAlertRuleBaseOperator Operator { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertsAlertRuleBaseType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="AlertsAlertRuleBase" /> class.
        /// </summary>
        /// <param name="aggregation"></param>
        /// <param name="attribute"></param>
        /// <param name="denominatorFilter"></param>
        /// <param name="description"></param>
        /// <param name="filter"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="operator"></param>
        /// <param name="threshold"></param>
        /// <param name="thresholdMultiplier"></param>
        /// <param name="thresholdWindowMinutes"></param>
        /// <param name="type"></param>
        /// <param name="windowMinutes">
        /// max 15 minutes for alert rule
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertsAlertRuleBase(
            global::LangSmith.AlertsAlertRuleBaseAggregation aggregation,
            global::LangSmith.AlertsAlertRuleBaseAttribute attribute,
            string description,
            string name,
            global::LangSmith.AlertsAlertRuleBaseOperator @operator,
            global::LangSmith.AlertsAlertRuleBaseType type,
            int windowMinutes,
            string? denominatorFilter,
            string? filter,
            string? id,
            double? threshold,
            double? thresholdMultiplier,
            int? thresholdWindowMinutes)
        {
            this.Aggregation = aggregation;
            this.Attribute = attribute;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Operator = @operator;
            this.Type = type;
            this.WindowMinutes = windowMinutes;
            this.DenominatorFilter = denominatorFilter;
            this.Filter = filter;
            this.Id = id;
            this.Threshold = threshold;
            this.ThresholdMultiplier = thresholdMultiplier;
            this.ThresholdWindowMinutes = thresholdWindowMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsAlertRuleBase" /> class.
        /// </summary>
        public AlertsAlertRuleBase()
        {
        }
    }
}