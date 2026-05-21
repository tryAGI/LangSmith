
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRepoRequestSource2
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
    public static class CreateRepoRequestSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRepoRequestSource2 value)
        {
            return value switch
            {
                CreateRepoRequestSource2.External => "external",
                CreateRepoRequestSource2.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRepoRequestSource2? ToEnum(string value)
        {
            return value switch
            {
                "external" => CreateRepoRequestSource2.External,
                "internal" => CreateRepoRequestSource2.Internal,
                _ => null,
            };
        }
    }
}