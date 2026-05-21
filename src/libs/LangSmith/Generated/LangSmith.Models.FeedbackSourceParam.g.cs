
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackSourceParam
    {
        /// <summary>
        /// 
        /// </summary>
        Run,
        /// <summary>
        /// 
        /// </summary>
        Session,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackSourceParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackSourceParam value)
        {
            return value switch
            {
                FeedbackSourceParam.Run => "run",
                FeedbackSourceParam.Session => "session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackSourceParam? ToEnum(string value)
        {
            return value switch
            {
                "run" => FeedbackSourceParam.Run,
                "session" => FeedbackSourceParam.Session,
                _ => null,
            };
        }
    }
}