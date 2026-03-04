
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: prompt
    /// </summary>
    public enum CreateRepoRequestRepoType
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        Skill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRepoRequestRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRepoRequestRepoType value)
        {
            return value switch
            {
                CreateRepoRequestRepoType.Prompt => "prompt",
                CreateRepoRequestRepoType.File => "file",
                CreateRepoRequestRepoType.Agent => "agent",
                CreateRepoRequestRepoType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRepoRequestRepoType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => CreateRepoRequestRepoType.Prompt,
                "file" => CreateRepoRequestRepoType.File,
                "agent" => CreateRepoRequestRepoType.Agent,
                "skill" => CreateRepoRequestRepoType.Skill,
                _ => null,
            };
        }
    }
}