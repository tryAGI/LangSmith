
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: AIMessageChunk
    /// </summary>
    public enum AIMessageChunkInputType
    {
        /// <summary>
        /// 
        /// </summary>
        AIMessageChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AIMessageChunkInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AIMessageChunkInputType value)
        {
            return value switch
            {
                AIMessageChunkInputType.AIMessageChunk => "AIMessageChunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AIMessageChunkInputType? ToEnum(string value)
        {
            return value switch
            {
                "AIMessageChunk" => AIMessageChunkInputType.AIMessageChunk,
                _ => null,
            };
        }
    }
}