
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertsAlertRuleBaseOperator
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
    public static class AlertsAlertRuleBaseOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertsAlertRuleBaseOperator value)
        {
            return value switch
            {
                AlertsAlertRuleBaseOperator.Gte => "gte",
                AlertsAlertRuleBaseOperator.Lte => "lte",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertsAlertRuleBaseOperator? ToEnum(string value)
        {
            return value switch
            {
                "gte" => AlertsAlertRuleBaseOperator.Gte,
                "lte" => AlertsAlertRuleBaseOperator.Lte,
                _ => null,
            };
        }
    }
}