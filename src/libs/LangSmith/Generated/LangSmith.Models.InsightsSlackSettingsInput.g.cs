
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InsightsSlackSettingsInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChannelId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories_notification_enabled")]
        public bool? CategoriesNotificationEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest_cron")]
        public string? DigestCron { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest_timezone")]
        public string? DigestTimezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsSlackSettingsInput" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="channelId"></param>
        /// <param name="categoriesNotificationEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="digestCron"></param>
        /// <param name="digestTimezone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsightsSlackSettingsInput(
            string teamId,
            string channelId,
            bool? categoriesNotificationEnabled,
            string? digestCron,
            string? digestTimezone)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.ChannelId = channelId ?? throw new global::System.ArgumentNullException(nameof(channelId));
            this.CategoriesNotificationEnabled = categoriesNotificationEnabled;
            this.DigestCron = digestCron;
            this.DigestTimezone = digestTimezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsSlackSettingsInput" /> class.
        /// </summary>
        public InsightsSlackSettingsInput()
        {
        }

    }
}