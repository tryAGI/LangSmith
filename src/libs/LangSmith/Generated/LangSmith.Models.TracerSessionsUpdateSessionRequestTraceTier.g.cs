
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum TracerSessionsUpdateSessionRequestTraceTier
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
    public static class TracerSessionsUpdateSessionRequestTraceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracerSessionsUpdateSessionRequestTraceTier value)
        {
            return value switch
            {
                TracerSessionsUpdateSessionRequestTraceTier.LongLived => "LONG_LIVED",
                TracerSessionsUpdateSessionRequestTraceTier.ShortLived => "SHORT_LIVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracerSessionsUpdateSessionRequestTraceTier? ToEnum(string value)
        {
            return value switch
            {
                "LONG_LIVED" => TracerSessionsUpdateSessionRequestTraceTier.LongLived,
                "SHORT_LIVED" => TracerSessionsUpdateSessionRequestTraceTier.ShortLived,
                _ => null,
            };
        }
    }
}