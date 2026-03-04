
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListReposApiV1ReposGetRepoType
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
    public static class ListReposApiV1ReposGetRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetRepoType value)
        {
            return value switch
            {
                ListReposApiV1ReposGetRepoType.Prompt => "prompt",
                ListReposApiV1ReposGetRepoType.File => "file",
                ListReposApiV1ReposGetRepoType.Agent => "agent",
                ListReposApiV1ReposGetRepoType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetRepoType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => ListReposApiV1ReposGetRepoType.Prompt,
                "file" => ListReposApiV1ReposGetRepoType.File,
                "agent" => ListReposApiV1ReposGetRepoType.Agent,
                "skill" => ListReposApiV1ReposGetRepoType.Skill,
                _ => null,
            };
        }
    }
}