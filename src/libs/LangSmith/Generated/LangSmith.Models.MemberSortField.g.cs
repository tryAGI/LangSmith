
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
        Name,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Role,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
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
                MemberSortField.Name => "name",
                MemberSortField.Email => "email",
                MemberSortField.Role => "role",
                MemberSortField.CreatedAt => "created_at",
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
                "name" => MemberSortField.Name,
                "email" => MemberSortField.Email,
                "role" => MemberSortField.Role,
                "created_at" => MemberSortField.CreatedAt,
                _ => null,
            };
        }
    }
}