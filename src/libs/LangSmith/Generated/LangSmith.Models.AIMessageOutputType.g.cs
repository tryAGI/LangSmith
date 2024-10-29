
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: ai
    /// </summary>
    public enum AIMessageOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AIMessageOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AIMessageOutputType value)
        {
            return value switch
            {
                AIMessageOutputType.Ai => "ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AIMessageOutputType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => AIMessageOutputType.Ai,
                _ => null,
            };
        }
    }
}