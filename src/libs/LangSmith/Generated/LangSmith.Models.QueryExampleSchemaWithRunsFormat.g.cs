
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryExampleSchemaWithRunsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryExampleSchemaWithRunsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryExampleSchemaWithRunsFormat value)
        {
            return value switch
            {
                QueryExampleSchemaWithRunsFormat.Csv => "csv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryExampleSchemaWithRunsFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => QueryExampleSchemaWithRunsFormat.Csv,
                _ => null,
            };
        }
    }
}