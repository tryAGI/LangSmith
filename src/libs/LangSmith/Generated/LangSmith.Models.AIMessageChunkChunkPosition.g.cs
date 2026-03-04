
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AIMessageChunkChunkPosition
    {
        /// <summary>
        /// 
        /// </summary>
        Last,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AIMessageChunkChunkPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AIMessageChunkChunkPosition value)
        {
            return value switch
            {
                AIMessageChunkChunkPosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AIMessageChunkChunkPosition? ToEnum(string value)
        {
            return value switch
            {
                "last" => AIMessageChunkChunkPosition.Last,
                _ => null,
            };
        }
    }
}