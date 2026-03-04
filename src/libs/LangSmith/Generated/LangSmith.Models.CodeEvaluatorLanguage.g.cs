
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
        Python,
        /// <summary>
        /// 
        /// </summary>
        Javascript,
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
                CodeEvaluatorLanguage.Python => "python",
                CodeEvaluatorLanguage.Javascript => "javascript",
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
                "python" => CodeEvaluatorLanguage.Python,
                "javascript" => CodeEvaluatorLanguage.Javascript,
                _ => null,
            };
        }
    }
}