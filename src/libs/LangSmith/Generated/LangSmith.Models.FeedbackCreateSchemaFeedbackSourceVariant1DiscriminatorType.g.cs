
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType
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
    public static class FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType value)
        {
            return value switch
            {
                FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType.Api => "api",
                FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType.App => "app",
                FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType.AutoEval => "auto_eval",
                FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api" => FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType.Api,
                "app" => FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType.App,
                "auto_eval" => FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType.AutoEval,
                "model" => FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType.Model,
                _ => null,
            };
        }
    }
}