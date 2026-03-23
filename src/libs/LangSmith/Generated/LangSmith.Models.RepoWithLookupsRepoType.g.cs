
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoWithLookupsRepoType
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
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Skill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoWithLookupsRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoWithLookupsRepoType value)
        {
            return value switch
            {
                RepoWithLookupsRepoType.Agent => "agent",
                RepoWithLookupsRepoType.File => "file",
                RepoWithLookupsRepoType.Prompt => "prompt",
                RepoWithLookupsRepoType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoWithLookupsRepoType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => RepoWithLookupsRepoType.Agent,
                "file" => RepoWithLookupsRepoType.File,
                "prompt" => RepoWithLookupsRepoType.Prompt,
                "skill" => RepoWithLookupsRepoType.Skill,
                _ => null,
            };
        }
    }
}