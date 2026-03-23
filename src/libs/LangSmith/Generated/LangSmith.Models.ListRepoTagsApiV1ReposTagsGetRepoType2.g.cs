
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRepoTagsApiV1ReposTagsGetRepoType2
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
    public static class ListRepoTagsApiV1ReposTagsGetRepoType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepoTagsApiV1ReposTagsGetRepoType2 value)
        {
            return value switch
            {
                ListRepoTagsApiV1ReposTagsGetRepoType2.Agent => "agent",
                ListRepoTagsApiV1ReposTagsGetRepoType2.File => "file",
                ListRepoTagsApiV1ReposTagsGetRepoType2.Prompt => "prompt",
                ListRepoTagsApiV1ReposTagsGetRepoType2.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepoTagsApiV1ReposTagsGetRepoType2? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ListRepoTagsApiV1ReposTagsGetRepoType2.Agent,
                "file" => ListRepoTagsApiV1ReposTagsGetRepoType2.File,
                "prompt" => ListRepoTagsApiV1ReposTagsGetRepoType2.Prompt,
                "skill" => ListRepoTagsApiV1ReposTagsGetRepoType2.Skill,
                _ => null,
            };
        }
    }
}