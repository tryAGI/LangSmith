
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
        Latency,
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
        RunLatency,
        /// <summary>
        /// 
        /// </summary>
        RunCount,
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
                AlertsAlertRuleBaseAttribute.Latency => "latency",
                AlertsAlertRuleBaseAttribute.ErrorCount => "error_count",
                AlertsAlertRuleBaseAttribute.FeedbackScore => "feedback_score",
                AlertsAlertRuleBaseAttribute.RunLatency => "run_latency",
                AlertsAlertRuleBaseAttribute.RunCount => "run_count",
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
                "latency" => AlertsAlertRuleBaseAttribute.Latency,
                "error_count" => AlertsAlertRuleBaseAttribute.ErrorCount,
                "feedback_score" => AlertsAlertRuleBaseAttribute.FeedbackScore,
                "run_latency" => AlertsAlertRuleBaseAttribute.RunLatency,
                "run_count" => AlertsAlertRuleBaseAttribute.RunCount,
                _ => null,
            };
        }
    }
}