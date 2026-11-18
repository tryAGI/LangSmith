
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        DisplayName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item value)
        {
            return value switch
            {
                ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item.CreatedAt => "created_at",
                ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item.DisplayName => "display_name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item.CreatedAt,
                "display_name" => ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item.DisplayName,
                _ => null,
            };
        }
    }
}