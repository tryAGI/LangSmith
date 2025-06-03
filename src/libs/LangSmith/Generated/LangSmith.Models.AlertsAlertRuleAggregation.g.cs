
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
        Sum,
        /// <summary>
        /// 
        /// </summary>
        Pct,
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
                AlertsAlertRuleAggregation.Sum => "sum",
                AlertsAlertRuleAggregation.Pct => "pct",
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
                "sum" => AlertsAlertRuleAggregation.Sum,
                "pct" => AlertsAlertRuleAggregation.Pct,
                _ => null,
            };
        }
    }
}