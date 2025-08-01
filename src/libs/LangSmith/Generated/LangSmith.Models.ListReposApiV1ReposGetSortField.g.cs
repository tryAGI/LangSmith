
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListReposApiV1ReposGetSortField
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
    public static class ListReposApiV1ReposGetSortFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetSortField value)
        {
            return value switch
            {
                ListReposApiV1ReposGetSortField.NumLikes => "num_likes",
                ListReposApiV1ReposGetSortField.NumDownloads => "num_downloads",
                ListReposApiV1ReposGetSortField.NumViews => "num_views",
                ListReposApiV1ReposGetSortField.UpdatedAt => "updated_at",
                ListReposApiV1ReposGetSortField.Relevance => "relevance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetSortField? ToEnum(string value)
        {
            return value switch
            {
                "num_likes" => ListReposApiV1ReposGetSortField.NumLikes,
                "num_downloads" => ListReposApiV1ReposGetSortField.NumDownloads,
                "num_views" => ListReposApiV1ReposGetSortField.NumViews,
                "updated_at" => ListReposApiV1ReposGetSortField.UpdatedAt,
                "relevance" => ListReposApiV1ReposGetSortField.Relevance,
                _ => null,
            };
        }
    }
}