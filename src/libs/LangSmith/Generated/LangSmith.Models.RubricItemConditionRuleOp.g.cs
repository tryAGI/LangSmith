
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RubricItemConditionRuleOp
    {
        /// <summary>
        ///
        /// </summary>
        Is,
        /// <summary>
        ///
        /// </summary>
        IsEmpty,
        /// <summary>
        ///
        /// </summary>
        IsNotEmpty,
        /// <summary>
        ///
        /// </summary>
        IsOneOf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RubricItemConditionRuleOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RubricItemConditionRuleOp value)
        {
            return value switch
            {
                RubricItemConditionRuleOp.Is => "is",
                RubricItemConditionRuleOp.IsEmpty => "is_empty",
                RubricItemConditionRuleOp.IsNotEmpty => "is_not_empty",
                RubricItemConditionRuleOp.IsOneOf => "is_one_of",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RubricItemConditionRuleOp? ToEnum(string value)
        {
            return value switch
            {
                "is" => RubricItemConditionRuleOp.Is,
                "is_empty" => RubricItemConditionRuleOp.IsEmpty,
                "is_not_empty" => RubricItemConditionRuleOp.IsNotEmpty,
                "is_one_of" => RubricItemConditionRuleOp.IsOneOf,
                _ => null,
            };
        }
    }
}