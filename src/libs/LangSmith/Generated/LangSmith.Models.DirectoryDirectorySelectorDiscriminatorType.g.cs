
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DirectoryDirectorySelectorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Commit,
        /// <summary>
        ///
        /// </summary>
        Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectoryDirectorySelectorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectoryDirectorySelectorDiscriminatorType value)
        {
            return value switch
            {
                DirectoryDirectorySelectorDiscriminatorType.Commit => "COMMIT",
                DirectoryDirectorySelectorDiscriminatorType.Latest => "LATEST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectoryDirectorySelectorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "COMMIT" => DirectoryDirectorySelectorDiscriminatorType.Commit,
                "LATEST" => DirectoryDirectorySelectorDiscriminatorType.Latest,
                _ => null,
            };
        }
    }
}