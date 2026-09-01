
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DirectoryAgentEntryOutputType
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectoryAgentEntryOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectoryAgentEntryOutputType value)
        {
            return value switch
            {
                DirectoryAgentEntryOutputType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectoryAgentEntryOutputType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => DirectoryAgentEntryOutputType.Agent,
                _ => null,
            };
        }
    }
}