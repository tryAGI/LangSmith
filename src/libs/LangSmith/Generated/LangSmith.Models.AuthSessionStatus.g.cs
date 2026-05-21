
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthSessionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        SessionStatusCompleted,
        /// <summary>
        /// 
        /// </summary>
        SessionStatusConnectionRequired,
        /// <summary>
        /// 
        /// </summary>
        SessionStatusPending,
        /// <summary>
        /// 
        /// </summary>
        SessionStatusTokenExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthSessionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthSessionStatus value)
        {
            return value switch
            {
                AuthSessionStatus.SessionStatusCompleted => "COMPLETED",
                AuthSessionStatus.SessionStatusConnectionRequired => "CONNECTION_REQUIRED",
                AuthSessionStatus.SessionStatusPending => "PENDING",
                AuthSessionStatus.SessionStatusTokenExpired => "TOKEN_EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthSessionStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => AuthSessionStatus.SessionStatusCompleted,
                "CONNECTION_REQUIRED" => AuthSessionStatus.SessionStatusConnectionRequired,
                "PENDING" => AuthSessionStatus.SessionStatusPending,
                "TOKEN_EXPIRED" => AuthSessionStatus.SessionStatusTokenExpired,
                _ => null,
            };
        }
    }
}