#nullable enable

namespace LangSmith
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Invoke Prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.InvokePromptApiV1PromptsInvokePromptPostResponse> InvokePromptAsync(
            global::LangSmith.InvokePromptPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Invoke Prompt
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="templateFormat"></param>
        /// <param name="inputs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.InvokePromptApiV1PromptsInvokePromptPostResponse> InvokePromptAsync(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> messages,
            string templateFormat,
            object inputs,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}