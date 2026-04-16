
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum BotocoreS3ConfigAddressingStyle2
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
    public static class BotocoreS3ConfigAddressingStyle2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BotocoreS3ConfigAddressingStyle2 value)
        {
            return value switch
            {
                BotocoreS3ConfigAddressingStyle2.Auto => "auto",
                BotocoreS3ConfigAddressingStyle2.Path => "path",
                BotocoreS3ConfigAddressingStyle2.Virtual => "virtual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BotocoreS3ConfigAddressingStyle2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BotocoreS3ConfigAddressingStyle2.Auto,
                "path" => BotocoreS3ConfigAddressingStyle2.Path,
                "virtual" => BotocoreS3ConfigAddressingStyle2.Virtual,
                _ => null,
            };
        }
    }
}