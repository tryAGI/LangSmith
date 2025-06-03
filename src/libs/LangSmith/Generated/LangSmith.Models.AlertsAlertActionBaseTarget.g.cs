
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertsAlertActionBaseTarget
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
    public static class AlertsAlertActionBaseTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertsAlertActionBaseTarget value)
        {
            return value switch
            {
                AlertsAlertActionBaseTarget.Pagerduty => "pagerduty",
                AlertsAlertActionBaseTarget.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertsAlertActionBaseTarget? ToEnum(string value)
        {
            return value switch
            {
                "pagerduty" => AlertsAlertActionBaseTarget.Pagerduty,
                "webhook" => AlertsAlertActionBaseTarget.Webhook,
                _ => null,
            };
        }
    }
}