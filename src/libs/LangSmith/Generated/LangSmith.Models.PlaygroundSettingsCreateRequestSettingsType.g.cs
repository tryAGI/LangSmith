
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: complex
    /// </summary>
    public enum PlaygroundSettingsCreateRequestSettingsType
    {
        /// <summary>
        /// 
        /// </summary>
        Complex,
        /// <summary>
        /// 
        /// </summary>
        Simple,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaygroundSettingsCreateRequestSettingsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundSettingsCreateRequestSettingsType value)
        {
            return value switch
            {
                PlaygroundSettingsCreateRequestSettingsType.Complex => "complex",
                PlaygroundSettingsCreateRequestSettingsType.Simple => "simple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundSettingsCreateRequestSettingsType? ToEnum(string value)
        {
            return value switch
            {
                "complex" => PlaygroundSettingsCreateRequestSettingsType.Complex,
                "simple" => PlaygroundSettingsCreateRequestSettingsType.Simple,
                _ => null,
            };
        }
    }
}