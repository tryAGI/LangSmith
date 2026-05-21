
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThreadsThreadStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Busy,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Idle,
        /// <summary>
        /// 
        /// </summary>
        Interrupted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadsThreadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadsThreadStatus value)
        {
            return value switch
            {
                ThreadsThreadStatus.Busy => "busy",
                ThreadsThreadStatus.Error => "error",
                ThreadsThreadStatus.Idle => "idle",
                ThreadsThreadStatus.Interrupted => "interrupted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadsThreadStatus? ToEnum(string value)
        {
            return value switch
            {
                "busy" => ThreadsThreadStatus.Busy,
                "error" => ThreadsThreadStatus.Error,
                "idle" => ThreadsThreadStatus.Idle,
                "interrupted" => ThreadsThreadStatus.Interrupted,
                _ => null,
            };
        }
    }
}