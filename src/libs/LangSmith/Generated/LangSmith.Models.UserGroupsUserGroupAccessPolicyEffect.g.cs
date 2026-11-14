
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum UserGroupsUserGroupAccessPolicyEffect
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserGroupsUserGroupAccessPolicyEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserGroupsUserGroupAccessPolicyEffect value)
        {
            return value switch
            {
                UserGroupsUserGroupAccessPolicyEffect.Allow => "allow",
                UserGroupsUserGroupAccessPolicyEffect.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserGroupsUserGroupAccessPolicyEffect? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UserGroupsUserGroupAccessPolicyEffect.Allow,
                "deny" => UserGroupsUserGroupAccessPolicyEffect.Deny,
                _ => null,
            };
        }
    }
}