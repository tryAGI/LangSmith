
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThreadsCreateThreadRequestIfExists
    {
        /// <summary>
        /// 
        /// </summary>
        DoNothing,
        /// <summary>
        /// 
        /// </summary>
        Raise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadsCreateThreadRequestIfExistsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadsCreateThreadRequestIfExists value)
        {
            return value switch
            {
                ThreadsCreateThreadRequestIfExists.DoNothing => "do_nothing",
                ThreadsCreateThreadRequestIfExists.Raise => "raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadsCreateThreadRequestIfExists? ToEnum(string value)
        {
            return value switch
            {
                "do_nothing" => ThreadsCreateThreadRequestIfExists.DoNothing,
                "raise" => ThreadsCreateThreadRequestIfExists.Raise,
                _ => null,
            };
        }
    }
}