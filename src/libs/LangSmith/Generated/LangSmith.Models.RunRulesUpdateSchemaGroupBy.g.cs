
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RunRulesUpdateSchemaGroupBy
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
    public static class RunRulesUpdateSchemaGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunRulesUpdateSchemaGroupBy value)
        {
            return value switch
            {
                RunRulesUpdateSchemaGroupBy.ThreadId => "thread_id",
                RunRulesUpdateSchemaGroupBy.TrajectoryId => "trajectory_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunRulesUpdateSchemaGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "thread_id" => RunRulesUpdateSchemaGroupBy.ThreadId,
                "trajectory_id" => RunRulesUpdateSchemaGroupBy.TrajectoryId,
                _ => null,
            };
        }
    }
}