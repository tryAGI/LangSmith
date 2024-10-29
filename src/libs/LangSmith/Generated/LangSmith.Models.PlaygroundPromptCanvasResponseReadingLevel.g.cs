
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundPromptCanvasResponseReadingLevel
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
    public static class PlaygroundPromptCanvasResponseReadingLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundPromptCanvasResponseReadingLevel value)
        {
            return value switch
            {
                PlaygroundPromptCanvasResponseReadingLevel.Child => "child",
                PlaygroundPromptCanvasResponseReadingLevel.Teenager => "teenager",
                PlaygroundPromptCanvasResponseReadingLevel.College => "college",
                PlaygroundPromptCanvasResponseReadingLevel.Phd => "phd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundPromptCanvasResponseReadingLevel? ToEnum(string value)
        {
            return value switch
            {
                "child" => PlaygroundPromptCanvasResponseReadingLevel.Child,
                "teenager" => PlaygroundPromptCanvasResponseReadingLevel.Teenager,
                "college" => PlaygroundPromptCanvasResponseReadingLevel.College,
                "phd" => PlaygroundPromptCanvasResponseReadingLevel.Phd,
                _ => null,
            };
        }
    }
}