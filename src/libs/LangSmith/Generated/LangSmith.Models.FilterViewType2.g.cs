
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum FilterViewType2
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
    public static class FilterViewType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterViewType2 value)
        {
            return value switch
            {
                FilterViewType2.Runs => "runs",
                FilterViewType2.SingleRun => "single_run",
                FilterViewType2.Threads => "threads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterViewType2? ToEnum(string value)
        {
            return value switch
            {
                "runs" => FilterViewType2.Runs,
                "single_run" => FilterViewType2.SingleRun,
                "threads" => FilterViewType2.Threads,
                _ => null,
            };
        }
    }
}