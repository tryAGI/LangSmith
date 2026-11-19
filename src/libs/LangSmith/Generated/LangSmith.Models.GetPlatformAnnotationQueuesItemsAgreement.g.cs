
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPlatformAnnotationQueuesItemsAgreement
    {
        /// <summary>
        ///
        /// </summary>
        Disagreed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPlatformAnnotationQueuesItemsAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlatformAnnotationQueuesItemsAgreement value)
        {
            return value switch
            {
                GetPlatformAnnotationQueuesItemsAgreement.Disagreed => "disagreed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlatformAnnotationQueuesItemsAgreement? ToEnum(string value)
        {
            return value switch
            {
                "disagreed" => GetPlatformAnnotationQueuesItemsAgreement.Disagreed,
                _ => null,
            };
        }
    }
}