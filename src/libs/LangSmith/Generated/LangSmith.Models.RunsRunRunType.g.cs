
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
        Tool,
        /// <summary>
        /// 
        /// </summary>
        Chain,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Retriever,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Parser,
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
                RunsRunRunType.Tool => "tool",
                RunsRunRunType.Chain => "chain",
                RunsRunRunType.Llm => "llm",
                RunsRunRunType.Retriever => "retriever",
                RunsRunRunType.Embedding => "embedding",
                RunsRunRunType.Prompt => "prompt",
                RunsRunRunType.Parser => "parser",
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
                "tool" => RunsRunRunType.Tool,
                "chain" => RunsRunRunType.Chain,
                "llm" => RunsRunRunType.Llm,
                "retriever" => RunsRunRunType.Retriever,
                "embedding" => RunsRunRunType.Embedding,
                "prompt" => RunsRunRunType.Prompt,
                "parser" => RunsRunRunType.Parser,
                _ => null,
            };
        }
    }
}