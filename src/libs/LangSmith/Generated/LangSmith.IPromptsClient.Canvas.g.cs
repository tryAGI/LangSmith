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
            global::LangSmith.PlayGroundGraph request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Canvas
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="highlighted"></param>
        /// <param name="artifact"></param>
        /// <param name="next"></param>
        /// <param name="artifactLength"></param>
        /// <param name="readingLevel"></param>
        /// <param name="lastNodeName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CanvasAsync(
            global::System.Collections.Generic.IList<global::LangSmith.MessagesItem> messages,
            global::LangSmith.Artifact artifact,
            global::LangSmith.Highlight? highlighted = default,
            string? next = default,
            global::LangSmith.PlayGroundGraphArtifactLength? artifactLength = default,
            global::LangSmith.PlayGroundGraphReadingLevel? readingLevel = default,
            string? lastNodeName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}