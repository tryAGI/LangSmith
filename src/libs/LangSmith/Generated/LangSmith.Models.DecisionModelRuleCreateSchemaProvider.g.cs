
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// typesafe for Jev and SemIf, typesafe_compatible for a TypeSafe-compatible endpoint, or openai_decisions.<br/>
    /// Default Value: typesafe
    /// </summary>
    public enum DecisionModelRuleCreateSchemaProvider
    {
        /// <summary>
        ///
        /// </summary>
        OpenaiDecisions,
        /// <summary>
        ///
        /// </summary>
        Typesafe,
        /// <summary>
        ///
        /// </summary>
        TypesafeCompatible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionModelRuleCreateSchemaProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionModelRuleCreateSchemaProvider value)
        {
            return value switch
            {
                DecisionModelRuleCreateSchemaProvider.OpenaiDecisions => "openai_decisions",
                DecisionModelRuleCreateSchemaProvider.Typesafe => "typesafe",
                DecisionModelRuleCreateSchemaProvider.TypesafeCompatible => "typesafe_compatible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionModelRuleCreateSchemaProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai_decisions" => DecisionModelRuleCreateSchemaProvider.OpenaiDecisions,
                "typesafe" => DecisionModelRuleCreateSchemaProvider.Typesafe,
                "typesafe_compatible" => DecisionModelRuleCreateSchemaProvider.TypesafeCompatible,
                _ => null,
            };
        }
    }
}