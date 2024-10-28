
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlayGroundGraphReadingLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Child,
        /// <summary>
        /// 
        /// </summary>
        Teenager,
        /// <summary>
        /// 
        /// </summary>
        College,
        /// <summary>
        /// 
        /// </summary>
        Phd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayGroundGraphReadingLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayGroundGraphReadingLevel value)
        {
            return value switch
            {
                PlayGroundGraphReadingLevel.Child => "child",
                PlayGroundGraphReadingLevel.Teenager => "teenager",
                PlayGroundGraphReadingLevel.College => "college",
                PlayGroundGraphReadingLevel.Phd => "phd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayGroundGraphReadingLevel? ToEnum(string value)
        {
            return value switch
            {
                "child" => PlayGroundGraphReadingLevel.Child,
                "teenager" => PlayGroundGraphReadingLevel.Teenager,
                "college" => PlayGroundGraphReadingLevel.College,
                "phd" => PlayGroundGraphReadingLevel.Phd,
                _ => null,
            };
        }
    }
}