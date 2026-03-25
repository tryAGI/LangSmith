
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
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
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
                AlertsAlertRuleBaseOperator.Gt => "gt",
                AlertsAlertRuleBaseOperator.Gte => "gte",
                AlertsAlertRuleBaseOperator.Lt => "lt",
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
                "gt" => AlertsAlertRuleBaseOperator.Gt,
                "gte" => AlertsAlertRuleBaseOperator.Gte,
                "lt" => AlertsAlertRuleBaseOperator.Lt,
                "lte" => AlertsAlertRuleBaseOperator.Lte,
                _ => null,
            };
        }
    }
}