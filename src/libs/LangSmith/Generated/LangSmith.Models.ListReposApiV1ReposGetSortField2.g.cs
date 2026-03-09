
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListReposApiV1ReposGetSortField2
    {
        /// <summary>
        /// 
        /// </summary>
        NumLikes,
        /// <summary>
        /// 
        /// </summary>
        NumDownloads,
        /// <summary>
        /// 
        /// </summary>
        NumViews,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
        /// <summary>
        /// 
        /// </summary>
        Relevance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListReposApiV1ReposGetSortField2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetSortField2 value)
        {
            return value switch
            {
                ListReposApiV1ReposGetSortField2.NumLikes => "num_likes",
                ListReposApiV1ReposGetSortField2.NumDownloads => "num_downloads",
                ListReposApiV1ReposGetSortField2.NumViews => "num_views",
                ListReposApiV1ReposGetSortField2.UpdatedAt => "updated_at",
                ListReposApiV1ReposGetSortField2.Relevance => "relevance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetSortField2? ToEnum(string value)
        {
            return value switch
            {
                "num_likes" => ListReposApiV1ReposGetSortField2.NumLikes,
                "num_downloads" => ListReposApiV1ReposGetSortField2.NumDownloads,
                "num_views" => ListReposApiV1ReposGetSortField2.NumViews,
                "updated_at" => ListReposApiV1ReposGetSortField2.UpdatedAt,
                "relevance" => ListReposApiV1ReposGetSortField2.Relevance,
                _ => null,
            };
        }
    }
}