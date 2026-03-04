
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterViewType
    {
        /// <summary>
        /// 
        /// </summary>
        Runs,
        /// <summary>
        /// 
        /// </summary>
        Threads,
        /// <summary>
        /// 
        /// </summary>
        SingleRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterViewType value)
        {
            return value switch
            {
                FilterViewType.Runs => "runs",
                FilterViewType.Threads => "threads",
                FilterViewType.SingleRun => "single_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterViewType? ToEnum(string value)
        {
            return value switch
            {
                "runs" => FilterViewType.Runs,
                "threads" => FilterViewType.Threads,
                "single_run" => FilterViewType.SingleRun,
                _ => null,
            };
        }
    }
}