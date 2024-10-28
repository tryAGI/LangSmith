
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlayGroundGraphMessageDiscriminatorType
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
    public static class PlayGroundGraphMessageDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayGroundGraphMessageDiscriminatorType value)
        {
            return value switch
            {
                PlayGroundGraphMessageDiscriminatorType.Ai => "ai",
                PlayGroundGraphMessageDiscriminatorType.Human => "human",
                PlayGroundGraphMessageDiscriminatorType.Chat => "chat",
                PlayGroundGraphMessageDiscriminatorType.System => "system",
                PlayGroundGraphMessageDiscriminatorType.Function => "function",
                PlayGroundGraphMessageDiscriminatorType.Tool => "tool",
                PlayGroundGraphMessageDiscriminatorType.AIMessageChunk => "AIMessageChunk",
                PlayGroundGraphMessageDiscriminatorType.HumanMessageChunk => "HumanMessageChunk",
                PlayGroundGraphMessageDiscriminatorType.ChatMessageChunk => "ChatMessageChunk",
                PlayGroundGraphMessageDiscriminatorType.SystemMessageChunk => "SystemMessageChunk",
                PlayGroundGraphMessageDiscriminatorType.FunctionMessageChunk => "FunctionMessageChunk",
                PlayGroundGraphMessageDiscriminatorType.ToolMessageChunk => "ToolMessageChunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayGroundGraphMessageDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => PlayGroundGraphMessageDiscriminatorType.Ai,
                "human" => PlayGroundGraphMessageDiscriminatorType.Human,
                "chat" => PlayGroundGraphMessageDiscriminatorType.Chat,
                "system" => PlayGroundGraphMessageDiscriminatorType.System,
                "function" => PlayGroundGraphMessageDiscriminatorType.Function,
                "tool" => PlayGroundGraphMessageDiscriminatorType.Tool,
                "AIMessageChunk" => PlayGroundGraphMessageDiscriminatorType.AIMessageChunk,
                "HumanMessageChunk" => PlayGroundGraphMessageDiscriminatorType.HumanMessageChunk,
                "ChatMessageChunk" => PlayGroundGraphMessageDiscriminatorType.ChatMessageChunk,
                "SystemMessageChunk" => PlayGroundGraphMessageDiscriminatorType.SystemMessageChunk,
                "FunctionMessageChunk" => PlayGroundGraphMessageDiscriminatorType.FunctionMessageChunk,
                "ToolMessageChunk" => PlayGroundGraphMessageDiscriminatorType.ToolMessageChunk,
                _ => null,
            };
        }
    }
}