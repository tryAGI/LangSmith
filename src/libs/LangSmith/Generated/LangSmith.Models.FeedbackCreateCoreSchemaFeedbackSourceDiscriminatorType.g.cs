
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType
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
    public static class FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType value)
        {
            return value switch
            {
                FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType.Api => "api",
                FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType.App => "app",
                FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType.AutoEval => "auto_eval",
                FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api" => FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType.Api,
                "app" => FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType.App,
                "auto_eval" => FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType.AutoEval,
                "model" => FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType.Model,
                _ => null,
            };
        }
    }
}