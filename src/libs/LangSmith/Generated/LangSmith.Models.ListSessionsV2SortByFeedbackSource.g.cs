
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ListSessionsV2SortByFeedbackSource
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
    public static class ListSessionsV2SortByFeedbackSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSessionsV2SortByFeedbackSource value)
        {
            return value switch
            {
                ListSessionsV2SortByFeedbackSource.Run => "RUN",
                ListSessionsV2SortByFeedbackSource.Session => "SESSION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSessionsV2SortByFeedbackSource? ToEnum(string value)
        {
            return value switch
            {
                "RUN" => ListSessionsV2SortByFeedbackSource.Run,
                "SESSION" => ListSessionsV2SortByFeedbackSource.Session,
                _ => null,
            };
        }
    }
}