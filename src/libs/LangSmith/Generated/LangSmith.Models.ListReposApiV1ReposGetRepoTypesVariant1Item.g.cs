
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListReposApiV1ReposGetRepoTypesVariant1Item
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
    public static class ListReposApiV1ReposGetRepoTypesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetRepoTypesVariant1Item value)
        {
            return value switch
            {
                ListReposApiV1ReposGetRepoTypesVariant1Item.Agent => "agent",
                ListReposApiV1ReposGetRepoTypesVariant1Item.File => "file",
                ListReposApiV1ReposGetRepoTypesVariant1Item.Prompt => "prompt",
                ListReposApiV1ReposGetRepoTypesVariant1Item.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetRepoTypesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ListReposApiV1ReposGetRepoTypesVariant1Item.Agent,
                "file" => ListReposApiV1ReposGetRepoTypesVariant1Item.File,
                "prompt" => ListReposApiV1ReposGetRepoTypesVariant1Item.Prompt,
                "skill" => ListReposApiV1ReposGetRepoTypesVariant1Item.Skill,
                _ => null,
            };
        }
    }
}