
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Sort fields for members list endpoints.
    /// </summary>
    public enum MemberSortField
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Role,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemberSortFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemberSortField value)
        {
            return value switch
            {
                MemberSortField.CreatedAt => "created_at",
                MemberSortField.Email => "email",
                MemberSortField.Name => "name",
                MemberSortField.Role => "role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemberSortField? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => MemberSortField.CreatedAt,
                "email" => MemberSortField.Email,
                "name" => MemberSortField.Name,
                "role" => MemberSortField.Role,
                _ => null,
            };
        }
    }
}