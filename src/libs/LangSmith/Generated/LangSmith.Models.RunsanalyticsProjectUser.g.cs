
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunsanalyticsProjectUser
    {
        /// <summary>
        /// ErrorCount counts finished root runs that failed. Null while statistics<br/>
        /// are pending, or when SmithDB returns no error rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        public int? ErrorCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_rate")]
        public double? ErrorRate { get; set; }

        /// <summary>
        /// LastSeen is the latest start time among matching root runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastSeen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p50_seconds")]
        public double? LatencyP50Seconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p99_seconds")]
        public double? LatencyP99Seconds { get; set; }

        /// <summary>
        /// StatsStatus is pending when no statistics group is available, or ready when<br/>
        /// statistics were returned. Ready statistics may still lag recent activity.<br/>
        /// Query again to retrieve statistics that were pending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunsanalyticsProjectUserStatsStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RunsanalyticsProjectUserStatsStatus StatsStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// TotalTokens and TotalCost sum the window's runs that carry this user's<br/>
        /// metadata.user_id. That is not the total for the user's traces: a run tagged<br/>
        /// with a different user is not counted here, and an untagged run counts for<br/>
        /// no user at all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// TraceCount counts finished root runs; runs that have not finished are not<br/>
        /// counted. Null while statistics are pending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_count")]
        public int? TraceCount { get; set; }

        /// <summary>
        /// UserID is the application-defined identity from a root run's metadata.user_id,<br/>
        /// returned as a string. Values need not be UUIDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsanalyticsProjectUser" /> class.
        /// </summary>
        /// <param name="lastSeen">
        /// LastSeen is the latest start time among matching root runs.
        /// </param>
        /// <param name="statsStatus">
        /// StatsStatus is pending when no statistics group is available, or ready when<br/>
        /// statistics were returned. Ready statistics may still lag recent activity.<br/>
        /// Query again to retrieve statistics that were pending.
        /// </param>
        /// <param name="userId">
        /// UserID is the application-defined identity from a root run's metadata.user_id,<br/>
        /// returned as a string. Values need not be UUIDs.
        /// </param>
        /// <param name="errorCount">
        /// ErrorCount counts finished root runs that failed. Null while statistics<br/>
        /// are pending, or when SmithDB returns no error rate.
        /// </param>
        /// <param name="errorRate"></param>
        /// <param name="latencyP50Seconds"></param>
        /// <param name="latencyP99Seconds"></param>
        /// <param name="totalCost"></param>
        /// <param name="totalTokens">
        /// TotalTokens and TotalCost sum the window's runs that carry this user's<br/>
        /// metadata.user_id. That is not the total for the user's traces: a run tagged<br/>
        /// with a different user is not counted here, and an untagged run counts for<br/>
        /// no user at all.
        /// </param>
        /// <param name="traceCount">
        /// TraceCount counts finished root runs; runs that have not finished are not<br/>
        /// counted. Null while statistics are pending.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunsanalyticsProjectUser(
            global::System.DateTime lastSeen,
            global::LangSmith.RunsanalyticsProjectUserStatsStatus statsStatus,
            string userId,
            int? errorCount,
            double? errorRate,
            double? latencyP50Seconds,
            double? latencyP99Seconds,
            double? totalCost,
            int? totalTokens,
            int? traceCount)
        {
            this.ErrorCount = errorCount;
            this.ErrorRate = errorRate;
            this.LastSeen = lastSeen;
            this.LatencyP50Seconds = latencyP50Seconds;
            this.LatencyP99Seconds = latencyP99Seconds;
            this.StatsStatus = statsStatus;
            this.TotalCost = totalCost;
            this.TotalTokens = totalTokens;
            this.TraceCount = traceCount;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsanalyticsProjectUser" /> class.
        /// </summary>
        public RunsanalyticsProjectUser()
        {
        }

    }
}