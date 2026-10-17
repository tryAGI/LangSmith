
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlertsAlertAction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_rule_id")]
        public string? AlertRuleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_suspended")]
        public bool? IsSuspended { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended_at")]
        public string? SuspendedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended_reason")]
        public string? SuspendedReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended_status_code")]
        public int? SuspendedStatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AlertsAlertActionTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertsAlertActionTarget Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsAlertAction" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="target"></param>
        /// <param name="alertRuleId"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="isSuspended"></param>
        /// <param name="suspendedAt"></param>
        /// <param name="suspendedReason"></param>
        /// <param name="suspendedStatusCode"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertsAlertAction(
            object config,
            global::LangSmith.AlertsAlertActionTarget target,
            string? alertRuleId,
            string? createdAt,
            string? id,
            bool? isSuspended,
            string? suspendedAt,
            string? suspendedReason,
            int? suspendedStatusCode,
            string? updatedAt)
        {
            this.AlertRuleId = alertRuleId;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.CreatedAt = createdAt;
            this.Id = id;
            this.IsSuspended = isSuspended;
            this.SuspendedAt = suspendedAt;
            this.SuspendedReason = suspendedReason;
            this.SuspendedStatusCode = suspendedStatusCode;
            this.Target = target;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsAlertAction" /> class.
        /// </summary>
        public AlertsAlertAction()
        {
        }

    }
}