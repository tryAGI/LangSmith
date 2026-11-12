
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RulesAlertType
    {
        /// <summary>
        ///
        /// </summary>
        Pagerduty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RulesAlertTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RulesAlertType value)
        {
            return value switch
            {
                RulesAlertType.Pagerduty => "PAGERDUTY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RulesAlertType? ToEnum(string value)
        {
            return value switch
            {
                "PAGERDUTY" => RulesAlertType.Pagerduty,
                _ => null,
            };
        }
    }
}