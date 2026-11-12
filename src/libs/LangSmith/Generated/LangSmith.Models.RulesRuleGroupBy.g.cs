
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RulesRuleGroupBy
    {
        /// <summary>
        ///
        /// </summary>
        ThreadId,
        /// <summary>
        ///
        /// </summary>
        TrajectoryId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RulesRuleGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RulesRuleGroupBy value)
        {
            return value switch
            {
                RulesRuleGroupBy.ThreadId => "THREAD_ID",
                RulesRuleGroupBy.TrajectoryId => "TRAJECTORY_ID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RulesRuleGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "THREAD_ID" => RulesRuleGroupBy.ThreadId,
                "TRAJECTORY_ID" => RulesRuleGroupBy.TrajectoryId,
                _ => null,
            };
        }
    }
}