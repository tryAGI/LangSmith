
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RulesCodeEvaluatorCodeEvaluatorInput
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
        /// <summary>
        ///
        /// </summary>
        Trajectory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RulesCodeEvaluatorCodeEvaluatorInputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RulesCodeEvaluatorCodeEvaluatorInput value)
        {
            return value switch
            {
                RulesCodeEvaluatorCodeEvaluatorInput.AllMessages => "ALL_MESSAGES",
                RulesCodeEvaluatorCodeEvaluatorInput.FirstHumanLastAi => "FIRST_HUMAN_LAST_AI",
                RulesCodeEvaluatorCodeEvaluatorInput.HumanAiPairs => "HUMAN_AI_PAIRS",
                RulesCodeEvaluatorCodeEvaluatorInput.Thread => "THREAD",
                RulesCodeEvaluatorCodeEvaluatorInput.Trajectory => "TRAJECTORY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RulesCodeEvaluatorCodeEvaluatorInput? ToEnum(string value)
        {
            return value switch
            {
                "ALL_MESSAGES" => RulesCodeEvaluatorCodeEvaluatorInput.AllMessages,
                "FIRST_HUMAN_LAST_AI" => RulesCodeEvaluatorCodeEvaluatorInput.FirstHumanLastAi,
                "HUMAN_AI_PAIRS" => RulesCodeEvaluatorCodeEvaluatorInput.HumanAiPairs,
                "THREAD" => RulesCodeEvaluatorCodeEvaluatorInput.Thread,
                "TRAJECTORY" => RulesCodeEvaluatorCodeEvaluatorInput.Trajectory,
                _ => null,
            };
        }
    }
}