
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsSelect
    {
        /// <summary>
        /// 
        /// </summary>
        ExampleCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDatasetsSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsSelect value)
        {
            return value switch
            {
                GetDatasetsSelect.ExampleCount => "example_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsSelect? ToEnum(string value)
        {
            return value switch
            {
                "example_count" => GetDatasetsSelect.ExampleCount,
                _ => null,
            };
        }
    }
}