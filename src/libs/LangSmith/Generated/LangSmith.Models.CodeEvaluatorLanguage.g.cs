
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeEvaluatorLanguage
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
    public static class CodeEvaluatorLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeEvaluatorLanguage value)
        {
            return value switch
            {
                CodeEvaluatorLanguage.Javascript => "javascript",
                CodeEvaluatorLanguage.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeEvaluatorLanguage? ToEnum(string value)
        {
            return value switch
            {
                "javascript" => CodeEvaluatorLanguage.Javascript,
                "python" => CodeEvaluatorLanguage.Python,
                _ => null,
            };
        }
    }
}