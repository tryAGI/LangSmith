
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum TypesFeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        FeedbackTypeCategorical,
        /// <summary>
        /// 
        /// </summary>
        FeedbackTypeContinuous,
        /// <summary>
        /// 
        /// </summary>
        FeedbackTypeFreeform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TypesFeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypesFeedbackType value)
        {
            return value switch
            {
                TypesFeedbackType.FeedbackTypeCategorical => "categorical",
                TypesFeedbackType.FeedbackTypeContinuous => "continuous",
                TypesFeedbackType.FeedbackTypeFreeform => "freeform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypesFeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "categorical" => TypesFeedbackType.FeedbackTypeCategorical,
                "continuous" => TypesFeedbackType.FeedbackTypeContinuous,
                "freeform" => TypesFeedbackType.FeedbackTypeFreeform,
                _ => null,
            };
        }
    }
}