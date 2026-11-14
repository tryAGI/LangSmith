
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum UserGroupsUserGroupMemberStatusStatus
    {
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Unchanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserGroupsUserGroupMemberStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserGroupsUserGroupMemberStatusStatus value)
        {
            return value switch
            {
                UserGroupsUserGroupMemberStatusStatus.Created => "CREATED",
                UserGroupsUserGroupMemberStatusStatus.Failed => "FAILED",
                UserGroupsUserGroupMemberStatusStatus.Unchanged => "UNCHANGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserGroupsUserGroupMemberStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => UserGroupsUserGroupMemberStatusStatus.Created,
                "FAILED" => UserGroupsUserGroupMemberStatusStatus.Failed,
                "UNCHANGED" => UserGroupsUserGroupMemberStatusStatus.Unchanged,
                _ => null,
            };
        }
    }
}