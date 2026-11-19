
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPlatformAnnotationQueuesItemsCountAgreement
    {
        /// <summary>
        ///
        /// </summary>
        Disagreed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPlatformAnnotationQueuesItemsCountAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlatformAnnotationQueuesItemsCountAgreement value)
        {
            return value switch
            {
                GetPlatformAnnotationQueuesItemsCountAgreement.Disagreed => "disagreed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlatformAnnotationQueuesItemsCountAgreement? ToEnum(string value)
        {
            return value switch
            {
                "disagreed" => GetPlatformAnnotationQueuesItemsCountAgreement.Disagreed,
                _ => null,
            };
        }
    }
}