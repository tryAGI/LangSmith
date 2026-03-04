
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: api
    /// </summary>
    public enum APIFeedbackSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class APIFeedbackSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APIFeedbackSourceType value)
        {
            return value switch
            {
                APIFeedbackSourceType.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APIFeedbackSourceType? ToEnum(string value)
        {
            return value switch
            {
                "api" => APIFeedbackSourceType.Api,
                _ => null,
            };
        }
    }
}