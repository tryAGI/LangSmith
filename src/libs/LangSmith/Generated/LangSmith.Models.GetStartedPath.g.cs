
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetStartedPath
    {
        /// <summary>
        ///
        /// </summary>
        Build,
        /// <summary>
        ///
        /// </summary>
        Connect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetStartedPathExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStartedPath value)
        {
            return value switch
            {
                GetStartedPath.Build => "BUILD",
                GetStartedPath.Connect => "CONNECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStartedPath? ToEnum(string value)
        {
            return value switch
            {
                "BUILD" => GetStartedPath.Build,
                "CONNECT" => GetStartedPath.Connect,
                _ => null,
            };
        }
    }
}