
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum GatewayPoliciesRateLimitWindow
    {
        /// <summary>
        /// 
        /// </summary>
        RateLimitWindowHour,
        /// <summary>
        /// 
        /// </summary>
        RateLimitWindowMinute,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GatewayPoliciesRateLimitWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GatewayPoliciesRateLimitWindow value)
        {
            return value switch
            {
                GatewayPoliciesRateLimitWindow.RateLimitWindowHour => "hour",
                GatewayPoliciesRateLimitWindow.RateLimitWindowMinute => "minute",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GatewayPoliciesRateLimitWindow? ToEnum(string value)
        {
            return value switch
            {
                "hour" => GatewayPoliciesRateLimitWindow.RateLimitWindowHour,
                "minute" => GatewayPoliciesRateLimitWindow.RateLimitWindowMinute,
                _ => null,
            };
        }
    }
}