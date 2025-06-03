
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackFeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        Continuous,
        /// <summary>
        /// 
        /// </summary>
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        Freeform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackFeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackFeedbackType value)
        {
            return value switch
            {
                FeedbackFeedbackType.Continuous => "continuous",
                FeedbackFeedbackType.Categorical => "categorical",
                FeedbackFeedbackType.Freeform => "freeform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackFeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "continuous" => FeedbackFeedbackType.Continuous,
                "categorical" => FeedbackFeedbackType.Categorical,
                "freeform" => FeedbackFeedbackType.Freeform,
                _ => null,
            };
        }
    }
}