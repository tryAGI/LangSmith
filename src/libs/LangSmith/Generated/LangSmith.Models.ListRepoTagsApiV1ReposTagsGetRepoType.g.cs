
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRepoTagsApiV1ReposTagsGetRepoType
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
    public static class ListRepoTagsApiV1ReposTagsGetRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepoTagsApiV1ReposTagsGetRepoType value)
        {
            return value switch
            {
                ListRepoTagsApiV1ReposTagsGetRepoType.Prompt => "prompt",
                ListRepoTagsApiV1ReposTagsGetRepoType.File => "file",
                ListRepoTagsApiV1ReposTagsGetRepoType.Agent => "agent",
                ListRepoTagsApiV1ReposTagsGetRepoType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepoTagsApiV1ReposTagsGetRepoType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => ListRepoTagsApiV1ReposTagsGetRepoType.Prompt,
                "file" => ListRepoTagsApiV1ReposTagsGetRepoType.File,
                "agent" => ListRepoTagsApiV1ReposTagsGetRepoType.Agent,
                "skill" => ListRepoTagsApiV1ReposTagsGetRepoType.Skill,
                _ => null,
            };
        }
    }
}