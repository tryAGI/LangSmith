
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthSessionStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        SessionStrategyCreate,
        /// <summary>
        /// 
        /// </summary>
        SessionStrategyReuse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthSessionStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthSessionStrategy value)
        {
            return value switch
            {
                AuthSessionStrategy.SessionStrategyCreate => "CREATE",
                AuthSessionStrategy.SessionStrategyReuse => "REUSE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthSessionStrategy? ToEnum(string value)
        {
            return value switch
            {
                "CREATE" => AuthSessionStrategy.SessionStrategyCreate,
                "REUSE" => AuthSessionStrategy.SessionStrategyReuse,
                _ => null,
            };
        }
    }
}