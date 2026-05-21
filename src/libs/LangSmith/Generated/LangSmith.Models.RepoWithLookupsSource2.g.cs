
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoWithLookupsSource2
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
    public static class RepoWithLookupsSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoWithLookupsSource2 value)
        {
            return value switch
            {
                RepoWithLookupsSource2.External => "external",
                RepoWithLookupsSource2.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoWithLookupsSource2? ToEnum(string value)
        {
            return value switch
            {
                "external" => RepoWithLookupsSource2.External,
                "internal" => RepoWithLookupsSource2.Internal,
                _ => null,
            };
        }
    }
}