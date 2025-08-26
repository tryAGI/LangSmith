
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackFormulaWeightedVariablePartType
    {
        /// <summary>
        /// 
        /// </summary>
        WeightedKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackFormulaWeightedVariablePartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackFormulaWeightedVariablePartType value)
        {
            return value switch
            {
                FeedbackFormulaWeightedVariablePartType.WeightedKey => "weighted_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackFormulaWeightedVariablePartType? ToEnum(string value)
        {
            return value switch
            {
                "weighted_key" => FeedbackFormulaWeightedVariablePartType.WeightedKey,
                _ => null,
            };
        }
    }
}