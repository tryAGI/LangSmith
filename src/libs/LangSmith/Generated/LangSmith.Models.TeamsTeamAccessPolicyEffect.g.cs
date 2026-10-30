
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamsTeamAccessPolicyEffect
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
    public static class TeamsTeamAccessPolicyEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsTeamAccessPolicyEffect value)
        {
            return value switch
            {
                TeamsTeamAccessPolicyEffect.Allow => "allow",
                TeamsTeamAccessPolicyEffect.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsTeamAccessPolicyEffect? ToEnum(string value)
        {
            return value switch
            {
                "allow" => TeamsTeamAccessPolicyEffect.Allow,
                "deny" => TeamsTeamAccessPolicyEffect.Deny,
                _ => null,
            };
        }
    }
}