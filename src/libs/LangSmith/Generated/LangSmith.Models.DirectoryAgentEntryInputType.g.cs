
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DirectoryAgentEntryInputType
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectoryAgentEntryInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectoryAgentEntryInputType value)
        {
            return value switch
            {
                DirectoryAgentEntryInputType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectoryAgentEntryInputType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => DirectoryAgentEntryInputType.Agent,
                _ => null,
            };
        }
    }
}