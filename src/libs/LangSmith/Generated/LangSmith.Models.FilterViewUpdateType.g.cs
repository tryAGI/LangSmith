
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum FilterViewUpdateType
    {
        /// <summary>
        ///
        /// </summary>
        Runs,
        /// <summary>
        ///
        /// </summary>
        SingleRun,
        /// <summary>
        ///
        /// </summary>
        Threads,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterViewUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterViewUpdateType value)
        {
            return value switch
            {
                FilterViewUpdateType.Runs => "runs",
                FilterViewUpdateType.SingleRun => "single_run",
                FilterViewUpdateType.Threads => "threads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterViewUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "runs" => FilterViewUpdateType.Runs,
                "single_run" => FilterViewUpdateType.SingleRun,
                "threads" => FilterViewUpdateType.Threads,
                _ => null,
            };
        }
    }
}