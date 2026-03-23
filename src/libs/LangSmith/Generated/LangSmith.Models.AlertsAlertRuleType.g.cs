
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
        Change,
        /// <summary>
        /// 
        /// </summary>
        Threshold,
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
                AlertsAlertRuleType.Change => "change",
                AlertsAlertRuleType.Threshold => "threshold",
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
                "change" => AlertsAlertRuleType.Change,
                "threshold" => AlertsAlertRuleType.Threshold,
                _ => null,
            };
        }
    }
}