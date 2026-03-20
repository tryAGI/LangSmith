
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
        AbacOperatorEquals,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorNotEquals,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorEqualsIgnoreCase,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorNotEqualsIgnoreCase,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorMatches,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorNotMatches,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorEqualsIfExists,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorNotEqualsIfExists,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorEqualsIgnoreCaseIfExists,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorNotEqualsIgnoreCaseIfExists,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorMatchesIfExists,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorNotMatchesIfExists,
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
                AuthzInternalAbacOperator.AbacOperatorEquals => "equals",
                AuthzInternalAbacOperator.AbacOperatorNotEquals => "not_equals",
                AuthzInternalAbacOperator.AbacOperatorEqualsIgnoreCase => "equals_ignore_case",
                AuthzInternalAbacOperator.AbacOperatorNotEqualsIgnoreCase => "not_equals_ignore_case",
                AuthzInternalAbacOperator.AbacOperatorMatches => "matches",
                AuthzInternalAbacOperator.AbacOperatorNotMatches => "not_matches",
                AuthzInternalAbacOperator.AbacOperatorEqualsIfExists => "equals_if_exists",
                AuthzInternalAbacOperator.AbacOperatorNotEqualsIfExists => "not_equals_if_exists",
                AuthzInternalAbacOperator.AbacOperatorEqualsIgnoreCaseIfExists => "equals_ignore_case_if_exists",
                AuthzInternalAbacOperator.AbacOperatorNotEqualsIgnoreCaseIfExists => "not_equals_ignore_case_if_exists",
                AuthzInternalAbacOperator.AbacOperatorMatchesIfExists => "matches_if_exists",
                AuthzInternalAbacOperator.AbacOperatorNotMatchesIfExists => "not_matches_if_exists",
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
                "equals" => AuthzInternalAbacOperator.AbacOperatorEquals,
                "not_equals" => AuthzInternalAbacOperator.AbacOperatorNotEquals,
                "equals_ignore_case" => AuthzInternalAbacOperator.AbacOperatorEqualsIgnoreCase,
                "not_equals_ignore_case" => AuthzInternalAbacOperator.AbacOperatorNotEqualsIgnoreCase,
                "matches" => AuthzInternalAbacOperator.AbacOperatorMatches,
                "not_matches" => AuthzInternalAbacOperator.AbacOperatorNotMatches,
                "equals_if_exists" => AuthzInternalAbacOperator.AbacOperatorEqualsIfExists,
                "not_equals_if_exists" => AuthzInternalAbacOperator.AbacOperatorNotEqualsIfExists,
                "equals_ignore_case_if_exists" => AuthzInternalAbacOperator.AbacOperatorEqualsIgnoreCaseIfExists,
                "not_equals_ignore_case_if_exists" => AuthzInternalAbacOperator.AbacOperatorNotEqualsIgnoreCaseIfExists,
                "matches_if_exists" => AuthzInternalAbacOperator.AbacOperatorMatchesIfExists,
                "not_matches_if_exists" => AuthzInternalAbacOperator.AbacOperatorNotMatchesIfExists,
                _ => null,
            };
        }
    }
}