
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunsRunRunType
    {
        /// <summary>
        /// 
        /// </summary>
        Chain,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Parser,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Retriever,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunsRunRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunsRunRunType value)
        {
            return value switch
            {
                RunsRunRunType.Chain => "chain",
                RunsRunRunType.Embedding => "embedding",
                RunsRunRunType.Llm => "llm",
                RunsRunRunType.Parser => "parser",
                RunsRunRunType.Prompt => "prompt",
                RunsRunRunType.Retriever => "retriever",
                RunsRunRunType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunsRunRunType? ToEnum(string value)
        {
            return value switch
            {
                "chain" => RunsRunRunType.Chain,
                "embedding" => RunsRunRunType.Embedding,
                "llm" => RunsRunRunType.Llm,
                "parser" => RunsRunRunType.Parser,
                "prompt" => RunsRunRunType.Prompt,
                "retriever" => RunsRunRunType.Retriever,
                "tool" => RunsRunRunType.Tool,
                _ => null,
            };
        }
    }
}