
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkExportCompression
    {
        /// <summary>
        /// 
        /// </summary>
        Gzip,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Snappy,
        /// <summary>
        /// 
        /// </summary>
        Zstandard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkExportCompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportCompression value)
        {
            return value switch
            {
                BulkExportCompression.Gzip => "gzip",
                BulkExportCompression.None => "none",
                BulkExportCompression.Snappy => "snappy",
                BulkExportCompression.Zstandard => "zstandard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportCompression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => BulkExportCompression.Gzip,
                "none" => BulkExportCompression.None,
                "snappy" => BulkExportCompression.Snappy,
                "zstandard" => BulkExportCompression.Zstandard,
                _ => null,
            };
        }
    }
}