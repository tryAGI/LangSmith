
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
    public static class TypesFeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypesFeedbackType value)
        {
            return value switch
            {
                TypesFeedbackType.Continuous => "continuous",
                TypesFeedbackType.Categorical => "categorical",
                TypesFeedbackType.Freeform => "freeform",
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
                "continuous" => TypesFeedbackType.Continuous,
                "categorical" => TypesFeedbackType.Categorical,
                "freeform" => TypesFeedbackType.Freeform,
                _ => null,
            };
        }
    }
}