
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum BulkExportRunMetadataExecutionBackend
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
    public static class BulkExportRunMetadataExecutionBackendExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportRunMetadataExecutionBackend value)
        {
            return value switch
            {
                BulkExportRunMetadataExecutionBackend.Clickhouse => "clickhouse",
                BulkExportRunMetadataExecutionBackend.Smithdb => "smithdb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportRunMetadataExecutionBackend? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => BulkExportRunMetadataExecutionBackend.Clickhouse,
                "smithdb" => BulkExportRunMetadataExecutionBackend.Smithdb,
                _ => null,
            };
        }
    }
}