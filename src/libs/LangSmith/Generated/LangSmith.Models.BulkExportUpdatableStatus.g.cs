
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkExportUpdatableStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkExportUpdatableStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportUpdatableStatus value)
        {
            return value switch
            {
                BulkExportUpdatableStatus.Cancelled => "Cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportUpdatableStatus? ToEnum(string value)
        {
            return value switch
            {
                "Cancelled" => BulkExportUpdatableStatus.Cancelled,
                _ => null,
            };
        }
    }
}