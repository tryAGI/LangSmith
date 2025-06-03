
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertsAlertRuleOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertsAlertRuleOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertsAlertRuleOperator value)
        {
            return value switch
            {
                AlertsAlertRuleOperator.Gte => "gte",
                AlertsAlertRuleOperator.Lte => "lte",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertsAlertRuleOperator? ToEnum(string value)
        {
            return value switch
            {
                "gte" => AlertsAlertRuleOperator.Gte,
                "lte" => AlertsAlertRuleOperator.Lte,
                _ => null,
            };
        }
    }
}