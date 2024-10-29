
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: AIMessageChunk
    /// </summary>
    public enum AIMessageChunkOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        AIMessageChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AIMessageChunkOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AIMessageChunkOutputType value)
        {
            return value switch
            {
                AIMessageChunkOutputType.AIMessageChunk => "AIMessageChunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AIMessageChunkOutputType? ToEnum(string value)
        {
            return value switch
            {
                "AIMessageChunk" => AIMessageChunkOutputType.AIMessageChunk,
                _ => null,
            };
        }
    }
}