
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Skill discriminator. Only `inline` is supported today.<br/>
    /// Example: inline
    /// </summary>
    public enum AgentsSkillSpecType
    {
        /// <summary>
        /// 
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsSkillSpecTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSkillSpecType value)
        {
            return value switch
            {
                AgentsSkillSpecType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSkillSpecType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => AgentsSkillSpecType.Inline,
                _ => null,
            };
        }
    }
}