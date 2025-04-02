
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum RunSearchRequestOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunSearchRequestOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunSearchRequestOrder value)
        {
            return value switch
            {
                RunSearchRequestOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunSearchRequestOrder? ToEnum(string value)
        {
            return value switch
            {
                "desc" => RunSearchRequestOrder.Desc,
                _ => null,
            };
        }
    }
}