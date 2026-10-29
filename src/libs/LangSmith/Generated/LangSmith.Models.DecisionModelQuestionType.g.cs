
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// noul: a yes/no question scored 0 to 1. choice: one of the options. score: one of the levels, scored by position.
    /// </summary>
    public enum DecisionModelQuestionType
    {
        /// <summary>
        /// a yes/no question scored 0 to 1. choice: one of the options. score: one of the levels, scored by position.
        /// </summary>
        Choice,
        /// <summary>
        /// a yes/no question scored 0 to 1. choice: one of the options. score: one of the levels, scored by position.
        /// </summary>
        Noul,
        /// <summary>
        /// a yes/no question scored 0 to 1. choice: one of the options. score: one of the levels, scored by position.
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionModelQuestionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionModelQuestionType value)
        {
            return value switch
            {
                DecisionModelQuestionType.Choice => "choice",
                DecisionModelQuestionType.Noul => "noul",
                DecisionModelQuestionType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionModelQuestionType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => DecisionModelQuestionType.Choice,
                "noul" => DecisionModelQuestionType.Noul,
                "score" => DecisionModelQuestionType.Score,
                _ => null,
            };
        }
    }
}