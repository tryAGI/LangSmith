
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Enum for bulk export format versions.
    /// </summary>
    public enum BulkExportFormatVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2Beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkExportFormatVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportFormatVersion value)
        {
            return value switch
            {
                BulkExportFormatVersion.V1 => "v1",
                BulkExportFormatVersion.V2Beta => "v2_beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportFormatVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => BulkExportFormatVersion.V1,
                "v2_beta" => BulkExportFormatVersion.V2Beta,
                _ => null,
            };
        }
    }
}