
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertsAlertRuleAggregation
    {
        /// <summary>
        /// 
        /// </summary>
        Avg,
        /// <summary>
        /// 
        /// </summary>
        Pct,
        /// <summary>
        /// 
        /// </summary>
        Sum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertsAlertRuleAggregationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertsAlertRuleAggregation value)
        {
            return value switch
            {
                AlertsAlertRuleAggregation.Avg => "avg",
                AlertsAlertRuleAggregation.Pct => "pct",
                AlertsAlertRuleAggregation.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertsAlertRuleAggregation? ToEnum(string value)
        {
            return value switch
            {
                "avg" => AlertsAlertRuleAggregation.Avg,
                "pct" => AlertsAlertRuleAggregation.Pct,
                "sum" => AlertsAlertRuleAggregation.Sum,
                _ => null,
            };
        }
    }
}