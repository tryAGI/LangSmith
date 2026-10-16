
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput
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
    public static class EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput value)
        {
            return value switch
            {
                EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput.AllMessages => "all_messages",
                EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput.FirstHumanLastAi => "first_human_last_ai",
                EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput.HumanAiPairs => "human_ai_pairs",
                EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput.Thread => "thread",
                EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput.Trajectory => "trajectory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput? ToEnum(string value)
        {
            return value switch
            {
                "all_messages" => EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput.AllMessages,
                "first_human_last_ai" => EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput.FirstHumanLastAi,
                "human_ai_pairs" => EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput.HumanAiPairs,
                "thread" => EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput.Thread,
                "trajectory" => EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput.Trajectory,
                _ => null,
            };
        }
    }
}