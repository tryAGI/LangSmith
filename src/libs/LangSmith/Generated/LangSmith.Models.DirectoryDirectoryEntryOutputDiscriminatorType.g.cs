
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DirectoryDirectoryEntryOutputDiscriminatorType
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
    public static class DirectoryDirectoryEntryOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectoryDirectoryEntryOutputDiscriminatorType value)
        {
            return value switch
            {
                DirectoryDirectoryEntryOutputDiscriminatorType.Agent => "agent",
                DirectoryDirectoryEntryOutputDiscriminatorType.File => "file",
                DirectoryDirectoryEntryOutputDiscriminatorType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectoryDirectoryEntryOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => DirectoryDirectoryEntryOutputDiscriminatorType.Agent,
                "file" => DirectoryDirectoryEntryOutputDiscriminatorType.File,
                "skill" => DirectoryDirectoryEntryOutputDiscriminatorType.Skill,
                _ => null,
            };
        }
    }
}