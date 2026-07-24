
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum GatewayPoliciesRateLimitMetric
    {
        /// <summary>
        /// 
        /// </summary>
        RateLimitMetricRequests,
        /// <summary>
        /// 
        /// </summary>
        RateLimitMetricTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GatewayPoliciesRateLimitMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GatewayPoliciesRateLimitMetric value)
        {
            return value switch
            {
                GatewayPoliciesRateLimitMetric.RateLimitMetricRequests => "requests",
                GatewayPoliciesRateLimitMetric.RateLimitMetricTokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GatewayPoliciesRateLimitMetric? ToEnum(string value)
        {
            return value switch
            {
                "requests" => GatewayPoliciesRateLimitMetric.RateLimitMetricRequests,
                "tokens" => GatewayPoliciesRateLimitMetric.RateLimitMetricTokens,
                _ => null,
            };
        }
    }
}