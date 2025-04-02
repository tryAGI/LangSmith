
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunsSearchCursorDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Lt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunsSearchCursorDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunsSearchCursorDirection value)
        {
            return value switch
            {
                RunsSearchCursorDirection.Gt => "gt",
                RunsSearchCursorDirection.Lt => "lt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunsSearchCursorDirection? ToEnum(string value)
        {
            return value switch
            {
                "gt" => RunsSearchCursorDirection.Gt,
                "lt" => RunsSearchCursorDirection.Lt,
                _ => null,
            };
        }
    }
}