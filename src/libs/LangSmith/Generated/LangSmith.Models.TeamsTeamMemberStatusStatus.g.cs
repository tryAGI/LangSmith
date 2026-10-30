
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamsTeamMemberStatusStatus
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
    public static class TeamsTeamMemberStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsTeamMemberStatusStatus value)
        {
            return value switch
            {
                TeamsTeamMemberStatusStatus.Created => "CREATED",
                TeamsTeamMemberStatusStatus.Failed => "FAILED",
                TeamsTeamMemberStatusStatus.Unchanged => "UNCHANGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsTeamMemberStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => TeamsTeamMemberStatusStatus.Created,
                "FAILED" => TeamsTeamMemberStatusStatus.Failed,
                "UNCHANGED" => TeamsTeamMemberStatusStatus.Unchanged,
                _ => null,
            };
        }
    }
}