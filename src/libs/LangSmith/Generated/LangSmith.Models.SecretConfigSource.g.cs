
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Whether a secret config comes from the built-in catalog or an admin.
    /// </summary>
    public enum SecretConfigSource
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretConfigSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretConfigSource value)
        {
            return value switch
            {
                SecretConfigSource.Custom => "CUSTOM",
                SecretConfigSource.Default => "DEFAULT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretConfigSource? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM" => SecretConfigSource.Custom,
                "DEFAULT" => SecretConfigSource.Default,
                _ => null,
            };
        }
    }
}