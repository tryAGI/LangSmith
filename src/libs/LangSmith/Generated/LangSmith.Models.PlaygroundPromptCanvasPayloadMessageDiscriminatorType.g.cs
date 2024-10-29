
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundPromptCanvasPayloadMessageDiscriminatorType
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
    public static class PlaygroundPromptCanvasPayloadMessageDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundPromptCanvasPayloadMessageDiscriminatorType value)
        {
            return value switch
            {
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.Ai => "ai",
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.Human => "human",
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.Chat => "chat",
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.System => "system",
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.Function => "function",
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.Tool => "tool",
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.AIMessageChunk => "AIMessageChunk",
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.HumanMessageChunk => "HumanMessageChunk",
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.ChatMessageChunk => "ChatMessageChunk",
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.SystemMessageChunk => "SystemMessageChunk",
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.FunctionMessageChunk => "FunctionMessageChunk",
                PlaygroundPromptCanvasPayloadMessageDiscriminatorType.ToolMessageChunk => "ToolMessageChunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundPromptCanvasPayloadMessageDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.Ai,
                "human" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.Human,
                "chat" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.Chat,
                "system" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.System,
                "function" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.Function,
                "tool" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.Tool,
                "AIMessageChunk" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.AIMessageChunk,
                "HumanMessageChunk" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.HumanMessageChunk,
                "ChatMessageChunk" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.ChatMessageChunk,
                "SystemMessageChunk" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.SystemMessageChunk,
                "FunctionMessageChunk" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.FunctionMessageChunk,
                "ToolMessageChunk" => PlaygroundPromptCanvasPayloadMessageDiscriminatorType.ToolMessageChunk,
                _ => null,
            };
        }
    }
}