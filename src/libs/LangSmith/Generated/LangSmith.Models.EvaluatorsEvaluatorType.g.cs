
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvaluatorsEvaluatorType
    {
        /// <summary>
        /// 
        /// </summary>
        EvaluatorTypeCode,
        /// <summary>
        /// 
        /// </summary>
        EvaluatorTypeLLM,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorsEvaluatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorsEvaluatorType value)
        {
            return value switch
            {
                EvaluatorsEvaluatorType.EvaluatorTypeCode => "code",
                EvaluatorsEvaluatorType.EvaluatorTypeLLM => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorsEvaluatorType? ToEnum(string value)
        {
            return value switch
            {
                "code" => EvaluatorsEvaluatorType.EvaluatorTypeCode,
                "llm" => EvaluatorsEvaluatorType.EvaluatorTypeLLM,
                _ => null,
            };
        }
    }
}