
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListReposApiV1ReposGetRepoType2
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
    public static class ListReposApiV1ReposGetRepoType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetRepoType2 value)
        {
            return value switch
            {
                ListReposApiV1ReposGetRepoType2.Prompt => "prompt",
                ListReposApiV1ReposGetRepoType2.File => "file",
                ListReposApiV1ReposGetRepoType2.Agent => "agent",
                ListReposApiV1ReposGetRepoType2.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetRepoType2? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => ListReposApiV1ReposGetRepoType2.Prompt,
                "file" => ListReposApiV1ReposGetRepoType2.File,
                "agent" => ListReposApiV1ReposGetRepoType2.Agent,
                "skill" => ListReposApiV1ReposGetRepoType2.Skill,
                _ => null,
            };
        }
    }
}