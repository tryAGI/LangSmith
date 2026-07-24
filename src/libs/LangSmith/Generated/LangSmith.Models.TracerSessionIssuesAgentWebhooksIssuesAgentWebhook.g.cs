
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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_types")]
        public global::System.Collections.Generic.IList<string>? EventTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// IssueStatuses scopes delivery to issues in one of these statuses. Nil/empty<br/>
        /// (the default) fires for every status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_statuses")]
        public global::System.Collections.Generic.IList<string>? IssueStatuses { get; set; }

        /// <summary>
        /// OrganizationID is derived from the tenant on fetch (no stored column); the<br/>
        /// row carries it so Slack delivery can address the org-scoped install.
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing_secret")]
        public string? SigningSecret { get; set; }

        /// <summary>
        /// Delivery target is either a URL or a Slack channel. SlackTeamID is the<br/>
        /// channel's workspace (which install to send through).
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesAgentWebhooksIssuesAgentWebhook" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="eventTypes"></param>
        /// <param name="headers"></param>
        /// <param name="id"></param>
        /// <param name="issueStatuses">
        /// IssueStatuses scopes delivery to issues in one of these statuses. Nil/empty<br/>
        /// (the default) fires for every status.
        /// </param>
        /// <param name="organizationId">
        /// OrganizationID is derived from the tenant on fetch (no stored column); the<br/>
        /// row carries it so Slack delivery can address the org-scoped install.
        /// </param>
        /// <param name="sessionId"></param>
        /// <param name="severityThreshold"></param>
        /// <param name="signingSecret"></param>
        /// <param name="slackChannelId">
        /// Delivery target is either a URL or a Slack channel. SlackTeamID is the<br/>
        /// channel's workspace (which install to send through).
        /// </param>
        /// <param name="slackTeamId"></param>
        /// <param name="tenantId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionIssuesAgentWebhooksIssuesAgentWebhook(
            string? createdAt,
            global::System.Collections.Generic.IList<string>? eventTypes,
            object? headers,
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
            string? url)
        {
            this.CreatedAt = createdAt;
            this.EventTypes = eventTypes;
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesAgentWebhooksIssuesAgentWebhook" /> class.
        /// </summary>
        public TracerSessionIssuesAgentWebhooksIssuesAgentWebhook()
        {
        }

    }
}