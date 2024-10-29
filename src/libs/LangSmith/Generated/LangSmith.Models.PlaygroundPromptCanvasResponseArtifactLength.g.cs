
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundPromptCanvasResponseArtifactLength
    {
        /// <summary>
        /// 
        /// </summary>
        Shortest,
        /// <summary>
        /// 
        /// </summary>
        Short,
        /// <summary>
        /// 
        /// </summary>
        Long,
        /// <summary>
        /// 
        /// </summary>
        Longest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaygroundPromptCanvasResponseArtifactLengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundPromptCanvasResponseArtifactLength value)
        {
            return value switch
            {
                PlaygroundPromptCanvasResponseArtifactLength.Shortest => "shortest",
                PlaygroundPromptCanvasResponseArtifactLength.Short => "short",
                PlaygroundPromptCanvasResponseArtifactLength.Long => "long",
                PlaygroundPromptCanvasResponseArtifactLength.Longest => "longest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundPromptCanvasResponseArtifactLength? ToEnum(string value)
        {
            return value switch
            {
                "shortest" => PlaygroundPromptCanvasResponseArtifactLength.Shortest,
                "short" => PlaygroundPromptCanvasResponseArtifactLength.Short,
                "long" => PlaygroundPromptCanvasResponseArtifactLength.Long,
                "longest" => PlaygroundPromptCanvasResponseArtifactLength.Longest,
                _ => null,
            };
        }
    }
}