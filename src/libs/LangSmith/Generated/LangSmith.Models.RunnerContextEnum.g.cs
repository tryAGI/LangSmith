
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunnerContextEnum
    {
        /// <summary>
        /// 
        /// </summary>
        LangsmithUi,
        /// <summary>
        /// 
        /// </summary>
        LangsmithAlignEvals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunnerContextEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunnerContextEnum value)
        {
            return value switch
            {
                RunnerContextEnum.LangsmithUi => "langsmith_ui",
                RunnerContextEnum.LangsmithAlignEvals => "langsmith_align_evals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunnerContextEnum? ToEnum(string value)
        {
            return value switch
            {
                "langsmith_ui" => RunnerContextEnum.LangsmithUi,
                "langsmith_align_evals" => RunnerContextEnum.LangsmithAlignEvals,
                _ => null,
            };
        }
    }
}