
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorsCodeEvaluatorInput
    {
        /// <summary>
        ///
        /// </summary>
        CodeEvaluatorInputAllMessages,
        /// <summary>
        ///
        /// </summary>
        CodeEvaluatorInputFirstHumanLastAI,
        /// <summary>
        ///
        /// </summary>
        CodeEvaluatorInputHumanAIPairs,
        /// <summary>
        ///
        /// </summary>
        CodeEvaluatorInputThread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorsCodeEvaluatorInputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorsCodeEvaluatorInput value)
        {
            return value switch
            {
                EvaluatorsCodeEvaluatorInput.CodeEvaluatorInputAllMessages => "all_messages",
                EvaluatorsCodeEvaluatorInput.CodeEvaluatorInputFirstHumanLastAI => "first_human_last_ai",
                EvaluatorsCodeEvaluatorInput.CodeEvaluatorInputHumanAIPairs => "human_ai_pairs",
                EvaluatorsCodeEvaluatorInput.CodeEvaluatorInputThread => "thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorsCodeEvaluatorInput? ToEnum(string value)
        {
            return value switch
            {
                "all_messages" => EvaluatorsCodeEvaluatorInput.CodeEvaluatorInputAllMessages,
                "first_human_last_ai" => EvaluatorsCodeEvaluatorInput.CodeEvaluatorInputFirstHumanLastAI,
                "human_ai_pairs" => EvaluatorsCodeEvaluatorInput.CodeEvaluatorInputHumanAIPairs,
                "thread" => EvaluatorsCodeEvaluatorInput.CodeEvaluatorInputThread,
                _ => null,
            };
        }
    }
}