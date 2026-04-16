
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum BotocoreS3ConfigUsEast1RegionalEndpoint2
    {
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        Regional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BotocoreS3ConfigUsEast1RegionalEndpoint2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BotocoreS3ConfigUsEast1RegionalEndpoint2 value)
        {
            return value switch
            {
                BotocoreS3ConfigUsEast1RegionalEndpoint2.Legacy => "legacy",
                BotocoreS3ConfigUsEast1RegionalEndpoint2.Regional => "regional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BotocoreS3ConfigUsEast1RegionalEndpoint2? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => BotocoreS3ConfigUsEast1RegionalEndpoint2.Legacy,
                "regional" => BotocoreS3ConfigUsEast1RegionalEndpoint2.Regional,
                _ => null,
            };
        }
    }
}