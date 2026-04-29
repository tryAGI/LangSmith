
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryRunType
    {
        /// <summary>
        /// 
        /// </summary>
        RunTypeChain,
        /// <summary>
        /// 
        /// </summary>
        RunTypeEmbedding,
        /// <summary>
        /// 
        /// </summary>
        RunTypeLLM,
        /// <summary>
        /// 
        /// </summary>
        RunTypeParser,
        /// <summary>
        /// 
        /// </summary>
        RunTypePrompt,
        /// <summary>
        /// 
        /// </summary>
        RunTypeRetriever,
        /// <summary>
        /// 
        /// </summary>
        RunTypeTool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryRunType value)
        {
            return value switch
            {
                QueryRunType.RunTypeChain => "CHAIN",
                QueryRunType.RunTypeEmbedding => "EMBEDDING",
                QueryRunType.RunTypeLLM => "LLM",
                QueryRunType.RunTypeParser => "PARSER",
                QueryRunType.RunTypePrompt => "PROMPT",
                QueryRunType.RunTypeRetriever => "RETRIEVER",
                QueryRunType.RunTypeTool => "TOOL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryRunType? ToEnum(string value)
        {
            return value switch
            {
                "CHAIN" => QueryRunType.RunTypeChain,
                "EMBEDDING" => QueryRunType.RunTypeEmbedding,
                "LLM" => QueryRunType.RunTypeLLM,
                "PARSER" => QueryRunType.RunTypeParser,
                "PROMPT" => QueryRunType.RunTypePrompt,
                "RETRIEVER" => QueryRunType.RunTypeRetriever,
                "TOOL" => QueryRunType.RunTypeTool,
                _ => null,
            };
        }
    }
}