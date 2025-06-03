
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertsAlertRuleBaseType
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
    public static class AlertsAlertRuleBaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertsAlertRuleBaseType value)
        {
            return value switch
            {
                AlertsAlertRuleBaseType.Threshold => "threshold",
                AlertsAlertRuleBaseType.Change => "change",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertsAlertRuleBaseType? ToEnum(string value)
        {
            return value switch
            {
                "threshold" => AlertsAlertRuleBaseType.Threshold,
                "change" => AlertsAlertRuleBaseType.Change,
                _ => null,
            };
        }
    }
}