
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum TracerSessionsCreateSessionRequestTraceTier
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
    public static class TracerSessionsCreateSessionRequestTraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracerSessionsCreateSessionRequestTraceTier value)
        {
            return value switch
            {
                TracerSessionsCreateSessionRequestTraceTier.LongLived => "LONG_LIVED",
                TracerSessionsCreateSessionRequestTraceTier.ShortLived => "SHORT_LIVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracerSessionsCreateSessionRequestTraceTier? ToEnum(string value)
        {
            return value switch
            {
                "LONG_LIVED" => TracerSessionsCreateSessionRequestTraceTier.LongLived,
                "SHORT_LIVED" => TracerSessionsCreateSessionRequestTraceTier.ShortLived,
                _ => null,
            };
        }
    }
}