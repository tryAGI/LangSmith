#nullable enable

namespace LangSmith
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Optimize Prompt<br/>
        /// Optimize prompt tables.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OptimizePromptResponse> OptimizePromptAsync(
            global::LangSmith.OptimizePromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Optimize Prompt<br/>
        /// Optimize prompt tables.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="metaprompt"></param>
        /// <param name="examples"></param>
        /// <param name="overallFeedback"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OptimizePromptResponse> OptimizePromptAsync(
            string prompt,
            object metaprompt,
            global::System.Collections.Generic.IList<global::LangSmith.ExampleRunWithFeedback> examples,
            string? overallFeedback,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}