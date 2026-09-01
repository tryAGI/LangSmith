
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DirectoryLatestSelectorType
    {
        /// <summary>
        ///
        /// </summary>
        Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectoryLatestSelectorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectoryLatestSelectorType value)
        {
            return value switch
            {
                DirectoryLatestSelectorType.Latest => "LATEST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectoryLatestSelectorType? ToEnum(string value)
        {
            return value switch
            {
                "LATEST" => DirectoryLatestSelectorType.Latest,
                _ => null,
            };
        }
    }
}