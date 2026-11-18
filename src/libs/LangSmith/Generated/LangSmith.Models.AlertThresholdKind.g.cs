
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// How an alert threshold value is measured.
    /// </summary>
    public enum AlertThresholdKind
    {
        /// <summary>
        ///
        /// </summary>
        Count,
        /// <summary>
        ///
        /// </summary>
        Percent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertThresholdKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertThresholdKind value)
        {
            return value switch
            {
                AlertThresholdKind.Count => "COUNT",
                AlertThresholdKind.Percent => "PERCENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertThresholdKind? ToEnum(string value)
        {
            return value switch
            {
                "COUNT" => AlertThresholdKind.Count,
                "PERCENT" => AlertThresholdKind.Percent,
                _ => null,
            };
        }
    }
}