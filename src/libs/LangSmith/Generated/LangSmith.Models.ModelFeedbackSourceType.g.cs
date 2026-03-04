
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: model
    /// </summary>
    public enum ModelFeedbackSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelFeedbackSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelFeedbackSourceType value)
        {
            return value switch
            {
                ModelFeedbackSourceType.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelFeedbackSourceType? ToEnum(string value)
        {
            return value switch
            {
                "model" => ModelFeedbackSourceType.Model,
                _ => null,
            };
        }
    }
}