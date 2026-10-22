
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentsSourceType
    {
        /// <summary>
        ///
        /// </summary>
        External,
        /// <summary>
        ///
        /// </summary>
        Fleet,
        /// <summary>
        ///
        /// </summary>
        Lsd,
        /// <summary>
        ///
        /// </summary>
        Mda,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentsSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentsSourceType value)
        {
            return value switch
            {
                GetAgentsSourceType.External => "EXTERNAL",
                GetAgentsSourceType.Fleet => "FLEET",
                GetAgentsSourceType.Lsd => "LSD",
                GetAgentsSourceType.Mda => "MDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentsSourceType? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => GetAgentsSourceType.External,
                "FLEET" => GetAgentsSourceType.Fleet,
                "LSD" => GetAgentsSourceType.Lsd,
                "MDA" => GetAgentsSourceType.Mda,
                _ => null,
            };
        }
    }
}