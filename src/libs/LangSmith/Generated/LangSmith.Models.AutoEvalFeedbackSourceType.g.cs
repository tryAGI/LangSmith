
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: auto_eval
    /// </summary>
    public enum AutoEvalFeedbackSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        AutoEval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoEvalFeedbackSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoEvalFeedbackSourceType value)
        {
            return value switch
            {
                AutoEvalFeedbackSourceType.AutoEval => "auto_eval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoEvalFeedbackSourceType? ToEnum(string value)
        {
            return value switch
            {
                "auto_eval" => AutoEvalFeedbackSourceType.AutoEval,
                _ => null,
            };
        }
    }
}