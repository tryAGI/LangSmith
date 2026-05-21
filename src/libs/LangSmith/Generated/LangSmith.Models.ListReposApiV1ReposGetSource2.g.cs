
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListReposApiV1ReposGetSource2
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
    public static class ListReposApiV1ReposGetSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListReposApiV1ReposGetSource2 value)
        {
            return value switch
            {
                ListReposApiV1ReposGetSource2.External => "external",
                ListReposApiV1ReposGetSource2.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListReposApiV1ReposGetSource2? ToEnum(string value)
        {
            return value switch
            {
                "external" => ListReposApiV1ReposGetSource2.External,
                "internal" => ListReposApiV1ReposGetSource2.Internal,
                _ => null,
            };
        }
    }
}