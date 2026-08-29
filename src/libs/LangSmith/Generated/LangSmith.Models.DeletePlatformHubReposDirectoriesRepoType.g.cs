
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DeletePlatformHubReposDirectoriesRepoType
    {
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
    public static class DeletePlatformHubReposDirectoriesRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletePlatformHubReposDirectoriesRepoType value)
        {
            return value switch
            {
                DeletePlatformHubReposDirectoriesRepoType.Agent => "agent",
                DeletePlatformHubReposDirectoriesRepoType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletePlatformHubReposDirectoriesRepoType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => DeletePlatformHubReposDirectoriesRepoType.Agent,
                "skill" => DeletePlatformHubReposDirectoriesRepoType.Skill,
                _ => null,
            };
        }
    }
}