
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// `PRIMARY` for recorded feedback, `COMPOSITE` for a score computed from other feedback keys.
    /// </summary>
    public enum SessionFeedbackStatType
    {
        /// <summary>
        ///
        /// </summary>
        Composite,
        /// <summary>
        ///
        /// </summary>
        Primary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionFeedbackStatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionFeedbackStatType value)
        {
            return value switch
            {
                SessionFeedbackStatType.Composite => "COMPOSITE",
                SessionFeedbackStatType.Primary => "PRIMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionFeedbackStatType? ToEnum(string value)
        {
            return value switch
            {
                "COMPOSITE" => SessionFeedbackStatType.Composite,
                "PRIMARY" => SessionFeedbackStatType.Primary,
                _ => null,
            };
        }
    }
}