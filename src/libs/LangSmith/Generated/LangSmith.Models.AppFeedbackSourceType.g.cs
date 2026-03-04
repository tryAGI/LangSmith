
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: app
    /// </summary>
    public enum AppFeedbackSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppFeedbackSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppFeedbackSourceType value)
        {
            return value switch
            {
                AppFeedbackSourceType.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppFeedbackSourceType? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppFeedbackSourceType.App,
                _ => null,
            };
        }
    }
}