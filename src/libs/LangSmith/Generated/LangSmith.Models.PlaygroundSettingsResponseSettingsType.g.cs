
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: complex
    /// </summary>
    public enum PlaygroundSettingsResponseSettingsType
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
    public static class PlaygroundSettingsResponseSettingsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundSettingsResponseSettingsType value)
        {
            return value switch
            {
                PlaygroundSettingsResponseSettingsType.Complex => "complex",
                PlaygroundSettingsResponseSettingsType.Simple => "simple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundSettingsResponseSettingsType? ToEnum(string value)
        {
            return value switch
            {
                "complex" => PlaygroundSettingsResponseSettingsType.Complex,
                "simple" => PlaygroundSettingsResponseSettingsType.Simple,
                _ => null,
            };
        }
    }
}