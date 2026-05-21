
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThreadsCreateThreadAndRunThreadIfExists
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
    public static class ThreadsCreateThreadAndRunThreadIfExistsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadsCreateThreadAndRunThreadIfExists value)
        {
            return value switch
            {
                ThreadsCreateThreadAndRunThreadIfExists.DoNothing => "do_nothing",
                ThreadsCreateThreadAndRunThreadIfExists.Raise => "raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadsCreateThreadAndRunThreadIfExists? ToEnum(string value)
        {
            return value switch
            {
                "do_nothing" => ThreadsCreateThreadAndRunThreadIfExists.DoNothing,
                "raise" => ThreadsCreateThreadAndRunThreadIfExists.Raise,
                _ => null,
            };
        }
    }
}