
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
    public static class AlertsAlertRuleAttributeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertsAlertRuleAttribute value)
        {
            return value switch
            {
                AlertsAlertRuleAttribute.ErrorCount => "error_count",
                AlertsAlertRuleAttribute.FeedbackScore => "feedback_score",
                AlertsAlertRuleAttribute.Latency => "latency",
                AlertsAlertRuleAttribute.RunCount => "run_count",
                AlertsAlertRuleAttribute.RunLatency => "run_latency",
                AlertsAlertRuleAttribute.TotalCost => "total_cost",
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
                "error_count" => AlertsAlertRuleAttribute.ErrorCount,
                "feedback_score" => AlertsAlertRuleAttribute.FeedbackScore,
                "latency" => AlertsAlertRuleAttribute.Latency,
                "run_count" => AlertsAlertRuleAttribute.RunCount,
                "run_latency" => AlertsAlertRuleAttribute.RunLatency,
                "total_cost" => AlertsAlertRuleAttribute.TotalCost,
                _ => null,
            };
        }
    }
}