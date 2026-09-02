
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationRoles
    {
        /// <summary>
        ///
        /// </summary>
        OrganizationAdmin,
        /// <summary>
        ///
        /// </summary>
        OrganizationOperator,
        /// <summary>
        ///
        /// </summary>
        OrganizationRestricted,
        /// <summary>
        ///
        /// </summary>
        OrganizationUser,
        /// <summary>
        ///
        /// </summary>
        OrganizationViewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationRolesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationRoles value)
        {
            return value switch
            {
                OrganizationRoles.OrganizationAdmin => "ORGANIZATION_ADMIN",
                OrganizationRoles.OrganizationOperator => "ORGANIZATION_OPERATOR",
                OrganizationRoles.OrganizationRestricted => "ORGANIZATION_RESTRICTED",
                OrganizationRoles.OrganizationUser => "ORGANIZATION_USER",
                OrganizationRoles.OrganizationViewer => "ORGANIZATION_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationRoles? ToEnum(string value)
        {
            return value switch
            {
                "ORGANIZATION_ADMIN" => OrganizationRoles.OrganizationAdmin,
                "ORGANIZATION_OPERATOR" => OrganizationRoles.OrganizationOperator,
                "ORGANIZATION_RESTRICTED" => OrganizationRoles.OrganizationRestricted,
                "ORGANIZATION_USER" => OrganizationRoles.OrganizationUser,
                "ORGANIZATION_VIEWER" => OrganizationRoles.OrganizationViewer,
                _ => null,
            };
        }
    }
}