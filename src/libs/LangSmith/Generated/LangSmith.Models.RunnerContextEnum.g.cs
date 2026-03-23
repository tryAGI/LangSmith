
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
        LangsmithAlignEvals,
        /// <summary>
        /// 
        /// </summary>
        LangsmithUi,
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
                RunnerContextEnum.LangsmithAlignEvals => "langsmith_align_evals",
                RunnerContextEnum.LangsmithUi => "langsmith_ui",
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
                "langsmith_align_evals" => RunnerContextEnum.LangsmithAlignEvals,
                "langsmith_ui" => RunnerContextEnum.LangsmithUi,
                _ => null,
            };
        }
    }
}