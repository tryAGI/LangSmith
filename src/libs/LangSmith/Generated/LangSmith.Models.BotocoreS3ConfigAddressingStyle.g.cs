
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum BotocoreS3ConfigAddressingStyle
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Path,
        /// <summary>
        ///
        /// </summary>
        Virtual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BotocoreS3ConfigAddressingStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BotocoreS3ConfigAddressingStyle value)
        {
            return value switch
            {
                BotocoreS3ConfigAddressingStyle.Auto => "auto",
                BotocoreS3ConfigAddressingStyle.Path => "path",
                BotocoreS3ConfigAddressingStyle.Virtual => "virtual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BotocoreS3ConfigAddressingStyle? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BotocoreS3ConfigAddressingStyle.Auto,
                "path" => BotocoreS3ConfigAddressingStyle.Path,
                "virtual" => BotocoreS3ConfigAddressingStyle.Virtual,
                _ => null,
            };
        }
    }
}