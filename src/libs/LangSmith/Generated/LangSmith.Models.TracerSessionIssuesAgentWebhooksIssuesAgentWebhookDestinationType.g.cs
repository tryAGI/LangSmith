
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Jira,
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
    public static class TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType value)
        {
            return value switch
            {
                TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType.Jira => "jira",
                TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType.Slack => "slack",
                TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "jira" => TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType.Jira,
                "slack" => TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType.Slack,
                "webhook" => TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType.Webhook,
                _ => null,
            };
        }
    }
}