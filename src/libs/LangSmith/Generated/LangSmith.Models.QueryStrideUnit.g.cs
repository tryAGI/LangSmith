
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum QueryStrideUnit
    {
        /// <summary>
        ///
        /// </summary>
        StrideUnitDay,
        /// <summary>
        ///
        /// </summary>
        StrideUnitHour,
        /// <summary>
        ///
        /// </summary>
        StrideUnitMinute,
        /// <summary>
        ///
        /// </summary>
        StrideUnitSecond,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryStrideUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryStrideUnit value)
        {
            return value switch
            {
                QueryStrideUnit.StrideUnitDay => "DAY",
                QueryStrideUnit.StrideUnitHour => "HOUR",
                QueryStrideUnit.StrideUnitMinute => "MINUTE",
                QueryStrideUnit.StrideUnitSecond => "SECOND",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryStrideUnit? ToEnum(string value)
        {
            return value switch
            {
                "DAY" => QueryStrideUnit.StrideUnitDay,
                "HOUR" => QueryStrideUnit.StrideUnitHour,
                "MINUTE" => QueryStrideUnit.StrideUnitMinute,
                "SECOND" => QueryStrideUnit.StrideUnitSecond,
                _ => null,
            };
        }
    }
}