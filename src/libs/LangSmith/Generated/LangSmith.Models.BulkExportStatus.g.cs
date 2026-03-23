
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
        Failed,
        /// <summary>
        /// 
        /// </summary>
        IntervalScheduled,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
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
                BulkExportStatus.Failed => "Failed",
                BulkExportStatus.IntervalScheduled => "IntervalScheduled",
                BulkExportStatus.Running => "Running",
                BulkExportStatus.TimedOut => "TimedOut",
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
                "Failed" => BulkExportStatus.Failed,
                "IntervalScheduled" => BulkExportStatus.IntervalScheduled,
                "Running" => BulkExportStatus.Running,
                "TimedOut" => BulkExportStatus.TimedOut,
                _ => null,
            };
        }
    }
}