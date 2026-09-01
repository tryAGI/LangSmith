
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DirectorySkillEntryOutputType
    {
        /// <summary>
        ///
        /// </summary>
        Skill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectorySkillEntryOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectorySkillEntryOutputType value)
        {
            return value switch
            {
                DirectorySkillEntryOutputType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectorySkillEntryOutputType? ToEnum(string value)
        {
            return value switch
            {
                "skill" => DirectorySkillEntryOutputType.Skill,
                _ => null,
            };
        }
    }
}