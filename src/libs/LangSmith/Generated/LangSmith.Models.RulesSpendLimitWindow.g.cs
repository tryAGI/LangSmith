
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RulesSpendLimitWindow
    {
        /// <summary>
        ///
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RulesSpendLimitWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RulesSpendLimitWindow value)
        {
            return value switch
            {
                RulesSpendLimitWindow.Weekly => "WEEKLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RulesSpendLimitWindow? ToEnum(string value)
        {
            return value switch
            {
                "WEEKLY" => RulesSpendLimitWindow.Weekly,
                _ => null,
            };
        }
    }
}