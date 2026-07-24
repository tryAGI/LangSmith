
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GatewayPoliciesRateLimitUsage
    {
        /// <summary>
        /// Metric is the counted usage dimension: requests or tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.GatewayPoliciesRateLimitMetricJsonConverter))]
        public global::LangSmith.GatewayPoliciesRateLimitMetric? Metric { get; set; }

        /// <summary>
        /// Value is the units consumed so far in the current window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Window is the time window the usage is measured over.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.GatewayPoliciesRateLimitWindowJsonConverter))]
        public global::LangSmith.GatewayPoliciesRateLimitWindow? Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPoliciesRateLimitUsage" /> class.
        /// </summary>
        /// <param name="metric">
        /// Metric is the counted usage dimension: requests or tokens.
        /// </param>
        /// <param name="value">
        /// Value is the units consumed so far in the current window.
        /// </param>
        /// <param name="window">
        /// Window is the time window the usage is measured over.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayPoliciesRateLimitUsage(
            global::LangSmith.GatewayPoliciesRateLimitMetric? metric,
            int? value,
            global::LangSmith.GatewayPoliciesRateLimitWindow? window)
        {
            this.Metric = metric;
            this.Value = value;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPoliciesRateLimitUsage" /> class.
        /// </summary>
        public GatewayPoliciesRateLimitUsage()
        {
        }

    }
}