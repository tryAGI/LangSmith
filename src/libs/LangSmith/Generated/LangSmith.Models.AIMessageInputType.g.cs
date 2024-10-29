
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: ai
    /// </summary>
    public enum AIMessageInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AIMessageInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AIMessageInputType value)
        {
            return value switch
            {
                AIMessageInputType.Ai => "ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AIMessageInputType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => AIMessageInputType.Ai,
                _ => null,
            };
        }
    }
}