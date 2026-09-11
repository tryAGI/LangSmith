
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ProductfeedbackSource
    {
        /// <summary>
        ///
        /// </summary>
        SourceLangSmithCLI,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProductfeedbackSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProductfeedbackSource value)
        {
            return value switch
            {
                ProductfeedbackSource.SourceLangSmithCLI => "LANGSMITH_CLI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProductfeedbackSource? ToEnum(string value)
        {
            return value switch
            {
                "LANGSMITH_CLI" => ProductfeedbackSource.SourceLangSmithCLI,
                _ => null,
            };
        }
    }
}