
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType
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
    public static class FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType value)
        {
            return value switch
            {
                FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.Api => "api",
                FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.App => "app",
                FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.AutoEval => "auto_eval",
                FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api" => FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.Api,
                "app" => FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.App,
                "auto_eval" => FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.AutoEval,
                "model" => FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.Model,
                _ => null,
            };
        }
    }
}