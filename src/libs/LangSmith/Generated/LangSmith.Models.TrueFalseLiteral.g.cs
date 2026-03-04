
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrueFalseLiteral
    {
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        False,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrueFalseLiteralExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrueFalseLiteral value)
        {
            return value switch
            {
                TrueFalseLiteral.True => "true",
                TrueFalseLiteral.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrueFalseLiteral? ToEnum(string value)
        {
            return value switch
            {
                "true" => TrueFalseLiteral.True,
                "false" => TrueFalseLiteral.False,
                _ => null,
            };
        }
    }
}