#nullable enable

namespace LangSmith
{
    public partial interface IPlaygroundClient
    {
        /// <summary>
        /// Invoke Handler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.InvokeHandlerApiV1PlaygroundInvokePostResponse> InvokeHandlerAsync(
            global::LangSmith.PlaygroundInvokeRequestSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Invoke Handler
        /// </summary>
        /// <param name="manifest"></param>
        /// <param name="secrets"></param>
        /// <param name="runId"></param>
        /// <param name="repoId"></param>
        /// <param name="tools"></param>
        /// <param name="options">
        /// Configuration for a Runnable.
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="input"></param>
        /// <param name="repetitions">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.InvokeHandlerApiV1PlaygroundInvokePostResponse> InvokeHandlerAsync(
            global::LangSmith.PlaygroundInvokeRequestSchemaManifest manifest,
            global::LangSmith.PlaygroundInvokeRequestSchemaSecrets secrets,
            global::LangSmith.RunnableConfig options,
            global::LangSmith.PlaygroundInvokeRequestSchemaInput input,
            global::LangSmith.AnyOf<string, object>? runId = default,
            global::LangSmith.AnyOf<string, object>? repoId = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PlaygroundInvokeRequestSchemaToolsVariant1Item>, object>? tools = default,
            global::LangSmith.AnyOf<string, object>? projectName = default,
            int? repetitions = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}