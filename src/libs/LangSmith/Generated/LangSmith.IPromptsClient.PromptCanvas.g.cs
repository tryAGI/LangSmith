#nullable enable

namespace LangSmith
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Prompt Canvas
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PromptCanvasAsync(
            global::LangSmith.PlaygroundPromptCanvasPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Prompt Canvas
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="highlighted"></param>
        /// <param name="artifact"></param>
        /// <param name="artifactLength"></param>
        /// <param name="readingLevel"></param>
        /// <param name="customAction"></param>
        /// <param name="templateFormat"></param>
        /// <param name="secrets"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PromptCanvasAsync(
            global::System.Collections.Generic.IList<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>> messages,
            global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat templateFormat,
            global::System.Collections.Generic.Dictionary<string, string> secrets,
            global::LangSmith.Highlight? highlighted = default,
            global::LangSmith.Artifact? artifact = default,
            global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength? artifactLength = default,
            global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel? readingLevel = default,
            string? customAction = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}