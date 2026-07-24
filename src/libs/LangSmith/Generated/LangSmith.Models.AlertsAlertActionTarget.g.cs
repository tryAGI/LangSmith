
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
        Dynatrace,
        /// <summary>
        /// 
        /// </summary>
        Pagerduty,
        /// <summary>
        /// 
        /// </summary>
        Slack,
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
                AlertsAlertActionTarget.Dynatrace => "dynatrace",
                AlertsAlertActionTarget.Pagerduty => "pagerduty",
                AlertsAlertActionTarget.Slack => "slack",
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
                "dynatrace" => AlertsAlertActionTarget.Dynatrace,
                "pagerduty" => AlertsAlertActionTarget.Pagerduty,
                "slack" => AlertsAlertActionTarget.Slack,
                "webhook" => AlertsAlertActionTarget.Webhook,
                _ => null,
            };
        }
    }
}