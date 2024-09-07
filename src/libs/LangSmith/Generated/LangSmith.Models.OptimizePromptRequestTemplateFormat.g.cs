
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum OptimizePromptRequestTemplateFormat
    {
        /// <summary>
        /// 
        /// </summary>
        FString,
        /// <summary>
        /// 
        /// </summary>
        Mustache,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OptimizePromptRequestTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OptimizePromptRequestTemplateFormat value)
        {
            return value switch
            {
                OptimizePromptRequestTemplateFormat.FString => "f-string",
                OptimizePromptRequestTemplateFormat.Mustache => "mustache",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OptimizePromptRequestTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => OptimizePromptRequestTemplateFormat.FString,
                "mustache" => OptimizePromptRequestTemplateFormat.Mustache,
                _ => null,
            };
        }
    }
}