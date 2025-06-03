
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertsAlertRuleType
    {
        /// <summary>
        /// 
        /// </summary>
        Threshold,
        /// <summary>
        /// 
        /// </summary>
        Change,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertsAlertRuleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertsAlertRuleType value)
        {
            return value switch
            {
                AlertsAlertRuleType.Threshold => "threshold",
                AlertsAlertRuleType.Change => "change",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertsAlertRuleType? ToEnum(string value)
        {
            return value switch
            {
                "threshold" => AlertsAlertRuleType.Threshold,
                "change" => AlertsAlertRuleType.Change,
                _ => null,
            };
        }
    }
}