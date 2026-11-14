
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Feedback level: run for feedback on a run, session for feedback on a whole tracing project (session level requires a session filter).
    /// </summary>
    public enum FeedbackLevel
    {
        /// <summary>
        /// run for feedback on a run, session for feedback on a whole tracing project (session level requires a session filter).
        /// </summary>
        Run,
        /// <summary>
        /// run for feedback on a run, session for feedback on a whole tracing project (session level requires a session filter).
        /// </summary>
        Session,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackLevel value)
        {
            return value switch
            {
                FeedbackLevel.Run => "run",
                FeedbackLevel.Session => "session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackLevel? ToEnum(string value)
        {
            return value switch
            {
                "run" => FeedbackLevel.Run,
                "session" => FeedbackLevel.Session,
                _ => null,
            };
        }
    }
}