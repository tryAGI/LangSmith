
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkExportStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        IntervalScheduled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkExportStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportStatus value)
        {
            return value switch
            {
                BulkExportStatus.Cancelled => "Cancelled",
                BulkExportStatus.Completed => "Completed",
                BulkExportStatus.Created => "Created",
                BulkExportStatus.IntervalScheduled => "IntervalScheduled",
                BulkExportStatus.Failed => "Failed",
                BulkExportStatus.TimedOut => "TimedOut",
                BulkExportStatus.Running => "Running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportStatus? ToEnum(string value)
        {
            return value switch
            {
                "Cancelled" => BulkExportStatus.Cancelled,
                "Completed" => BulkExportStatus.Completed,
                "Created" => BulkExportStatus.Created,
                "IntervalScheduled" => BulkExportStatus.IntervalScheduled,
                "Failed" => BulkExportStatus.Failed,
                "TimedOut" => BulkExportStatus.TimedOut,
                "Running" => BulkExportStatus.Running,
                _ => null,
            };
        }
    }
}