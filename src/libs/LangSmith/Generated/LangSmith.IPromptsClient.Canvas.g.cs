#nullable enable

namespace LangSmith
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Canvas
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CanvasAsync(
            global::LangSmith.PlaygroundPromptCanvasPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Canvas
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="highlighted"></param>
        /// <param name="artifact"></param>
        /// <param name="artifactLength"></param>
        /// <param name="readingLevel"></param>
        /// <param name="templateFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CanvasAsync(
            global::System.Collections.Generic.IList<global::LangSmith.MessagesItem> messages,
            global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat templateFormat,
            global::LangSmith.Highlight? highlighted = default,
            global::LangSmith.Artifact? artifact = default,
            global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength? artifactLength = default,
            global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel? readingLevel = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}