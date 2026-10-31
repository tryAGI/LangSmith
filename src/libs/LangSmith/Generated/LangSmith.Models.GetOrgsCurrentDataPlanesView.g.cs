
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: FULL
    /// </summary>
    public enum GetOrgsCurrentDataPlanesView
    {
        /// <summary>
        ///
        /// </summary>
        Full,
        /// <summary>
        ///
        /// </summary>
        Summary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrgsCurrentDataPlanesViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrgsCurrentDataPlanesView value)
        {
            return value switch
            {
                GetOrgsCurrentDataPlanesView.Full => "FULL",
                GetOrgsCurrentDataPlanesView.Summary => "SUMMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrgsCurrentDataPlanesView? ToEnum(string value)
        {
            return value switch
            {
                "FULL" => GetOrgsCurrentDataPlanesView.Full,
                "SUMMARY" => GetOrgsCurrentDataPlanesView.Summary,
                _ => null,
            };
        }
    }
}