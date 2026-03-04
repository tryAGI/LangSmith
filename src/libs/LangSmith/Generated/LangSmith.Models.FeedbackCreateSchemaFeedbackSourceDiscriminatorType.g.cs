
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackCreateSchemaFeedbackSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        AutoEval,
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackCreateSchemaFeedbackSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackCreateSchemaFeedbackSourceDiscriminatorType value)
        {
            return value switch
            {
                FeedbackCreateSchemaFeedbackSourceDiscriminatorType.Api => "api",
                FeedbackCreateSchemaFeedbackSourceDiscriminatorType.App => "app",
                FeedbackCreateSchemaFeedbackSourceDiscriminatorType.AutoEval => "auto_eval",
                FeedbackCreateSchemaFeedbackSourceDiscriminatorType.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackCreateSchemaFeedbackSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api" => FeedbackCreateSchemaFeedbackSourceDiscriminatorType.Api,
                "app" => FeedbackCreateSchemaFeedbackSourceDiscriminatorType.App,
                "auto_eval" => FeedbackCreateSchemaFeedbackSourceDiscriminatorType.AutoEval,
                "model" => FeedbackCreateSchemaFeedbackSourceDiscriminatorType.Model,
                _ => null,
            };
        }
    }
}