
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertsAlertRuleBaseAggregation
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
    public static class AlertsAlertRuleBaseAggregationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertsAlertRuleBaseAggregation value)
        {
            return value switch
            {
                AlertsAlertRuleBaseAggregation.Avg => "avg",
                AlertsAlertRuleBaseAggregation.Pct => "pct",
                AlertsAlertRuleBaseAggregation.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertsAlertRuleBaseAggregation? ToEnum(string value)
        {
            return value switch
            {
                "avg" => AlertsAlertRuleBaseAggregation.Avg,
                "pct" => AlertsAlertRuleBaseAggregation.Pct,
                "sum" => AlertsAlertRuleBaseAggregation.Sum,
                _ => null,
            };
        }
    }
}