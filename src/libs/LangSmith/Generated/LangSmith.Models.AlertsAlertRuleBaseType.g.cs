
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
        Change,
        /// <summary>
        /// 
        /// </summary>
        Threshold,
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
                AlertsAlertRuleBaseType.Change => "change",
                AlertsAlertRuleBaseType.Threshold => "threshold",
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
                "change" => AlertsAlertRuleBaseType.Change,
                "threshold" => AlertsAlertRuleBaseType.Threshold,
                _ => null,
            };
        }
    }
}