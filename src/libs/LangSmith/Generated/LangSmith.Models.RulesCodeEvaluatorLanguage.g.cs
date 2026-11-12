
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RulesCodeEvaluatorLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Javascript,
        /// <summary>
        ///
        /// </summary>
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RulesCodeEvaluatorLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RulesCodeEvaluatorLanguage value)
        {
            return value switch
            {
                RulesCodeEvaluatorLanguage.Javascript => "JAVASCRIPT",
                RulesCodeEvaluatorLanguage.Python => "PYTHON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RulesCodeEvaluatorLanguage? ToEnum(string value)
        {
            return value switch
            {
                "JAVASCRIPT" => RulesCodeEvaluatorLanguage.Javascript,
                "PYTHON" => RulesCodeEvaluatorLanguage.Python,
                _ => null,
            };
        }
    }
}