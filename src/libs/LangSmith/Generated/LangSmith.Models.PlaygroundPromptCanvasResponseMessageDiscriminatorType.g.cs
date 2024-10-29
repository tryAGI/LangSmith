
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundPromptCanvasResponseMessageDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
        /// <summary>
        /// 
        /// </summary>
        Human,
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        AIMessageChunk,
        /// <summary>
        /// 
        /// </summary>
        HumanMessageChunk,
        /// <summary>
        /// 
        /// </summary>
        ChatMessageChunk,
        /// <summary>
        /// 
        /// </summary>
        SystemMessageChunk,
        /// <summary>
        /// 
        /// </summary>
        FunctionMessageChunk,
        /// <summary>
        /// 
        /// </summary>
        ToolMessageChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaygroundPromptCanvasResponseMessageDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundPromptCanvasResponseMessageDiscriminatorType value)
        {
            return value switch
            {
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.Ai => "ai",
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.Human => "human",
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.Chat => "chat",
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.System => "system",
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.Function => "function",
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.Tool => "tool",
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.AIMessageChunk => "AIMessageChunk",
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.HumanMessageChunk => "HumanMessageChunk",
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.ChatMessageChunk => "ChatMessageChunk",
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.SystemMessageChunk => "SystemMessageChunk",
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.FunctionMessageChunk => "FunctionMessageChunk",
                PlaygroundPromptCanvasResponseMessageDiscriminatorType.ToolMessageChunk => "ToolMessageChunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundPromptCanvasResponseMessageDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.Ai,
                "human" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.Human,
                "chat" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.Chat,
                "system" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.System,
                "function" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.Function,
                "tool" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.Tool,
                "AIMessageChunk" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.AIMessageChunk,
                "HumanMessageChunk" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.HumanMessageChunk,
                "ChatMessageChunk" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.ChatMessageChunk,
                "SystemMessageChunk" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.SystemMessageChunk,
                "FunctionMessageChunk" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.FunctionMessageChunk,
                "ToolMessageChunk" => PlaygroundPromptCanvasResponseMessageDiscriminatorType.ToolMessageChunk,
                _ => null,
            };
        }
    }
}