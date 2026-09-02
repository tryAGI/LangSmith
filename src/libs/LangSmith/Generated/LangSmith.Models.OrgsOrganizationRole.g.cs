
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum OrgsOrganizationRole
    {
        /// <summary>
        ///
        /// </summary>
        OrganizationRoleAdmin,
        /// <summary>
        ///
        /// </summary>
        OrganizationRoleOperator,
        /// <summary>
        ///
        /// </summary>
        OrganizationRoleRestricted,
        /// <summary>
        ///
        /// </summary>
        OrganizationRoleUser,
        /// <summary>
        ///
        /// </summary>
        OrganizationRoleViewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsOrganizationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsOrganizationRole value)
        {
            return value switch
            {
                OrgsOrganizationRole.OrganizationRoleAdmin => "ORGANIZATION_ADMIN",
                OrgsOrganizationRole.OrganizationRoleOperator => "ORGANIZATION_OPERATOR",
                OrgsOrganizationRole.OrganizationRoleRestricted => "ORGANIZATION_RESTRICTED",
                OrgsOrganizationRole.OrganizationRoleUser => "ORGANIZATION_USER",
                OrgsOrganizationRole.OrganizationRoleViewer => "ORGANIZATION_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsOrganizationRole? ToEnum(string value)
        {
            return value switch
            {
                "ORGANIZATION_ADMIN" => OrgsOrganizationRole.OrganizationRoleAdmin,
                "ORGANIZATION_OPERATOR" => OrgsOrganizationRole.OrganizationRoleOperator,
                "ORGANIZATION_RESTRICTED" => OrgsOrganizationRole.OrganizationRoleRestricted,
                "ORGANIZATION_USER" => OrgsOrganizationRole.OrganizationRoleUser,
                "ORGANIZATION_VIEWER" => OrgsOrganizationRole.OrganizationRoleViewer,
                _ => null,
            };
        }
    }
}