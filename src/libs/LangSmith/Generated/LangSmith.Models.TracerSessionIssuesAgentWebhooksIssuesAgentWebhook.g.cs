
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TracerSessionIssuesAgentWebhooksIssuesAgentWebhook
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationTypeJsonConverter))]
        public global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType? DestinationType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_types")]
        public global::System.Collections.Generic.IList<string>? EventTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_jira_token")]
        public bool? HasJiraToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_signing_secret")]
        public bool? HasSigningSecret { get; set; }

        /// <summary>
        /// HasUnreadableCredentials marks a row retained in the settings list whose<br/>
        /// encrypted credential envelope could not be opened. No credential-derived<br/>
        /// fields are populated for such a row; it must be deleted and recreated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_unreadable_credentials")]
        public bool? HasUnreadableCredentials { get; set; }

        /// <summary>
        /// HeaderNames lists configured header names for write-only clients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_names")]
        public global::System.Collections.Generic.IList<string>? HeaderNames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_statuses")]
        public global::System.Collections.Generic.IList<string>? IssueStatuses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_threshold")]
        public int? SeverityThreshold { get; set; }

        /// <summary>
        /// SigningSecret is present only in successful create, URL-conversion update,<br/>
        /// and roll responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing_secret")]
        public string? SigningSecret { get; set; }

        /// <summary>
        /// Keep empty Slack fields in the response. The frontend uses an explicit<br/>
        /// empty string to distinguish URL destinations from Slack destinations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_channel_id")]
        public string? SlackChannelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_team_id")]
        public string? SlackTeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// URL and Headers are retained as always-empty fields so a client written<br/>
        /// against the pre-write-only contract still parses the response. Use<br/>
        /// URLDisplay and HeaderNames instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// URLDisplay contains only the destination hostname.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_display")]
        public string? UrlDisplay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesAgentWebhooksIssuesAgentWebhook" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="destinationType"></param>
        /// <param name="eventTypes"></param>
        /// <param name="hasJiraToken"></param>
        /// <param name="hasSigningSecret"></param>
        /// <param name="hasUnreadableCredentials">
        /// HasUnreadableCredentials marks a row retained in the settings list whose<br/>
        /// encrypted credential envelope could not be opened. No credential-derived<br/>
        /// fields are populated for such a row; it must be deleted and recreated.
        /// </param>
        /// <param name="headerNames">
        /// HeaderNames lists configured header names for write-only clients.
        /// </param>
        /// <param name="headers"></param>
        /// <param name="id"></param>
        /// <param name="issueStatuses"></param>
        /// <param name="organizationId"></param>
        /// <param name="sessionId"></param>
        /// <param name="severityThreshold"></param>
        /// <param name="signingSecret">
        /// SigningSecret is present only in successful create, URL-conversion update,<br/>
        /// and roll responses.
        /// </param>
        /// <param name="slackChannelId">
        /// Keep empty Slack fields in the response. The frontend uses an explicit<br/>
        /// empty string to distinguish URL destinations from Slack destinations.
        /// </param>
        /// <param name="slackTeamId"></param>
        /// <param name="tenantId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// URL and Headers are retained as always-empty fields so a client written<br/>
        /// against the pre-write-only contract still parses the response. Use<br/>
        /// URLDisplay and HeaderNames instead.
        /// </param>
        /// <param name="urlDisplay">
        /// URLDisplay contains only the destination hostname.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionIssuesAgentWebhooksIssuesAgentWebhook(
            string? createdAt,
            global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType? destinationType,
            global::System.Collections.Generic.IList<string>? eventTypes,
            bool? hasJiraToken,
            bool? hasSigningSecret,
            bool? hasUnreadableCredentials,
            global::System.Collections.Generic.IList<string>? headerNames,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? id,
            global::System.Collections.Generic.IList<string>? issueStatuses,
            string? organizationId,
            string? sessionId,
            int? severityThreshold,
            string? signingSecret,
            string? slackChannelId,
            string? slackTeamId,
            string? tenantId,
            string? updatedAt,
            string? url,
            string? urlDisplay)
        {
            this.CreatedAt = createdAt;
            this.DestinationType = destinationType;
            this.EventTypes = eventTypes;
            this.HasJiraToken = hasJiraToken;
            this.HasSigningSecret = hasSigningSecret;
            this.HasUnreadableCredentials = hasUnreadableCredentials;
            this.HeaderNames = headerNames;
            this.Headers = headers;
            this.Id = id;
            this.IssueStatuses = issueStatuses;
            this.OrganizationId = organizationId;
            this.SessionId = sessionId;
            this.SeverityThreshold = severityThreshold;
            this.SigningSecret = signingSecret;
            this.SlackChannelId = slackChannelId;
            this.SlackTeamId = slackTeamId;
            this.TenantId = tenantId;
            this.UpdatedAt = updatedAt;
            this.Url = url;
            this.UrlDisplay = urlDisplay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesAgentWebhooksIssuesAgentWebhook" /> class.
        /// </summary>
        public TracerSessionIssuesAgentWebhooksIssuesAgentWebhook()
        {
        }

    }
}