
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentsInclude
    {
        /// <summary>
        ///
        /// </summary>
        RuntimeBindings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentsIncludeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentsInclude value)
        {
            return value switch
            {
                GetAgentsInclude.RuntimeBindings => "runtime_bindings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentsInclude? ToEnum(string value)
        {
            return value switch
            {
                "runtime_bindings" => GetAgentsInclude.RuntimeBindings,
                _ => null,
            };
        }
    }
}