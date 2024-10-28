
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundOptimizePromptRequestSchemaTemplateFormat
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
    public static class PlaygroundOptimizePromptRequestSchemaTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundOptimizePromptRequestSchemaTemplateFormat value)
        {
            return value switch
            {
                PlaygroundOptimizePromptRequestSchemaTemplateFormat.FString => "f-string",
                PlaygroundOptimizePromptRequestSchemaTemplateFormat.Mustache => "mustache",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundOptimizePromptRequestSchemaTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => PlaygroundOptimizePromptRequestSchemaTemplateFormat.FString,
                "mustache" => PlaygroundOptimizePromptRequestSchemaTemplateFormat.Mustache,
                _ => null,
            };
        }
    }
}