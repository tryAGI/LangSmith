
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Input provided to a code evaluator.
    /// </summary>
    public enum CodeEvaluatorInputType
    {
        /// <summary>
        ///
        /// </summary>
        AllMessages,
        /// <summary>
        ///
        /// </summary>
        FirstHumanLastAi,
        /// <summary>
        ///
        /// </summary>
        HumanAiPairs,
        /// <summary>
        ///
        /// </summary>
        Thread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeEvaluatorInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeEvaluatorInputType value)
        {
            return value switch
            {
                CodeEvaluatorInputType.AllMessages => "all_messages",
                CodeEvaluatorInputType.FirstHumanLastAi => "first_human_last_ai",
                CodeEvaluatorInputType.HumanAiPairs => "human_ai_pairs",
                CodeEvaluatorInputType.Thread => "thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeEvaluatorInputType? ToEnum(string value)
        {
            return value switch
            {
                "all_messages" => CodeEvaluatorInputType.AllMessages,
                "first_human_last_ai" => CodeEvaluatorInputType.FirstHumanLastAi,
                "human_ai_pairs" => CodeEvaluatorInputType.HumanAiPairs,
                "thread" => CodeEvaluatorInputType.Thread,
                _ => null,
            };
        }
    }
}