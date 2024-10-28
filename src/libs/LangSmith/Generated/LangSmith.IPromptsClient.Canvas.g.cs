#nullable enable

namespace LangSmith
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Canvas<br/>
        /// Improve prompt based on instruction.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CanvasAsync(
            global::LangSmith.PlaygroundOptimizePromptRequestSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Canvas<br/>
        /// Improve prompt based on instruction.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="highlightStart"></param>
        /// <param name="highlightEnd"></param>
        /// <param name="improvementInstruction"></param>
        /// <param name="templateFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CanvasAsync(
            string prompt,
            string improvementInstruction,
            global::LangSmith.PlaygroundOptimizePromptRequestSchemaTemplateFormat templateFormat,
            int? highlightStart = default,
            int? highlightEnd = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}