
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SqlqueryQueryResponseTruncationReason
    {
        /// <summary>
        ///
        /// </summary>
        RowLimit,
        /// <summary>
        ///
        /// </summary>
        SizeLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SqlqueryQueryResponseTruncationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SqlqueryQueryResponseTruncationReason value)
        {
            return value switch
            {
                SqlqueryQueryResponseTruncationReason.RowLimit => "row_limit",
                SqlqueryQueryResponseTruncationReason.SizeLimit => "size_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SqlqueryQueryResponseTruncationReason? ToEnum(string value)
        {
            return value switch
            {
                "row_limit" => SqlqueryQueryResponseTruncationReason.RowLimit,
                "size_limit" => SqlqueryQueryResponseTruncationReason.SizeLimit,
                _ => null,
            };
        }
    }
}