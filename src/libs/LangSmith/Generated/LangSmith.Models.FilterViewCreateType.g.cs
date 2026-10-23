
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: runs
    /// </summary>
    public enum FilterViewCreateType
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
    public static class FilterViewCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterViewCreateType value)
        {
            return value switch
            {
                FilterViewCreateType.Runs => "runs",
                FilterViewCreateType.SingleRun => "single_run",
                FilterViewCreateType.Threads => "threads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterViewCreateType? ToEnum(string value)
        {
            return value switch
            {
                "runs" => FilterViewCreateType.Runs,
                "single_run" => FilterViewCreateType.SingleRun,
                "threads" => FilterViewCreateType.Threads,
                _ => null,
            };
        }
    }
}