
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunRuleSpendLimitWindow
    {
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunRuleSpendLimitWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunRuleSpendLimitWindow value)
        {
            return value switch
            {
                RunRuleSpendLimitWindow.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunRuleSpendLimitWindow? ToEnum(string value)
        {
            return value switch
            {
                "weekly" => RunRuleSpendLimitWindow.Weekly,
                _ => null,
            };
        }
    }
}