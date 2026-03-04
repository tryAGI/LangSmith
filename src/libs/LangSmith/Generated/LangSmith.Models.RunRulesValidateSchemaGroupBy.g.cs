
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunRulesValidateSchemaGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunRulesValidateSchemaGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunRulesValidateSchemaGroupBy value)
        {
            return value switch
            {
                RunRulesValidateSchemaGroupBy.ThreadId => "thread_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunRulesValidateSchemaGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "thread_id" => RunRulesValidateSchemaGroupBy.ThreadId,
                _ => null,
            };
        }
    }
}