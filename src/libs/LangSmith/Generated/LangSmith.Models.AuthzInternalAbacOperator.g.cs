
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
        AbacOperatorEqualsIfExists,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorEqualsIgnoreCase,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorEqualsIgnoreCaseIfExists,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorMatches,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorMatchesIfExists,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorNotEquals,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorNotEqualsIfExists,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorNotEqualsIgnoreCase,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorNotEqualsIgnoreCaseIfExists,
        /// <summary>
        /// 
        /// </summary>
        AbacOperatorNotMatches,
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
                AuthzInternalAbacOperator.AbacOperatorEqualsIfExists => "equals_if_exists",
                AuthzInternalAbacOperator.AbacOperatorEqualsIgnoreCase => "equals_ignore_case",
                AuthzInternalAbacOperator.AbacOperatorEqualsIgnoreCaseIfExists => "equals_ignore_case_if_exists",
                AuthzInternalAbacOperator.AbacOperatorMatches => "matches",
                AuthzInternalAbacOperator.AbacOperatorMatchesIfExists => "matches_if_exists",
                AuthzInternalAbacOperator.AbacOperatorNotEquals => "not_equals",
                AuthzInternalAbacOperator.AbacOperatorNotEqualsIfExists => "not_equals_if_exists",
                AuthzInternalAbacOperator.AbacOperatorNotEqualsIgnoreCase => "not_equals_ignore_case",
                AuthzInternalAbacOperator.AbacOperatorNotEqualsIgnoreCaseIfExists => "not_equals_ignore_case_if_exists",
                AuthzInternalAbacOperator.AbacOperatorNotMatches => "not_matches",
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
                "equals_if_exists" => AuthzInternalAbacOperator.AbacOperatorEqualsIfExists,
                "equals_ignore_case" => AuthzInternalAbacOperator.AbacOperatorEqualsIgnoreCase,
                "equals_ignore_case_if_exists" => AuthzInternalAbacOperator.AbacOperatorEqualsIgnoreCaseIfExists,
                "matches" => AuthzInternalAbacOperator.AbacOperatorMatches,
                "matches_if_exists" => AuthzInternalAbacOperator.AbacOperatorMatchesIfExists,
                "not_equals" => AuthzInternalAbacOperator.AbacOperatorNotEquals,
                "not_equals_if_exists" => AuthzInternalAbacOperator.AbacOperatorNotEqualsIfExists,
                "not_equals_ignore_case" => AuthzInternalAbacOperator.AbacOperatorNotEqualsIgnoreCase,
                "not_equals_ignore_case_if_exists" => AuthzInternalAbacOperator.AbacOperatorNotEqualsIgnoreCaseIfExists,
                "not_matches" => AuthzInternalAbacOperator.AbacOperatorNotMatches,
                "not_matches_if_exists" => AuthzInternalAbacOperator.AbacOperatorNotMatchesIfExists,
                _ => null,
            };
        }
    }
}