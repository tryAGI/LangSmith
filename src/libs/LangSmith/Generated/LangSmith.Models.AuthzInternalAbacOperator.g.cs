
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthzInternalAbacOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Equals,
        /// <summary>
        /// 
        /// </summary>
        NotEquals,
        /// <summary>
        /// 
        /// </summary>
        EqualsIgnoreCase,
        /// <summary>
        /// 
        /// </summary>
        NotEqualsIgnoreCase,
        /// <summary>
        /// 
        /// </summary>
        Matches,
        /// <summary>
        /// 
        /// </summary>
        NotMatches,
        /// <summary>
        /// 
        /// </summary>
        EqualsIfExists,
        /// <summary>
        /// 
        /// </summary>
        NotEqualsIfExists,
        /// <summary>
        /// 
        /// </summary>
        EqualsIgnoreCaseIfExists,
        /// <summary>
        /// 
        /// </summary>
        NotEqualsIgnoreCaseIfExists,
        /// <summary>
        /// 
        /// </summary>
        MatchesIfExists,
        /// <summary>
        /// 
        /// </summary>
        NotMatchesIfExists,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthzInternalAbacOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthzInternalAbacOperator value)
        {
            return value switch
            {
                AuthzInternalAbacOperator.Equals => "equals",
                AuthzInternalAbacOperator.NotEquals => "not_equals",
                AuthzInternalAbacOperator.EqualsIgnoreCase => "equals_ignore_case",
                AuthzInternalAbacOperator.NotEqualsIgnoreCase => "not_equals_ignore_case",
                AuthzInternalAbacOperator.Matches => "matches",
                AuthzInternalAbacOperator.NotMatches => "not_matches",
                AuthzInternalAbacOperator.EqualsIfExists => "equals_if_exists",
                AuthzInternalAbacOperator.NotEqualsIfExists => "not_equals_if_exists",
                AuthzInternalAbacOperator.EqualsIgnoreCaseIfExists => "equals_ignore_case_if_exists",
                AuthzInternalAbacOperator.NotEqualsIgnoreCaseIfExists => "not_equals_ignore_case_if_exists",
                AuthzInternalAbacOperator.MatchesIfExists => "matches_if_exists",
                AuthzInternalAbacOperator.NotMatchesIfExists => "not_matches_if_exists",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthzInternalAbacOperator? ToEnum(string value)
        {
            return value switch
            {
                "equals" => AuthzInternalAbacOperator.Equals,
                "not_equals" => AuthzInternalAbacOperator.NotEquals,
                "equals_ignore_case" => AuthzInternalAbacOperator.EqualsIgnoreCase,
                "not_equals_ignore_case" => AuthzInternalAbacOperator.NotEqualsIgnoreCase,
                "matches" => AuthzInternalAbacOperator.Matches,
                "not_matches" => AuthzInternalAbacOperator.NotMatches,
                "equals_if_exists" => AuthzInternalAbacOperator.EqualsIfExists,
                "not_equals_if_exists" => AuthzInternalAbacOperator.NotEqualsIfExists,
                "equals_ignore_case_if_exists" => AuthzInternalAbacOperator.EqualsIgnoreCaseIfExists,
                "not_equals_ignore_case_if_exists" => AuthzInternalAbacOperator.NotEqualsIgnoreCaseIfExists,
                "matches_if_exists" => AuthzInternalAbacOperator.MatchesIfExists,
                "not_matches_if_exists" => AuthzInternalAbacOperator.NotMatchesIfExists,
                _ => null,
            };
        }
    }
}