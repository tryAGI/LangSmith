
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RepoWithLookupsSource
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
    public static class RepoWithLookupsSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoWithLookupsSource value)
        {
            return value switch
            {
                RepoWithLookupsSource.External => "external",
                RepoWithLookupsSource.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoWithLookupsSource? ToEnum(string value)
        {
            return value switch
            {
                "external" => RepoWithLookupsSource.External,
                "internal" => RepoWithLookupsSource.Internal,
                _ => null,
            };
        }
    }
}