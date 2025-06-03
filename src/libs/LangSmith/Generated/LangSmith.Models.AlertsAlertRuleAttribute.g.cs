
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertsAlertRuleAttribute
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
    public static class AlertsAlertRuleAttributeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertsAlertRuleAttribute value)
        {
            return value switch
            {
                AlertsAlertRuleAttribute.Latency => "latency",
                AlertsAlertRuleAttribute.ErrorCount => "error_count",
                AlertsAlertRuleAttribute.FeedbackScore => "feedback_score",
                AlertsAlertRuleAttribute.RunLatency => "run_latency",
                AlertsAlertRuleAttribute.RunCount => "run_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertsAlertRuleAttribute? ToEnum(string value)
        {
            return value switch
            {
                "latency" => AlertsAlertRuleAttribute.Latency,
                "error_count" => AlertsAlertRuleAttribute.ErrorCount,
                "feedback_score" => AlertsAlertRuleAttribute.FeedbackScore,
                "run_latency" => AlertsAlertRuleAttribute.RunLatency,
                "run_count" => AlertsAlertRuleAttribute.RunCount,
                _ => null,
            };
        }
    }
}