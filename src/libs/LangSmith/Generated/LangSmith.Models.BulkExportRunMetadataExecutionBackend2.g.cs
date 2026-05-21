
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkExportRunMetadataExecutionBackend2
    {
        /// <summary>
        /// 
        /// </summary>
        Clickhouse,
        /// <summary>
        /// 
        /// </summary>
        Smithdb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkExportRunMetadataExecutionBackend2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportRunMetadataExecutionBackend2 value)
        {
            return value switch
            {
                BulkExportRunMetadataExecutionBackend2.Clickhouse => "clickhouse",
                BulkExportRunMetadataExecutionBackend2.Smithdb => "smithdb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportRunMetadataExecutionBackend2? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => BulkExportRunMetadataExecutionBackend2.Clickhouse,
                "smithdb" => BulkExportRunMetadataExecutionBackend2.Smithdb,
                _ => null,
            };
        }
    }
}