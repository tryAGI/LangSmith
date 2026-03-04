
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunRulesSchemaGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunRulesSchemaGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunRulesSchemaGroupBy value)
        {
            return value switch
            {
                RunRulesSchemaGroupBy.ThreadId => "thread_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunRulesSchemaGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "thread_id" => RunRulesSchemaGroupBy.ThreadId,
                _ => null,
            };
        }
    }
}