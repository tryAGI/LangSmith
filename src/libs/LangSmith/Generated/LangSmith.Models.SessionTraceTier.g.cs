
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionTraceTier
    {
        /// <summary>
        ///
        /// </summary>
        LongLived,
        /// <summary>
        ///
        /// </summary>
        ShortLived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionTraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionTraceTier value)
        {
            return value switch
            {
                SessionTraceTier.LongLived => "LONG_LIVED",
                SessionTraceTier.ShortLived => "SHORT_LIVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionTraceTier? ToEnum(string value)
        {
            return value switch
            {
                "LONG_LIVED" => SessionTraceTier.LongLived,
                "SHORT_LIVED" => SessionTraceTier.ShortLived,
                _ => null,
            };
        }
    }
}