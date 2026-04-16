
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item
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
    public static class ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item value)
        {
            return value switch
            {
                ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item.Agent => "agent",
                ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item.File => "file",
                ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item.Prompt => "prompt",
                ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item.Agent,
                "file" => ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item.File,
                "prompt" => ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item.Prompt,
                "skill" => ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item.Skill,
                _ => null,
            };
        }
    }
}