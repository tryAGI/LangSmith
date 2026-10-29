
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: mustache
    /// </summary>
    public enum DecisionModelRuleCreateSchemaTemplateFormat
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
    public static class DecisionModelRuleCreateSchemaTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionModelRuleCreateSchemaTemplateFormat value)
        {
            return value switch
            {
                DecisionModelRuleCreateSchemaTemplateFormat.FString => "f-string",
                DecisionModelRuleCreateSchemaTemplateFormat.Mustache => "mustache",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionModelRuleCreateSchemaTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => DecisionModelRuleCreateSchemaTemplateFormat.FString,
                "mustache" => DecisionModelRuleCreateSchemaTemplateFormat.Mustache,
                _ => null,
            };
        }
    }
}