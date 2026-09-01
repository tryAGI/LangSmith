
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DirectoryDirectoryEntryInputDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        File,
        /// <summary>
        ///
        /// </summary>
        Skill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectoryDirectoryEntryInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectoryDirectoryEntryInputDiscriminatorType value)
        {
            return value switch
            {
                DirectoryDirectoryEntryInputDiscriminatorType.Agent => "agent",
                DirectoryDirectoryEntryInputDiscriminatorType.File => "file",
                DirectoryDirectoryEntryInputDiscriminatorType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectoryDirectoryEntryInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => DirectoryDirectoryEntryInputDiscriminatorType.Agent,
                "file" => DirectoryDirectoryEntryInputDiscriminatorType.File,
                "skill" => DirectoryDirectoryEntryInputDiscriminatorType.Skill,
                _ => null,
            };
        }
    }
}