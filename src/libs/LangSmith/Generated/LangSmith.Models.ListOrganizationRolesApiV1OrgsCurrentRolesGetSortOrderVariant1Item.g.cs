
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item value)
        {
            return value switch
            {
                ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item.Asc => "asc",
                ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item.Asc,
                "desc" => ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item.Desc,
                _ => null,
            };
        }
    }
}