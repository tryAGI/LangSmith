
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
        FeedbackTypeContinuous,
        /// <summary>
        /// 
        /// </summary>
        FeedbackTypeCategorical,
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
                TypesFeedbackType.FeedbackTypeContinuous => "continuous",
                TypesFeedbackType.FeedbackTypeCategorical => "categorical",
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
                "continuous" => TypesFeedbackType.FeedbackTypeContinuous,
                "categorical" => TypesFeedbackType.FeedbackTypeCategorical,
                "freeform" => TypesFeedbackType.FeedbackTypeFreeform,
                _ => null,
            };
        }
    }
}