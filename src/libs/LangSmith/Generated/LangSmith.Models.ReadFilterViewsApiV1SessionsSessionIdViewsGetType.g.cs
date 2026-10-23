
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ReadFilterViewsApiV1SessionsSessionIdViewsGetType
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
    public static class ReadFilterViewsApiV1SessionsSessionIdViewsGetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadFilterViewsApiV1SessionsSessionIdViewsGetType value)
        {
            return value switch
            {
                ReadFilterViewsApiV1SessionsSessionIdViewsGetType.Runs => "runs",
                ReadFilterViewsApiV1SessionsSessionIdViewsGetType.SingleRun => "single_run",
                ReadFilterViewsApiV1SessionsSessionIdViewsGetType.Threads => "threads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadFilterViewsApiV1SessionsSessionIdViewsGetType? ToEnum(string value)
        {
            return value switch
            {
                "runs" => ReadFilterViewsApiV1SessionsSessionIdViewsGetType.Runs,
                "single_run" => ReadFilterViewsApiV1SessionsSessionIdViewsGetType.SingleRun,
                "threads" => ReadFilterViewsApiV1SessionsSessionIdViewsGetType.Threads,
                _ => null,
            };
        }
    }
}