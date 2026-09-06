
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateRepoRequestSource
    {
        /// <summary>
        ///
        /// </summary>
        External,
        /// <summary>
        ///
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRepoRequestSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRepoRequestSource value)
        {
            return value switch
            {
                CreateRepoRequestSource.External => "external",
                CreateRepoRequestSource.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRepoRequestSource? ToEnum(string value)
        {
            return value switch
            {
                "external" => CreateRepoRequestSource.External,
                "internal" => CreateRepoRequestSource.Internal,
                _ => null,
            };
        }
    }
}