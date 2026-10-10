
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// The event name.
    /// </summary>
    public enum SharedSSEEventEvent
    {
        /// <summary>
        ///
        /// </summary>
        Data,
        /// <summary>
        ///
        /// </summary>
        End,
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SharedSSEEventEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SharedSSEEventEvent value)
        {
            return value switch
            {
                SharedSSEEventEvent.Data => "data",
                SharedSSEEventEvent.End => "end",
                SharedSSEEventEvent.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SharedSSEEventEvent? ToEnum(string value)
        {
            return value switch
            {
                "data" => SharedSSEEventEvent.Data,
                "end" => SharedSSEEventEvent.End,
                "error" => SharedSSEEventEvent.Error,
                _ => null,
            };
        }
    }
}