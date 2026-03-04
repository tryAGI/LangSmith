
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunRulesCreateSchemaGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunRulesCreateSchemaGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunRulesCreateSchemaGroupBy value)
        {
            return value switch
            {
                RunRulesCreateSchemaGroupBy.ThreadId => "thread_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunRulesCreateSchemaGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "thread_id" => RunRulesCreateSchemaGroupBy.ThreadId,
                _ => null,
            };
        }
    }
}