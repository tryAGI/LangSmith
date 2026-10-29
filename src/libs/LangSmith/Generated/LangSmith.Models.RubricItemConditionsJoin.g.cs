
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RubricItemConditionsJoin
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RubricItemConditionsJoinExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RubricItemConditionsJoin value)
        {
            return value switch
            {
                RubricItemConditionsJoin.All => "all",
                RubricItemConditionsJoin.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RubricItemConditionsJoin? ToEnum(string value)
        {
            return value switch
            {
                "all" => RubricItemConditionsJoin.All,
                "any" => RubricItemConditionsJoin.Any,
                _ => null,
            };
        }
    }
}