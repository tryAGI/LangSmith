
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertsAlertActionTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Pagerduty,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertsAlertActionTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertsAlertActionTarget value)
        {
            return value switch
            {
                AlertsAlertActionTarget.Pagerduty => "pagerduty",
                AlertsAlertActionTarget.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertsAlertActionTarget? ToEnum(string value)
        {
            return value switch
            {
                "pagerduty" => AlertsAlertActionTarget.Pagerduty,
                "webhook" => AlertsAlertActionTarget.Webhook,
                _ => null,
            };
        }
    }
}