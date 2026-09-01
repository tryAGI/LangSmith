
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DirectorySkillEntryInputType
    {
        /// <summary>
        ///
        /// </summary>
        Skill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectorySkillEntryInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectorySkillEntryInputType value)
        {
            return value switch
            {
                DirectorySkillEntryInputType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectorySkillEntryInputType? ToEnum(string value)
        {
            return value switch
            {
                "skill" => DirectorySkillEntryInputType.Skill,
                _ => null,
            };
        }
    }
}