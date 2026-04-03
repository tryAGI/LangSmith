
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertsAlertRuleBaseAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        ErrorCount,
        /// <summary>
        /// 
        /// </summary>
        FeedbackScore,
        /// <summary>
        /// 
        /// </summary>
        Latency,
        /// <summary>
        /// 
        /// </summary>
        RunCount,
        /// <summary>
        /// 
        /// </summary>
        RunLatency,
        /// <summary>
        /// 
        /// </summary>
        TotalCost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertsAlertRuleBaseAttributeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertsAlertRuleBaseAttribute value)
        {
            return value switch
            {
                AlertsAlertRuleBaseAttribute.ErrorCount => "error_count",
                AlertsAlertRuleBaseAttribute.FeedbackScore => "feedback_score",
                AlertsAlertRuleBaseAttribute.Latency => "latency",
                AlertsAlertRuleBaseAttribute.RunCount => "run_count",
                AlertsAlertRuleBaseAttribute.RunLatency => "run_latency",
                AlertsAlertRuleBaseAttribute.TotalCost => "total_cost",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertsAlertRuleBaseAttribute? ToEnum(string value)
        {
            return value switch
            {
                "error_count" => AlertsAlertRuleBaseAttribute.ErrorCount,
                "feedback_score" => AlertsAlertRuleBaseAttribute.FeedbackScore,
                "latency" => AlertsAlertRuleBaseAttribute.Latency,
                "run_count" => AlertsAlertRuleBaseAttribute.RunCount,
                "run_latency" => AlertsAlertRuleBaseAttribute.RunLatency,
                "total_cost" => AlertsAlertRuleBaseAttribute.TotalCost,
                _ => null,
            };
        }
    }
}